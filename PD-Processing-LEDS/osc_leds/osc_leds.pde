/**
 * oscP5parsing by andreas schlegel
 * example shows how to parse incoming osc messages "by hand".
 * it is recommended to take a look at oscP5plug for an
 * alternative and more convenient way to parse messages.
 * oscP5 website at http://www.sojamo.de/oscP5
 */

import oscP5.*;
import netP5.*;

import spout.*;

Spout spout;

OscP5 oscP5;
NetAddress myRemoteLocation;

float v0;
float v1;
float v2;
float v3;
float v4;

void setup() {
  size(400,400,P2D);
  frameRate(25);
  /* start oscP5, listening for incoming messages at port 12000 */
  oscP5 = new OscP5(this,8000);
  spout = new Spout(this);
    spout.createSender("Spout Processing");
}

void draw() {
  background(0);
  noStroke();
  fill(v1);
  rect(0,0,width, height/4);
  fill(v2);
  rect(0,height/4,width, height/4);
  fill(v3);
  rect(0,height/2,width, height/4);
  fill(v4);
  rect(0,3*height/4,width, height/4);
  spout.sendTexture();
}





void oscEvent(OscMessage theOscMessage) {
  /* check if theOscMessage has the address pattern we are looking for. */
  
  if(theOscMessage.checkAddrPattern("/medias/Solid_Color/HSV/Value")==true) {
    /* check if the typetag is the right one. */
    if(theOscMessage.checkTypetag("fffff")) {
      /* parse theOscMessage and extract the values from the osc message arguments. */
       v0 = theOscMessage.get(0).floatValue();
       v1 = theOscMessage.get(1).floatValue();
       v2 = theOscMessage.get(2).floatValue();  
       v3 = theOscMessage.get(3).floatValue();  
       v4 = theOscMessage.get(4).floatValue();  
      print("Recibido:");
      println(v1);
      println(v2);
      println(v3);
      println(v4);
      return;
    }  
  } 
  println("### received an osc message. with address pattern "+theOscMessage.addrPattern());
}
