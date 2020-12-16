import sys
import socket
import queue as Q
import time
from multiprocessing import Process, Queue
import echoLights
from rpi_ws281x import *

PORT = 7804

def socketBinding(port):
    """
    This function creates the socket and binds to the given ip address an host.
    """
    try:
        s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        s.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
        s.bind(port)
        s.listen(1)
        clientSocket, address = s.accept()
        print("Socket bind completed")
        print("Connection from {address} has been established")
        return clientSocket
    except socket.error as msg:
        print(msg)
    return clientSocket

def readMessage(q, sock):
    """
    This function reads the message from the client and stores the message in
    the queue.
    """
    while True:
      data = sock.recv(1024)
      data = data.decode('utf-8')
      dataMessage = data.split(' ', 1)
      command = dataMessage[0]
      q.put(command)

def sendMessage(msg, port):
    """
    This function writes the message from the server to the client.
    """
    sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM) 
    sock.sendto(msg, port)

def christmasLight():
  while True:
    print("christmas light")
    time.sleep(0.5)

def rainbow():
  while True:
    print("rainbow")
    time.sleep(0.5)

def main():
    # Create NeoPixel object with appropriate configuration.
    strip = Adafruit_NeoPixel(LED_COUNT,
                              LED_PIN,
                              LED_FREQ_HZ,
                              LED_DMA,
                              LED_INVERT,
                              LED_BRIGHTNESS,
                              LED_CHANNEL
                              )
    strip.begin()

    info = ('', PORT) # host and port number

    # setting the socket connection
    clientSocket = socketBinding(info)

    queue = Queue()
    main_process = None   # the read processing thread
    message_process = None   # the main processing thread

    while True:
        if message_process == None:
            message_process = Process(target=readMessage,
                                      args=(queue, clientSocket))
            message_process.start()
            print ("client loop started")

        msg = queue.get()
        

        if msg == "stop":
            if main_process:
                main_process.terminate()
                main_process = None
                print("processing thread stopped")
            else:
                print("processing thread not running")
        elif msg == "quit":
            print("shutting down...")
            clientSocket.send(str.encode('quit'))
            if main_process:
                main_process.terminate()
                main_process = None  # play it safe
            if message_process:
                message_process.terminate()
                message_process = None
            clientSocket.close()
            break
        else:
            main_process = Process(target=light_command[msg](strip))
            main_process.start()

        # if msg == 'christmas':
        #     if main_process:
        #         print("processing thread already started")
        #     else:
        #         main_process = Process(target = christmasLight)
        #         main_process.start()
        #         print("processing thread started")
        # elif msg == "rainbow":
        #     if main_process:
        #         print("processing thread already started")
        #     else:
        #         main_process = Process(target = rainbow)
        #         main_process.start()
        #         print("processing thread started")


if __name__ == "__main__": 
    while True:
        main()