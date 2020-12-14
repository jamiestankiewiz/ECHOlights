import socket
from echoLights import *
import time
from neopixel import *
#import neopixel
import argparse


host = ''
port_num = 7772
isConnected = False

def setupServer():
    s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    try:
        s.bind((host,port_num))
    except socket.error as msg:
        print(msg)
    print("Socket bind completed")
    return s

def setupConnection():
    s.listen(1)
    clientSocket, address = s.accept()
    print("Connection from {0} has been established",address)
    isConnected = True
    return clientSocket

def dataTransfer(clientSocket):
    try:
        while True:
            data = clientSocket.recv(1024)
            data = data.decode('utf-8')
            dataMessage = data.split(' ',1)
            command = dataMessage[0]

            if command == 'error':
                reply = 'error' # LED light
                clientSocket.send(str.encode(reply))
                colorWipe(strip, Color(0, 255, 0))

            elif command in light_command.keys():
                    light_command[command](strip)

            elif command == 'testing1':
                time.sleep(5)
                reply = 'testing 1 success'
                print("Sending Message: " + reply)
                clientSocket.send(str.encode(reply))

            elif command == 'testing2':
                time.sleep(7)
                reply = 'testing 2 success'
                print("Sending Message: " + reply)
                clientSocket.send(str.encode(reply))

#    time.sleep(5)
            #if command == 'halt':
            #   populate Queue with something

            elif command == 'exit':
                reply = 'exit'
                clientSocket.send(str.encode(reply))
                clientSocket.close()
                break

            elif command == 'off':
                reply = 'off'
                clientSocket.send(str.encode(reply))
                colorWipe(strip, Color(0, 0, 0))
               # theaterChase(strip, Color(0,0,0), 10)

            else:
                reply = 'unknownCommand'
                clientSocket.send(str.encode(reply))
    except Exception as error:
        print("Error in dataTransfer function\n" + repr(error))


def closeConnection(clientSocket):
    clientSocket.close()

if __name__ == "__main__": 
    s = setupServer()

    #Process arguments
    parser = argparse.ArgumentParser()
    parser.add_argument('-c', '--clear', action='store_true', help='clear the display on exit')
    args = parser.parse_args()

    # Create NeoPixel object with appropriate configuration.
    strip = Adafruit_NeoPixel(LED_COUNT, LED_PIN, LED_FREQ_HZ, LED_DMA, LED_INVERT, LED_BRIGHTNESS, LED_CHANNEL)
    # Intialize the library (must be called once before other functions).
    #pdb.set_trace()clientSocket.close()

    strip.begin()

    #####
    ## ADD 



    while True:
        try:
            if not isConnected: ## no need .fix later
                conn = setupConnection()
                print(f"Connection established. Port: {port_num}")
            dataTransfer(conn)

        except KeyboardInterrupt:
            print("Closing socket connection...")
            s.close()
            break
        finally:
            print("Connection terminated")
            print("------------------------")
            #closeConnection(conn)
