
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


void controlMotors(OSCMessage &msg, int addrOffset ) {

  if (msg.isFloat(0)) {
    //Serial.println("Receiving message FLOAT!");

    float value2, value3;
    value2 = msg.getFloat(2);
    value3 = msg.getFloat(3);
    float pulselength1 = map(value2, 0, 180, SERVOMIN, SERVOMAX);
    float pulselength2 = map(value3, 0, 180, SERVOMIN, SERVOMAX);
    pwm.setPWM(0, 0, pulselength1);
    pwm.setPWM(1, 0, pulselength1);
    pwm.setPWM(3, 0, pulselength2);
    pwm.setPWM(2, 0, pulselength2);
    pwm.setPWM(4, 0, pulselength2);
    pwm.setPWM(5, 0, pulselength2);
    pwm.setPWM(6, 0, pulselength2);
    pwm.setPWM(7, 0, pulselength2);
    pwm.setPWM(8, 0, pulselength2);
    pwm.setPWM(9, 0, pulselength2);
    pwm.setPWM(10, 0, pulselength2);
    pwm.setPWM(11, 0, pulselength2);

  }
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
    bundleIN.route("/caja1", controlMotors);
    //} else {
    //Serial.println("Error!");
    //}
  }


}
