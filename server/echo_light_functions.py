import time
from rpi_ws281x import * # 11/6/20 changed from neopixel to rpi_ws281x
import random

# LED strip configuration:
LED_COUNT      = 454   # Number of LED pixels.
LED_PIN        = 18      # PWM18GPIO pin connectend to the pixels (18 uses PWM!)
#LED_PIN        = 10      # GPIO pin connected to the pixels
						  #(10 uses SPI /dev/spidev0.0).
LED_FREQ_HZ    = 800000  # LED signal frequency in hertz (usually 800khz)
LED_DMA        = 10      # DMA channel to use for generating signal (try 10)
LED_BRIGHTNESS = 50     # Set to 0 for darkest and 255 for brightest
LED_INVERT     = False   # True to invert the signal (when using NPN transistor
						 # level shift)
LED_CHANNEL    = 0       # set to '1' for GPIOs 13, 19, 41, 45 or 53
RED = Color(255, 0, 0)
GREEN = Color(0, 255, 0)
WHITE = Color(255, 255, 255)
BLANK = Color(0, 0, 0)

def SetAllOff(strip):
    """Wipe color across display a pixel at a time."""
    for i in range(strip.numPixels()):
        strip.setPixelColor(i, BLANK)
        strip.show()

    print("done")

def SetAll(strip, color):
    """Wipe color across display a pixel at a time."""
    for i in range(strip.numPixels()):
        strip.setPixelColor(i, color)

def random_color():
        r = random.randint(0, 256)
        g = random.randint(0, 256)
        b = random.randint(0, 256)
        return Color(r, g, b)

def asc_desc(start, finish):
    return list(range(start, finish)) + list(range(finish, start, -1))

def alternate_single(strip, color=None, wait_ms=1):
    if not color:
        color = random_color()
    while True:
        for led in range(0, strip.numPixels(), 2):
            for i in range(2):
                strip.setPixelColor(led + i%2, color)
                strip.setPixelColor(led + i%2 + 1, BLANK)
                strip.show()
            time.sleep(wait_ms/1000)

def zip_down_back(strip, wait_ms=1):
    color = random_color()
    while True:
        for led in list(range(int(strip.numPixels()))) + \
                    list(range(int(strip.numPixels()), -2, -1)):
            strip.setPixelColor(led, color)
            strip.show()
            time.sleep(wait_ms/1000)
            strip.setPixelColor(led, BLANK)

def stack(strip, color=None, wait_ms=1):
    color = random_color()
    while True:
        for led_end_pos in range(strip.numPixels()+1, -1, -1):
            for led in range(led_end_pos-1):
                strip.setPixelColor(led, color)
                strip.show()
                time.sleep(wait_ms/1000.0)
                strip.setPixelColor(led, BLANK)
            strip.setPixelColor(led, color)
        for _ in range(4):
            SetAll(strip, BLANK)
            strip.show()
            time.sleep(wait_ms/1000)
            SetAll(strip, color)
            strip.show()
            time.sleep(wait_ms/1000)

def MeteorRain(strip, MeteorSize=5, MeteorTrailDecay=64,
               MeteorRandomDecay=True, SpeedDelay=.1):
    SetAll(strip, BLANK)
    for i in range(0, LED_COUNT + LED_COUNT):
        # Fade brightness all LEDs one step
        for j in range(0, LED_COUNT):
            if ((not MeteorRandomDecay) or ((random.randint(0, 10) > 5))):
                FadeToBlack(strip, j, MeteorTrailDecay)
        # Draw meteor
        for j in range(0, MeteorSize):
            if (((i - j) < LED_COUNT) and ((i - j) >= 0)):
                strip.setPixelColor(i - j, WHITE)
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
        r = r - (r*FadeValue/256)
    if (g <= 10):
        g = 0;
    else:
        g = g - (g*FadeValue/256)
    if (b <= 10):
        b = 0;
    else:
        b = b - (b*FadeValue/256)
    strip.setPixelColor(Position, Color(r, g, b))

