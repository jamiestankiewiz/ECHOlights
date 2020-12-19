import sys
import socket
import queue as Q
import time
from multiprocessing import Process, Queue
from echo_light_functions import *
from rpi_ws281x import *

PORT = 7813

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
        print(f"Connection from {address} has been established")
        return clientSocket
    except socket.error as msg:
        print(msg)
    #return clientSocket

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

def sendMessage(sock, msg, port):
    """
    This function writes the message from the server to the client.
    """
#     sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    # sock.send(str.encode(msg), port)
    sock.send(str.encode(msg))

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
                                    args=(queue, clientSocket,))
            message_process.start()
            print ("client loop started")

        msg = queue.get()
        print('message requested in queue: '+ msg)

        if msg == "stop":
            if main_process:
                main_process.terminate()
                main_process = None
                print("processing thread stopped")
            else:
                print("processing thread not running")
        elif msg == "quit":
            print("shutting down...")
            end_process = Process(target=sendMessage,args=(clientSocket, msg, PORT,))
            end_process.start()
#             sendMessage(clientSocket,msg, PORT)
#             clientsocket.send(str.encode(msg))
            print('after process')
            if main_process:
                main_process.terminate()
                main_process = None
            if message_process:
                message_process.terminate()
                message_process = None
            print('before off')

     #        main_process = process(target=setalloff, args=(strip,))
#             main_process.start()

            SetAllOff(strip)
            print('after off')
            clientSocket.close()
            print('after close')
#             end_process.terminate()
         #    main_process.terminate()
#             main_process = None
            break
        else:
            main_process = Process(target=light_command[msg], args=(strip,))
            main_process.start()

if __name__ == "__main__":
    try:
        while True:
            main()
    except KeyboardInterrupt:
        print("Terminating the program")