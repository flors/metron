#include <Wire.h>
#include <Adafruit_PWMServoDriver.h>

#define MAX_INPUT 90

char inputBuffer[MAX_INPUT + 1]; // Handles up to 90 bytes in a c-style string, with a null character termination.


// called this way, it uses the default address 0x40
Adafruit_PWMServoDriver pwm = Adafruit_PWMServoDriver();
// you can also call it with a different address you want
//Adafruit_PWMServoDriver pwm = Adafruit_PWMServoDriver(0x41);
// you can also call it with a different address and I2C interface
//Adafruit_PWMServoDriver pwm = Adafruit_PWMServoDriver(&Wire, 0x40);

// Depending on your servo make, the pulse width min and max may vary, you
// want these to be as small/large as possible without hitting the hard stop
// for max range. You'll have to tweak them as necessary to match the servos you
// have!
//#define SERVOMIN  300 // this is the 'minimum' pulse length count (out of 4096)
//#define SERVOMAX  480 // this is the 'maximum' pulse length count (out of 4096)

#define SERVOMIN  150 // this is the 'minimum' pulse length count (out of 4096)
#define SERVOMAX  600// this is the 'maximum' pulse length count (out of 4096)

#define NUM_OF_SERVOS 2
int PWMpins[NUM_OF_SERVOS] = { 3, 9 };

byte PWMbyte[NUM_OF_SERVOS];
int temp_val;

// our servo # counter
uint8_t servonum = 0;
uint8_t brightness = 255;


void setup() {
  Serial.begin(230400);
  pwm.begin();

  pwm.setPWMFreq(60);  // Analog servos run at ~60 Hz updates

}


void loop() {

  while (Serial.available() > 0) {

    //Code working for controlling 4 servos with same value
    byte PWMbyte = Serial.read();
    float pulselength = map(PWMbyte, 0, 180, SERVOMIN, SERVOMAX);

    pwm.setPWM(0, 0, pulselength);
    pwm.setPWM(1, 0, pulselength);
    /*  pwm.setPWM(3, 0, pulselength1);
      pwm.setPWM(4, 0, pulselength1);
      pwm.setPWM(12, 0, pulselength1);
      pwm.setPWM(13, 0, pulselength2);
      pwm.setPWM(14, 0, pulselength2);
      pwm.setPWM(15, 0, pulselength2);*/

  /*  byte inByte = Serial.read();
    if ((inByte >= '0') && (inByte <= '9')) {
      temp_val = temp_val * 10 + inByte - '0';
    } else if ((inByte >= 'a') && (inByte <= 'z')) {
      if (inByte - 'a' >= NUM_OF_SERVOS) break;
      PWMbyte[inByte - 'a'] = temp_val;
      temp_val = 0;
    }
    for (int i = 0; i < NUM_OF_SERVOS; i++) {
      //servos[i].write(PWMbyte[i]);
      float pulselength = map(PWMbyte[i], 0, 180, SERVOMIN, SERVOMAX);
      pwm.setPWM(i, 0, pulselength);
    }*/


   
  }



}
