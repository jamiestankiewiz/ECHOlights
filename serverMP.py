import sys
import socket
import queue as Q
import time
from multiprocessing import Process, Queue


def socketBinding(host,port_num):
    """
    This function creates the socket and binds to the given ip address an host
    """
    try:
        s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        s.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
        s.bind((host,port_num))
        s.listen(1)
        clientSocket, address = s.accept()
        print("Socket bind completed")
        print("Connection from {0} has been established",address)
    except socket.error as msg:
        print(msg)
    
    return clientSocket

def read_message(q,sock):
    """
    This function reads the message from the client and stores the message in the queue
    """
    while True:
      data = sock.recv(1024)
      data = data.decode('utf-8')
      dataMessage = data.split(' ',1)
      command = dataMessage[0]

      print(command)
      q.put(command)

def christmasLight():
  while True:
    print("christmas light")
    time.sleep(0.5)

def rainbow():
  while True:
    print("rainbow")
    time.sleep(0.5)


def main():
    #Process arguments
    # parser = argparse.ArgumentParser()
    # parser.add_argument('-c', '--clear', action='store_true', help='clear the display on exit')
    # args = parser.parse_args()

    # # Create NeoPixel object with appropriate configuration.
    # strip = Adafruit_NeoPixel(LED_COUNT, LED_PIN, LED_FREQ_HZ, LED_DMA, LED_INVERT, LED_BRIGHTNESS, LED_CHANNEL)
    # strip.begin()

    host = ''
    port_num = 7804
    isConnected = False
    mySocket = None
    # pdb.set_trace()

    # setting the socket connection
    clientSocket = socketBinding(host,port_num)

    q = Queue()
    r = Process(target = read_message, args=(q,clientSocket))
    r.start()

    print ("client loop started")
    t = None   # the processing thread
    while True:
        m = q.get()
        print(m)
        
        if m == 'christmas':
            if t:
                print("processing thread already started")
            else:
                t = Process(target = christmasLight)
                t.start()
                print("processing thread started")
        elif m == "rainbow":
            if t:
                print("processing thread already started")
            else:
                t = Process(target = rainbow)
                t.start()
                print("processing thread started")
        elif m == "stop":
            if t:
                t.terminate()
                t = None
                print("processing thread stopped")
            else:
                print("processing thread not running")

        # elif m == "quit":
        #     print("shutting down")
        #     if t:
        #         t.terminate()
        #         t = None  # play it safe
        #     break
        # else:
        #     print("huh?")
    r.terminate()


    # while True:
    #     try:
    #         if not isConnected:
    #             mySocket =  socketConnecting(s)
    #             print(f"Connection established. Port: {port_num}")

    #         dataTransfer(mySocket)

    #     except KeyboardInterrupt:
    #         print("Closing socket connection...")
    #         if mySocket in locals():
    #             mySocket.close()
    #         break
    #     finally:
    #         print("Connection terminated")
    #         print("------------------------")

if __name__ == "__main__": 
    main()