def FillDownRandom(strip, SpeedDelay=0, DisplayDelay=.1, PauseDelay=1,
				   FlushDelay=.2):
    SetAll(strip, BLANK)
    #Fill down with random colors
    for i in range(0, LED_COUNT):
        for j in range(0,LED_COUNT-i):
            strip.setPixelColor(j, random_color())
            if j > 0:
                strip.setPixelColor(j-1, BLANK)
            strip.show()
            time.sleep(SpeedDelay)
        time.sleep(DisplayDelay)
    time.sleep(PauseDelay)
    #"Flush" results
    for i in range(LED_COUNT-1, -1, -1):
        for j in range(LED_COUNT-1, 0, -1):
            OldColor = strip.getPixelColor(j-1)
            strip.setPixelColor(j, OldColor)
        strip.setPixelColor(i-LED_COUNT+1, BLANK)
        strip.show()
        time.sleep(FlushDelay)
    time.sleep(PauseDelay)

def RandomColors(strip, SpeedDelay=.1):
    SetAll(strip, BLANK)
    while True:
        for i in range(0, LED_COUNT):
            strip.setPixelColor(i, random_color())
        strip.show()
        time.sleep(SpeedDelay)

def christmas(strip):
    colors = [RED, BLANK, GREEN, BLANK]
    print("CHRISTMAS")
    while True:
        for i in range(4):
            print("CHRISTMAS-while")
            for color_iter in range(4):
                for light_pos in range(0, strip.numPixels(), 4):
                    strip.setPixelColor(light_pos+color_iter+i%4,
                                        colors[color_iter])
            strip.show()
            time.sleep(1000/1000.0)

# Define functions which animate LEDs in various ways.
def colorWipe(strip, color=None, wait_ms=1000):
    """Wipe color across display a pixel at a time."""
    if not color:
        color = random_color()
    for i in range(strip.numPixels()):
        strip.setPixelColor(i, color)
    strip.show()
    time.sleep(wait_ms/1000.0)

def theaterChase(strip, wait_ms=100):
    """Movie theater light style chaser animation."""
    color = random_color()
    while True:
        for q in range(3):
            for i in range(0, strip.numPixels(), 3):
                strip.setPixelColor(i+q, color)
            strip.show()
            time.sleep(wait_ms/1000.0)
            for i in range(0, strip.numPixels(), 3):
                strip.setPixelColor(i+q, 0)

def wheel(pos):
    """Generate rainbow colors across 0-255 positions."""
    if pos < 85:
        return Color(pos*3, 255-pos*3, 0)
    elif pos < 170:
        pos -= 85
        return Color(255-pos*3, 0, pos*3)
    else:
        pos -= 170
        return Color(0, pos*3, 255-pos*3)

def rainbow(strip, wait_ms=20):
    """Draw rainbow that fades across all pixels at once."""
    while True:
        for j in range(256):
            for i in range(strip.numPixels()):
                strip.setPixelColor(i, wheel((i+j) & 255))
            strip.show()
            time.sleep(wait_ms/1000.0)

def rainbowCycle(strip, wait_ms=20):
    """Draw rainbow that uniformly distributes itself across all pixels."""
    while True:
        for j in range(256):
            for i in range(strip.numPixels()):
                strip.setPixelColor(i, wheel(
                                            (int(i*256/strip.numPixels())+j) & 255))
            strip.show()
            time.sleep(wait_ms/1000.0)

def theaterChaseRainbow(strip, wait_ms=50):
    """Rainbow movie theater light style chaser animation."""
    while True:
        for j in range(256):
            for q in range(3):
                for i in range(0, strip.numPixels(), 3):
                    strip.setPixelColor(i+q, wheel((i+j) % 255))
                strip.show()
                time.sleep(wait_ms/1000.0)
                for i in range(0, strip.numPixels(), 3):
                    strip.setPixelColor(i+q, 0)

light_command = {
    'init': rainbowCycle, #sus
    'color': colorWipe, # working
    'rainbow': rainbow, # sus
    'rainbowCycle': rainbowCycle, #sus
    'meteorRain': MeteorRain, # failed
    'fillRandom': FillDownRandom, # working
    'randomColors': RandomColors, # working
    'theaterChase': theaterChase, # working
    'theaterChaseRainbow': theaterChaseRainbow, # working
    'christmas': christmas, # working
    'alternateSingle': alternate_single, # woring, needs debugging
    'zip': zip_down_back, # update time
    'stack': stack, # update time
    'off': SetAll
}