#include <Ethernet.h>
#include <EthernetUdp.h>
#include <SPI.h>

#include <OSCBundle.h>
#include <OSCBoards.h>
#include <Adafruit_PWMServoDriver.h>

Adafruit_PWMServoDriver pwm_left = Adafruit_PWMServoDriver(0x40);
Adafruit_PWMServoDriver pwm_center = Adafruit_PWMServoDriver(0x41);
Adafruit_PWMServoDriver pwm_right = Adafruit_PWMServoDriver(0x42);

#define SERVOMIN  150 // this is the 'minimum' pulse length count (out of 4096)
#define SERVOMAX  600// this is the 'maximum' pulse length count (out of 4096)

//Motors - left panel
float pwm0_l, pwm1_l, pwm2_l, pwm3_l, pwm4_l, pwm5_l, pwm8_l, pwm9_l, pwm10_l, pwm11_l, pwm12_l, pwm13_l, pwm14_l, pwm15_l;

//Motors - center panel
float pwm0_c, pwm1_c, pwm2_c, pwm3_c, pwm4_c, pwm5_c, pwm6_c, pwm8_c, pwm9_c, pwm13_c, pwm14_c, pwm15_c;

//Motors - right panel
float pwm0_r, pwm1_r, pwm2_r, pwm3_r, pwm4_r, pwm5_r, pwm6_r, pwm7_r, pwm8_r, pwm9_r, pwm13_r, pwm14_r, pwm15_r;


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

    //READ AND SAVE DATA
    //Left panel
    pwm2_l = map(msg.getFloat(1), 0, 180, SERVOMIN, SERVOMAX); // WARNING!!! Check PD: which is the first motor value!???????
    pwm1_l = map(msg.getFloat(2), 0, 180, SERVOMIN, SERVOMAX);
    pwm0_l = map(msg.getFloat(3), 0, 180, SERVOMIN, SERVOMAX);
    pwm4_l = map(msg.getFloat(4), 0, 180, SERVOMIN, SERVOMAX);
    pwm3_l = map(msg.getFloat(5), 0, 180, SERVOMIN, SERVOMAX);
    pwm5_l = map(msg.getFloat(6), 0, 180, SERVOMIN, SERVOMAX);
    pwm8_l = map(msg.getFloat(7), 0, 180, SERVOMIN, SERVOMAX);
    pwm12_l = map(msg.getFloat(8), 0, 180, SERVOMIN, SERVOMAX);
    pwm9_l = map(msg.getFloat(9), 0, 180, SERVOMIN, SERVOMAX);
    pwm10_l = map(msg.getFloat(10), 0, 180, SERVOMIN, SERVOMAX);
    pwm13_l = map(msg.getFloat(11), 0, 180, SERVOMIN, SERVOMAX);
    pwm14_l = map(msg.getFloat(12), 0, 180, SERVOMIN, SERVOMAX);
    pwm15_l = map(msg.getFloat(13), 0, 180, SERVOMIN, SERVOMAX);

    //Center panel
    pwm1_c = map(msg.getFloat(14), 0, 180, SERVOMIN, SERVOMAX);
    pwm0_c = map(msg.getFloat(15), 0, 180, SERVOMIN, SERVOMAX);
    pwm4_c = map(msg.getFloat(16), 0, 180, SERVOMIN, SERVOMAX);
    pwm3_c = map(msg.getFloat(17), 0, 180, SERVOMIN, SERVOMAX);
    pwm2_c = map(msg.getFloat(18), 0, 180, SERVOMIN, SERVOMAX);
    pwm5_c = map(msg.getFloat(19), 0, 180, SERVOMIN, SERVOMAX);
    pwm6_c = map(msg.getFloat(20), 0, 180, SERVOMIN, SERVOMAX);
    pwm8_c = map(msg.getFloat(21), 0, 180, SERVOMIN, SERVOMAX);
    pwm9_c = map(msg.getFloat(22), 0, 180, SERVOMIN, SERVOMAX);
    pwm14_c = map(msg.getFloat(23), 0, 180, SERVOMIN, SERVOMAX);
    pwm13_c = map(msg.getFloat(24), 0, 180, SERVOMIN, SERVOMAX);
    pwm15_c = map(msg.getFloat(25), 0, 180, SERVOMIN, SERVOMAX);

    //Right panel
    pwm2_r = map(msg.getFloat(26), 0, 180, SERVOMIN, SERVOMAX);
    pwm1_r = map(msg.getFloat(27), 0, 180, SERVOMIN, SERVOMAX);
    pwm0_r = map(msg.getFloat(28), 0, 180, SERVOMIN, SERVOMAX);
    pwm5_r = map(msg.getFloat(29), 0, 180, SERVOMIN, SERVOMAX);
    pwm4_r = map(msg.getFloat(30), 0, 180, SERVOMIN, SERVOMAX);
    pwm7_r = map(msg.getFloat(31), 0, 180, SERVOMIN, SERVOMAX);
    pwm6_r = map(msg.getFloat(32), 0, 180, SERVOMIN, SERVOMAX);
    pwm3_r = map(msg.getFloat(33), 0, 180, SERVOMIN, SERVOMAX);
    pwm8_r = map(msg.getFloat(34), 0, 180, SERVOMIN, SERVOMAX);
    pwm9_r = map(msg.getFloat(35), 0, 180, SERVOMIN, SERVOMAX);
    pwm13_r = map(msg.getFloat(36), 0, 180, SERVOMIN, SERVOMAX);
    pwm14_r = map(msg.getFloat(37), 0, 180, SERVOMIN, SERVOMAX);
    pwm15_r = map(msg.getFloat(38), 0, 180, SERVOMIN, SERVOMAX);


    //MOVE MOTORS 
    //Left panel
    pwm_left.setPWM(0, 0, pwm0_l);
    pwm_left.setPWM(1, 0, pwm1_l);
    pwm_left.setPWM(2, 0, pwm2_l);
    pwm_left.setPWM(3, 0, pwm3_l);
    pwm_left.setPWM(4, 0, pwm4_l);
    pwm_left.setPWM(5, 0, pwm5_l);
    
    pwm_left.setPWM(8, 0, pwm8_l);
    pwm_left.setPWM(9, 0, pwm9_l);
    pwm_left.setPWM(10, 0, pwm10_l);
    pwm_left.setPWM(11, 0, pwm11_l);
    pwm_left.setPWM(12, 0, pwm12_l);
    pwm_left.setPWM(13, 0, pwm13_l);
    pwm_left.setPWM(14, 0, pwm14_l);
    pwm_left.setPWM(15, 0, pwm15_l);

    //Center panel
    pwm_center.setPWM(0, 0, pwm0_c);
    pwm_center.setPWM(1, 0, pwm1_c);
    pwm_center.setPWM(2, 0, pwm2_c);
    pwm_center.setPWM(3, 0, pwm3_c);
    pwm_center.setPWM(4, 0, pwm4_c);
    pwm_center.setPWM(5, 0, pwm5_c);
    pwm_center.setPWM(6, 0, pwm6_c);
    
    pwm_center.setPWM(8, 0, pwm8_c);
    pwm_center.setPWM(9, 0, pwm9_c);
    
    pwm_center.setPWM(13, 0, pwm13_c);
    pwm_center.setPWM(14, 0, pwm14_c);
    pwm_center.setPWM(15, 0, pwm15_c);
    
    //Right panel
    pwm_right.setPWM(0, 0, pwm0_r);
    pwm_right.setPWM(1, 0, pwm1_r);
    pwm_right.setPWM(2, 0, pwm2_r);
    pwm_right.setPWM(3, 0, pwm3_r);
    pwm_right.setPWM(4, 0, pwm4_r);
    pwm_right.setPWM(5, 0, pwm5_r);
    pwm_right.setPWM(6, 0, pwm6_r);
    pwm_right.setPWM(7, 0, pwm7_r);
    pwm_right.setPWM(8, 0, pwm8_r);
    pwm_right.setPWM(9, 0, pwm9_r);
    
    pwm_right.setPWM(13, 0, pwm13_r);
    pwm_right.setPWM(14, 0, pwm14_r);
    pwm_right.setPWM(15, 0, pwm15_r);
    




  }
}

void setup() {
  //setup ethernet part
  Ethernet.begin(mac, ip);
  Udp.begin(inPort);
  Serial.begin(9600);

  //Motors control
  pwm_left.begin();
  pwm_left.setPWMFreq(60);  // Analog servos run at ~60 Hz updates

  pwm_right.begin();
  pwm_right.setPWMFreq(60);

  pwm_center.begin();
  pwm_center.setPWMFreq(60);



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
