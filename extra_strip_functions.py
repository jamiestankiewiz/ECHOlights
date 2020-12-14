from rpi_ws281x import *
import time
import random

LED_COUNT      = 454   # Number of LED pixels.
LED_PIN        = 18      # PWM18GPIO pin connectend to the pixels (18 uses PWM!).
#LED_PIN        = 10      # GPIO pin connected to the pixels (10 uses SPI /dev/spidev0.0).
LED_FREQ_HZ    = 800000  # LED signal frequency in hertz (usually 800khz)
LED_DMA        = 10      # DMA channel to use for generating signal (try 10)
LED_BRIGHTNESS = 50     # Set to 0 for darkest and 255 for brightest
LED_INVERT     = False   # True to invert the signal (when using NPN transistor level shift)
LED_CHANNEL    = 0       # set to '1' for GPIOs 13, 19, 41, 45 or 53

RED = (127, 0, 0)
GREEN = (0, 0, 255)
WHITE = (255, 255, 255)

# theaterChase(strip, Color(RED))  # Red theater chase
# MeteorRain(strip, WHITE, 5, 64, True, .1) # White meteor rain
# theaterChase(strip, Color(GREEN))  # Green theater chase
# FillDownRandom(strip, 0, .1, 1, .2)
# RandomColors(strip, .1)

def SetAll(strip, color):
    """Wipe color across display a pixel at a time."""
    for i in range(strip.numPixels()):
        strip.setPixelColor(i, color)

def MeteorRain(strip, MeteorSize=5, MeteorTrailDecay=64,
               MeteorRandomDecay=True, SpeedDelay=.1):
    SetAll(strip, Color(0, 0, 0))
    while True:
        for i in range(0, LED_COUNT + LED_COUNT):
            # Fade brightness all LEDs one step
            for j in range(0, LED_COUNT):
                if ((not MeteorRandomDecay) or ((random.randint(0, 10)>5))):
                    FadeToBlack(strip, j, MeteorTrailDecay)
            # Draw meteor
            for j in range(0, MeteorSize):
                if (((i - j) < LED_COUNT) and ((i - j) >= 0)):
                    strip.setPixelColor(i - j, Color(255, 255, 255))
            strip.show()
            time.sleep(SpeedDelay)

#Used by MeteorRain
def FadeToBlack(strip, Position, FadeValue):
    OldColor = strip.getPixelColor(Position)
    r = (OldColor & 0x00ff0000) >> 16
    g = (OldColor & 0x0000ff00) >> 8
    b = (OldColor & 0x000000ff)
    if (r <= 10):
        r = 0;
    else:
        r = r - (r * FadeValue / 256)
    if (g <= 10):
        g = 0;
    else:
        g = g - (g * FadeValue / 256)
    if (b <= 10):
        b = 0;
    else:
        b = b - (b * FadeValue / 256)
    strip.setPixelColor(Position, Color(r, g, b))

def FillDownRandom(strip, SpeedDelay=0, DisplayDelay=.1, PauseDelay=1, FlushDelay=.2):
    SetAll(strip, Color(0, 0, 0))
    #Fill down with random colors
    for i in range(0, LED_COUNT):
        r=random.randint(0, 255)
        g=random.randint(0, 255)
        b=random.randint(0, 255)
        for j in range(0,LED_COUNT-i):
            strip.setPixelColor(j, Color(r, g, b))
            if j>0:
                strip.setPixelColor(j-1, Color(0, 0, 0))
            strip.show()
            time.sleep(SpeedDelay)
        time.sleep(DisplayDelay)
    time.sleep(PauseDelay)
    #"Flush" results
    for i in range(LED_COUNT-1, -1, -1):
        for j in range(LED_COUNT-1, 0, -1):
            OldColor = strip.getPixelColor(j-1)
            strip.setPixelColor(j, OldColor)
        strip.setPixelColor(i-LED_COUNT+1, Color(0, 0, 0))
        strip.show()
        time.sleep(FlushDelay)
    time.sleep(PauseDelay)

def RandomColors(strip, SpeedDelay=.1):
    SetAll(strip, Color(0, 0, 0))
    while True:
        for i in range(0, LED_COUNT):
            r=random.randint(0, 255)
            g=random.randint(0, 255)
            b=random.randint(0, 255)
            strip.setPixelColor(i, Color(r, g, b))
        strip.show()
        time.sleep(SpeedDelay)

def christmas(strip):
    colors = [Color(255, 0, 0), Color(0, 0, 0), Color(0, 255, 0), Color(0, 0, 0)]
    while True:
        for color_iter in range(4):
            for light_pos in range(0, strip.numPixels(), 4):
                strip.setPixelColor(light_pos+color_iter+i%4, colors[color_iter])
        strip.show()
        time.sleep(1000/1000.0)