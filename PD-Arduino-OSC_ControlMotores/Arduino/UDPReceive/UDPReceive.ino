
#include <Ethernet.h>
#include <EthernetUdp.h>
#include <SPI.h>

#include <OSCBundle.h>
#include <OSCBoards.h>
#include <Adafruit_PWMServoDriver.h>

Adafruit_PWMServoDriver pwm = Adafruit_PWMServoDriver();

#define SERVOMIN  150 // this is the 'minimum' pulse length count (out of 4096)
#define SERVOMAX  600// this is the 'maximum' pulse length count (out of 4096)

/*
  UDPReceiveOSC
  Set a tone according to incoming OSC control
                            Adrian Freed
*/

//UDP communication


EthernetUDP Udp;
byte mac[] = {
  0xDE, 0xAD, 0xBE, 0xEF, 0xFE, 0xED
}; // you can find this written on the board of some Arduino Ethernets or shields

//the Arduino's IP
IPAddress ip(128, 32, 122, 252);

//port numbers
const unsigned int inPort = 8888;

//converts the pin to an osc address
char * numToOSCAddress( int pin) {
  static char s[10];
  int i = 9;

  s[i--] = '\0';
  do
  {
    s[i] = "0123456789"[pin % 10];
    --i;
    pin /= 10;
  }
  while (pin && i);
  s[i] = '/';
  return &s[i];
}

/**
   TONE

   square wave output "/tone"

   format:
   /tone/pin

     (digital value) (float value) = frequency in Hz
     (no value) disable tone

 **/

void routeTone(OSCMessage &msg, int addrOffset ) {





  if (msg.isInt(0)) {
   // Serial.println("Receiving message INT!");
    int value;
    value = msg.getInt(0);
    float pulselength = map(value, 0, 180, SERVOMIN, SERVOMAX);
    pwm.setPWM(0,0, pulselength);
    //Serial.println(value);
  } //otherwise it's a floating point frequency in Hz
  else if (msg.isFloat(0)) {
   // Serial.println("Receiving message FLOAT!");

    float value;
    value = msg.getFloat(0);
    float pulselength = map(value, 0, 180, SERVOMIN, SERVOMAX);
    pwm.setPWM(0, 0, pulselength);
  }

  //iterate through all the analog pins
  /*for(byte pin = 0; pin < NUM_DIGITAL_PINS; pin++){
    //match against the pin number strings
    int pinMatched = msg.match(numToOSCAddress(pin), addrOffset);
    if(pinMatched){
      unsigned int frequency = 0;
      //if it has an int, then it's an integers frequency in Hz
      if (msg.isInt(0)){
        frequency = msg.getInt(0);
      } //otherwise it's a floating point frequency in Hz
      else if(msg.isFloat(0)){
        frequency = msg.getFloat(0);
      }
      else
        noTone(pin);
      if(frequency>0)
      {
         if(msg.isInt(1))
           tone(pin, frequency, msg.getInt(1));
         else
           tone(pin, frequency);
      }
    }
    }*/
}

void setup() {
  //setup ethernet part
  Ethernet.begin(mac, ip);
  Udp.begin(inPort);

  Serial.begin(9600);

  pwm.begin();

  pwm.setPWMFreq(60);  // Analog servos run at ~60 Hz updates

}
//reads and dispatches the incoming message
void loop() {

  OSCBundle bundleIN;
  int size;

  if ( (size = Udp.parsePacket()) > 0)
  {
    while (size--)
      bundleIN.fill(Udp.read());

    //if (!bundleIN.hasError()) {
    //Serial.println("No error!");
    bundleIN.route("/tone", routeTone);
    //} else {
    //Serial.println("Error!");
    //}
  }


}
