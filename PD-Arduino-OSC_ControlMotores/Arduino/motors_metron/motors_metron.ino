
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



float value1, value2, value3, value4, value5, value6, value7, value8,
      value9, value10, value11, value12, value13, value14, value15, value16;

float values[38];
float pulselengths[38];


//UDP communication
EthernetUDP Udp;
byte mac[] = {
  0xDE, 0xAD, 0xBE, 0xEF, 0xFE, 0xED
}; // you can find this written on the board of some Arduino Ethernets or shields

//the Arduino's IP - Check advateck IP address
IPAddress ip(192, 168, 0, 55);

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

    for (int i = 0; i < 38; i ++) {
      values[i] = msg.getFloat(i + 1);
      pulselengths[i] = map(values[i], 0, 180, SERVOMIN, SERVOMAX);

    }


    for (int i = 0; i < 38; i ++) {
      pwm.setPWM(i, 0, pulselengths[i]);
    }


    /*value1 = msg.getFloat(1);
      value2 = msg.getFloat(2);
      value3 = msg.getFloat(3);
      value4 = msg.getFloat(4);
      value5 = msg.getFloat(5);
      value6 = msg.getFloat(6);
      value7 = msg.getFloat(7);
      value8 = msg.getFloat(8);
      value9 = msg.getFloat(9);
      value10 = msg.getFloat(10);
      value11 = msg.getFloat(11);
      value12 = msg.getFloat(12);
      value13 = msg.getFloat(13);
      value14 = msg.getFloat(14);
      value15 = msg.getFloat(15);
      value16 = msg.getFloat(16);*/

    //Serial.println(value1);
    //Serial.println(value2);
    //Serial.println(value3);

    /*float pulselength1 = map(value1, 0, 180, SERVOMIN, SERVOMAX);
      float pulselength2 = map(value2, 0, 180, SERVOMIN, SERVOMAX);
      float pulselength3 = map(value3, 0, 180, SERVOMIN, SERVOMAX);
      float pulselength4 = map(value4, 0, 180, SERVOMIN, SERVOMAX);
      float pulselength5 = map(value5, 0, 180, SERVOMIN, SERVOMAX);
      float pulselength6 = map(value6, 0, 180, SERVOMIN, SERVOMAX);
      float pulselength7 = map(value7, 0, 180, SERVOMIN, SERVOMAX);
      float pulselength8 = map(value8, 0, 180, SERVOMIN, SERVOMAX);
      float pulselength9 = map(value9, 0, 180, SERVOMIN, SERVOMAX);
      float pulselength10 = map(value10, 0, 180, SERVOMIN, SERVOMAX);
      float pulselength11 = map(value11, 0, 180, SERVOMIN, SERVOMAX);
      float pulselength12 = map(value12, 0, 180, SERVOMIN, SERVOMAX);
      float pulselength13 = map(value13, 0, 180, SERVOMIN, SERVOMAX);
      float pulselength14 = map(value3, 0, 180, SERVOMIN, SERVOMAX);
      float pulselength15 = map(value3, 0, 180, SERVOMIN, SERVOMAX);
      float pulselength16 = map(value3, 0, 180, SERVOMIN, SERVOMAX);*/

    /*pwm.setPWM(0, 0, pulselength1);
      pwm.setPWM(1, 0, pulselength2);
      pwm.setPWM(3, 0, pulselength3);
      pwm.setPWM(2, 0, pulselength4);
      pwm.setPWM(4, 0, pulselength5);
      pwm.setPWM(5, 0, pulselength6);
      pwm.setPWM(6, 0, pulselength7);
      pwm.setPWM(7, 0, pulselength8);
      pwm.setPWM(8, 0, pulselength9);
      pwm.setPWM(9, 0, pulselength10);
      pwm.setPWM(10, 0, pulselength11);
      pwm.setPWM(11, 0, pulselength12);
      pwm.setPWM(12, 0, pulselength13);
      pwm.setPWM(13, 0, pulselength14);
      pwm.setPWM(14, 0, pulselength15);
      pwm.setPWM(15, 0, pulselength16);*/

  }
}

void setup() {
  //setup ethernet part
  Ethernet.begin(mac, ip);
  Udp.begin(inPort);
  Serial.begin(9600);

  //Motors control
  pwm.begin();
  pwm.setPWMFreq(60);  // Analog servos run at ~60 Hz updates


}


//reads and dispatches the incoming message
void loop() {

  OSCBundle bundleIN;
  int size;

  if ( (size = Udp.parsePacket()) > 0) {
    while (size--)
      bundleIN.fill(Udp.read());

    //if (!bundleIN.hasError()) {
    //Serial.println("No error!");
    bundleIN.route("/motores", controlMotors);
    //} else {
    //Serial.println("Error!");
    //}
  }


}
