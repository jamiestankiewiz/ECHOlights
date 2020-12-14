import time
#from neopixel import * 11/6/20
from rpi_ws281x import * # 11/6/20 changed from neopixel to rpi_ws281x
import argparse
import pdb
from strip_functions import *
from extra_strip_functions import *
import asyncio

# LED strip configuration:
LED_COUNT      = 454   # Number of LED pixels.
LED_PIN        = 18      # PWM18GPIO pin connectend to the pixels (18 uses PWM!).
#LED_PIN        = 10      # GPIO pin connected to the pixels (10 uses SPI /dev/spidev0.0).
LED_FREQ_HZ    = 800000  # LED signal frequency in hertz (usually 800khz)
LED_DMA        = 10      # DMA channel to use for generating signal (try 10)
LED_BRIGHTNESS = 50     # Set to 0 for darkest and 255 for brightest
LED_INVERT     = False   # True to invert the signal (when using NPN transistor level shift)
LED_CHANNEL    = 0       # set to '1' for GPIOs 13, 19, 41, 45 or 53

light_command = {
    'init': rainbowCycle, #sus
    'color': colorWipe, # working
    'rainbow': rainbow, #sus
    'rainbow cycle': rainbowCycle, #sus
    'meteor rain': MeteorRain, # failed
    'fill random': FillDownRandom, #working
    'random colors': RandomColors, # working
    'theater chase': theaterChase, # working
    'theater chase rainbow': theaterChaseRainbow, #working
    'christmas': christmas # working!! :)
}

async def addTask(light_command, queue):
    while True:
        await queue.put(light_command)
        #put new stuff into queue?

async def getNextCommand(queue):
    while True:
        if len(queue) > 0:
            # interrupt current function
            print('Getting next item in queue')
            command = await queue.get()
            # execute?
            # light_command[command](strip)

async def main(light_command):
    myQueue = asyncio.Queue(loop=loop, maxsize=10)
    await asyncio.wait([addTask(light_command, myQueue), getNextCommand(myQueue)])


loop = asyncio.get_event_loop()
try:
    asyncio.ensure_future(myCoroutine())
    loop.run_forever(main(loop)) # instead of run_until_complete
finally:
    loop.close()


# if __name__ == '__main__':
#     # Create NeoPixel object with appropriate configuration.
#     strip = Adafruit_NeoPixel(LED_COUNT,
#                               LED_PIN,
#                               LED_FREQ_HZ,
#                               LED_DMA,
#                               LED_INVERT,
#                               LED_BRIGHTNESS,
#                               LED_CHANNEL
#                              )
#     # Intialize the library (must be called once before other functions).
#     # pdb.set_trace()
#     strip.begin()
#     main()
#     # print ('Press Ctrl-C to change light command!')
    # if not args.clear:
    #  print('Use "-c" argument to clear LEDs on exit')

    # colorWipe(strip, Color(255,255,255))
    # command = input('    Enter Light Command: ')
    # try:
    #     while True:
    #         # print('Executing {}'.format(command))
    #         try:
    #             # run async coroutines commands here
    #             if command == 'init':
    #                 colorWipe(strip, Color(255,255,255))
    #             elif command in light_command.keys():
    #                 light_command[command](strip)
    #             elif 'wheel' in command:
    #                 wheel(1)
    #             else:
    #                 print('command not found')
    #                 command = input('    Enter Light Command: ')
    #             time.sleep(500/1000.0)
    #         except KeyboardInterrupt:
    #             command = input('    Enter Light Command: ')
    #             time.sleep(500/1000.0)
    #         finally:
    #             # (while) listen to "queue" here
    #             # wipe and start a new loop

    # except KeyboardInterrupt:
    #     print('\nThank you for using the ECHO lights. Have a nice day! :)')
    #     colorWipe(strip, Color(0,0,0), 10)