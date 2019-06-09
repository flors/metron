import oscP5.*;
import netP5.*;

OscP5 oscP5;
NetAddress myRemoteLocation;


PVector[] pos = new PVector[39];



aguja[] a = new aguja[39];
int count= 0;
float entre = 150;
float y_offset=70;
float vel=2;
float[] rot = new float [39];


void setup() {
  size(1220, 610);
  oscP5 = new OscP5(this, 8020);
  for (int i=0; i<39; i++) {
    pos[i] = new PVector();
    a[i] = new aguja();
  }
}


void draw() {
  background(0);
  noStroke();





    float espacio = entre*0;
    a[0].cuadrado(entre/2+pos[0].x+espacio, entre+y_offset+ pos[0].y, rot[1]);
    a[0].Lizq(entre/2+pos[0].x+espacio, entre+y_offset+ pos[0].y, rot[1]);
    a[0].Ldir(entre/2+pos[0].x+espacio, entre+y_offset+ pos[0].y, rot[1]);
    a[0].palo(entre/2+pos[0].x+espacio, entre+y_offset+ pos[0].y, rot[1]);

    espacio = entre*1;
    a[1].cuadrado(entre/2+pos[1].x+espacio, entre+y_offset+ pos[1].y, rot[6]);
    a[1].Lizq(entre/2+pos[1].x+espacio, entre+y_offset+ pos[1].y, rot[6]);
    a[1].Ldir(entre/2+pos[1].x+espacio, entre+y_offset+ pos[1].y, rot[6]);
    a[1].palo(entre/2+pos[1].x+espacio, entre+y_offset+ pos[1].y, rot[6]);
    
    espacio = entre*2;
    a[2].cuadrado(entre/2+pos[2].x+espacio, entre+y_offset+ pos[2].y, rot[11]);
    a[2].Lizq(entre/2+pos[2].x+espacio, entre+y_offset+ pos[2].y, rot[11]);
    a[2].Ldir(entre/2+pos[2].x+espacio, entre+y_offset+ pos[2].y, rot[11]);
    a[2].palo(entre/2+pos[2].x+espacio, entre+y_offset+ pos[2].y, rot[11]);
    
    espacio = entre*3;
    a[3].cuadrado(entre/2+pos[3].x+espacio, entre+y_offset+ pos[3].y, rot[16]);
    a[3].Lizq(entre/2+pos[3].x+espacio, entre+y_offset+ pos[3].y, rot[16]);
    a[3].Ldir(entre/2+pos[3].x+espacio, entre+y_offset+ pos[3].y, rot[16]);
    a[3].palo(entre/2+pos[3].x+espacio, entre+y_offset+ pos[3].y, rot[16]);
    
    espacio = entre*4;
    a[4].cuadrado(entre/2+pos[4].x+espacio, entre+y_offset+ pos[4].y, rot[21]);
    a[4].Lizq(entre/2+pos[4].x+espacio, entre+y_offset+ pos[4].y, rot[21]);
    a[4].Ldir(entre/2+pos[4].x+espacio, entre+y_offset+ pos[4].y, rot[21]);
    a[4].palo(entre/2+pos[4].x+espacio, entre+y_offset+ pos[4].y, rot[21]);
    
    espacio = entre*5;
    a[5].cuadrado(entre/2+pos[5].x+espacio, entre+y_offset+ pos[5].y, rot[26]);
    a[5].Lizq(entre/2+pos[5].x+espacio, entre+y_offset+ pos[5].y, rot[26]);
    a[5].Ldir(entre/2+pos[5].x+espacio, entre+y_offset+ pos[5].y, rot[26]);
    a[5].palo(entre/2+pos[5].x+espacio, entre+y_offset+ pos[5].y, rot[26]);
    
    espacio = entre*6;
    a[6].cuadrado(entre/2+pos[6].x+espacio, entre+y_offset+ pos[6].y, rot[31]);
    a[6].Lizq(entre/2+pos[6].x+espacio, entre+y_offset+ pos[6].y, rot[31]);
    a[6].Ldir(entre/2+pos[6].x+espacio, entre+y_offset+ pos[6].y, rot[31]);
    a[6].palo(entre/2+pos[6].x+espacio, entre+y_offset+ pos[6].y, rot[31]);
    
    espacio = entre*7;
    a[7].cuadrado(entre/2+pos[7].x+espacio, entre+y_offset+ pos[7].y, rot[36]);
    a[7].Lizq(entre/2+pos[7].x+espacio, entre+y_offset+ pos[7].y, rot[36]);
    a[7].Ldir(entre/2+pos[7].x+espacio, entre+y_offset+ pos[7].y, rot[36]);
    a[7].palo(entre/2+pos[7].x+espacio, entre+y_offset+ pos[7].y, rot[36]);
    
    espacio = entre*0;
    a[8].cuadrado(entre+pos[8].x+espacio, entre*1.5+y_offset+ pos[8].y, rot[4]);
    a[8].Lizq(entre+pos[8].x+espacio, entre*1.5+y_offset+ pos[8].y, rot[4]);
    a[8].Ldir(entre+pos[8].x+espacio, entre*1.5+y_offset+ pos[8].y, rot[4]);
    a[8].palo(entre+pos[8].x+espacio, entre*1.5+y_offset+ pos[8].y, rot[4]);
    
    espacio = entre*1;
    a[9].cuadrado(entre+pos[9].x+espacio, entre*1.5+y_offset+ pos[9].y, rot[9]);
    a[9].Lizq(entre+pos[9].x+espacio, entre*1.5+y_offset+ pos[9].y, rot[9]);
    a[9].Ldir(entre+pos[9].x+espacio, entre*1.5+y_offset+ pos[9].y, rot[9]);
    a[9].palo(entre+pos[9].x+espacio, entre*1.5+y_offset+ pos[9].y, rot[9]);
    
    espacio = entre*2;
    a[10].cuadrado(entre+pos[10].x+espacio, entre*1.5+y_offset+ pos[10].y, rot[14]);
    a[10].Lizq(entre+pos[10].x+espacio, entre*1.5+y_offset+ pos[10].y, rot[14]);
    a[10].Ldir(entre+pos[10].x+espacio, entre*1.5+y_offset+ pos[10].y, rot[14]);
    a[10].palo(entre+pos[10].x+espacio, entre*1.5+y_offset+ pos[10].y, rot[14]);
    
    espacio = entre*3;
    a[11].cuadrado(entre+pos[11].x+espacio, entre*1.5+y_offset+ pos[11].y, rot[19]);
    a[11].Lizq(entre+pos[11].x+espacio, entre*1.5+y_offset+ pos[11].y, rot[19]);
    a[11].Ldir(entre+pos[11].x+espacio, entre*1.5+y_offset+ pos[11].y, rot[19]);
    a[11].palo(entre+pos[11].x+espacio, entre*1.5+y_offset+ pos[11].y, rot[19]);
    
    espacio = entre*4;
    a[12].cuadrado(entre+pos[12].x+espacio, entre*1.5+y_offset+ pos[12].y, rot[24]);
    a[12].Lizq(entre+pos[12].x+espacio, entre*1.5+y_offset+ pos[12].y, rot[24]);
    a[12].Ldir(entre+pos[12].x+espacio, entre*1.5+y_offset+ pos[12].y, rot[24]);
    a[12].palo(entre+pos[12].x+espacio, entre*1.5+y_offset+ pos[12].y, rot[24]);
    
    espacio = entre*5;
    a[13].cuadrado(entre+pos[13].x+espacio, entre*1.5+y_offset+ pos[13].y, rot[29]);
    a[13].Lizq(entre+pos[13].x+espacio, entre*1.5+y_offset+ pos[13].y, rot[29]);
    a[13].Ldir(entre+pos[13].x+espacio, entre*1.5+y_offset+ pos[13].y, rot[29]);
    a[13].palo(entre+pos[13].x+espacio, entre*1.5+y_offset+ pos[13].y, rot[29]);
    
    espacio = entre*6;
    a[14].cuadrado(entre+pos[14].x+espacio, entre*1.5+y_offset+ pos[14].y, rot[34]);
    a[14].Lizq(entre+pos[14].x+espacio, entre*1.5+y_offset+ pos[14].y, rot[34]);
    a[14].Ldir(entre+pos[14].x+espacio, entre*1.5+y_offset+ pos[14].y, rot[34]);
    a[14].palo(entre+pos[14].x+espacio, entre*1.5+y_offset+ pos[14].y, rot[34]);
    
    //-------------
    
    espacio = entre*0;
    a[15].cuadrado(entre/2+pos[15].x+espacio, entre*2+y_offset+ pos[15].y, rot[2]);
    a[15].Lizq(entre/2+pos[15].x+espacio, entre*2+y_offset+ pos[15].y, rot[2]);
    a[15].Ldir(entre/2+pos[15].x+espacio, entre*2+y_offset+ pos[15].y, rot[2]);
    a[15].palo(entre/2+pos[15].x+espacio, entre*2+y_offset+ pos[15].y, rot[2]);

    espacio = entre*1;
    a[16].cuadrado(entre/2+pos[16].x+espacio, entre*2+y_offset+ pos[16].y, rot[7]);
    a[16].Lizq(entre/2+pos[16].x+espacio, entre*2+y_offset+ pos[16].y, rot[7]);
    a[16].Ldir(entre/2+pos[16].x+espacio, entre*2+y_offset+ pos[16].y, rot[7]);
    a[16].palo(entre/2+pos[16].x+espacio, entre*2+y_offset+ pos[16].y, rot[7]);
    
    espacio = entre*2;
    a[17].cuadrado(entre/2+pos[17].x+espacio, entre*2+y_offset+ pos[17].y, rot[12]);
    a[17].Lizq(entre/2+pos[17].x+espacio, entre*2+y_offset+ pos[17].y, rot[12]);
    a[17].Ldir(entre/2+pos[17].x+espacio, entre*2+y_offset+ pos[17].y, rot[12]);
    a[17].palo(entre/2+pos[17].x+espacio, entre*2+y_offset+ pos[17].y, rot[12]);
    
    espacio = entre*3;
    a[18].cuadrado(entre/2+pos[18].x+espacio, entre*2+y_offset+ pos[18].y, rot[17]);
    a[18].Lizq(entre/2+pos[18].x+espacio, entre*2+y_offset+ pos[18].y, rot[17]);
    a[18].Ldir(entre/2+pos[18].x+espacio, entre*2+y_offset+ pos[18].y, rot[17]);
    a[18].palo(entre/2+pos[18].x+espacio, entre*2+y_offset+ pos[18].y, rot[17]);
    
    espacio = entre*4;
    a[19].cuadrado(entre/2+pos[19].x+espacio, entre*2+y_offset+ pos[19].y, rot[22]);
    a[19].Lizq(entre/2+pos[19].x+espacio, entre*2+y_offset+ pos[19].y, rot[22]);
    a[19].Ldir(entre/2+pos[19].x+espacio, entre*2+y_offset+ pos[19].y, rot[22]);
    a[19].palo(entre/2+pos[19].x+espacio, entre*2+y_offset+ pos[19].y, rot[22]);
    
    espacio = entre*5;
    a[20].cuadrado(entre/2+pos[20].x+espacio, entre*2+y_offset+ pos[20].y, rot[27]);
    a[20].Lizq(entre/2+pos[20].x+espacio, entre*2+y_offset+ pos[20].y, rot[27]);
    a[20].Ldir(entre/2+pos[20].x+espacio, entre*2+y_offset+ pos[20].y, rot[27]);
    a[20].palo(entre/2+pos[20].x+espacio, entre*2+y_offset+ pos[20].y, rot[27]);
    
    espacio = entre*6;
    a[21].cuadrado(entre/2+pos[21].x+espacio, entre*2+y_offset+ pos[21].y, rot[32]);
    a[21].Lizq(entre/2+pos[21].x+espacio, entre*2+y_offset+ pos[21].y, rot[32]);
    a[21].Ldir(entre/2+pos[21].x+espacio, entre*2+y_offset+ pos[21].y, rot[32]);
    a[21].palo(entre/2+pos[21].x+espacio, entre*2+y_offset+ pos[21].y, rot[32]);
    
    espacio = entre*7;
    a[22].cuadrado(entre/2+pos[22].x+espacio, entre*2+y_offset+ pos[22].y, rot[37]);
    a[22].Lizq(entre/2+pos[22].x+espacio, entre*2+y_offset+ pos[22].y, rot[37]);
    a[22].Ldir(entre/2+pos[22].x+espacio, entre*2+y_offset+ pos[22].y, rot[37]);
    a[22].palo(entre/2+pos[22].x+espacio, entre*2+y_offset+ pos[22].y, rot[37]);
    
    espacio = entre*0;
    a[23].cuadrado(entre+pos[23].x+espacio, entre*2.5+y_offset+ pos[23].y, rot[5]);
    a[23].Lizq(entre+pos[23].x+espacio, entre*2.5+y_offset+ pos[23].y, rot[5]);
    a[23].Ldir(entre+pos[23].x+espacio, entre*2.5+y_offset+ pos[23].y, rot[5]);
    a[23].palo(entre+pos[23].x+espacio, entre*2.5+y_offset+ pos[23].y, rot[5]);
    
    espacio = entre*1;
    a[24].cuadrado(entre+pos[24].x+espacio, entre*2.5+y_offset+ pos[24].y, rot[10]);
    a[24].Lizq(entre+pos[24].x+espacio, entre*2.5+y_offset+ pos[24].y, rot[10]);
    a[24].Ldir(entre+pos[24].x+espacio, entre*2.5+y_offset+ pos[24].y, rot[10]);
    a[24].palo(entre+pos[24].x+espacio, entre*2.5+y_offset+ pos[24].y, rot[10]);
    
    espacio = entre*2;
    a[25].cuadrado(entre+pos[25].x+espacio, entre*2.5+y_offset+ pos[25].y, rot[15]);
    a[25].Lizq(entre+pos[25].x+espacio, entre*2.5+y_offset+ pos[25].y, rot[15]);
    a[25].Ldir(entre+pos[25].x+espacio, entre*2.5+y_offset+ pos[25].y, rot[15]);
    a[25].palo(entre+pos[25].x+espacio, entre*2.5+y_offset+ pos[25].y, rot[15]);
    
    espacio = entre*3;
    a[26].cuadrado(entre+pos[26].x+espacio, entre*2.5+y_offset+ pos[26].y, rot[20]);
    a[26].Lizq(entre+pos[26].x+espacio, entre*2.5+y_offset+ pos[26].y, rot[20]);
    a[26].Ldir(entre+pos[26].x+espacio, entre*2.5+y_offset+ pos[26].y, rot[20]);
    a[26].palo(entre+pos[26].x+espacio, entre*2.5+y_offset+ pos[26].y, rot[20]);
    
    espacio = entre*4;
    a[27].cuadrado(entre+pos[27].x+espacio, entre*2.5+y_offset+ pos[27].y, rot[25]);
    a[27].Lizq(entre+pos[27].x+espacio, entre*2.5+y_offset+ pos[27].y, rot[25]);
    a[27].Ldir(entre+pos[27].x+espacio, entre*2.5+y_offset+ pos[27].y, rot[25]);
    a[27].palo(entre+pos[27].x+espacio, entre*2.5+y_offset+ pos[27].y, rot[25]);
    
    espacio = entre*5;
    a[28].cuadrado(entre+pos[28].x+espacio, entre*2.5+y_offset+ pos[28].y, rot[30]);
    a[28].Lizq(entre+pos[28].x+espacio, entre*2.5+y_offset+ pos[28].y, rot[30]);
    a[28].Ldir(entre+pos[28].x+espacio, entre*2.5+y_offset+ pos[28].y, rot[30]);
    a[28].palo(entre+pos[28].x+espacio, entre*2.5+y_offset+ pos[28].y, rot[30]);
    
    espacio = entre*6;
    a[29].cuadrado(entre+pos[29].x+espacio, entre*2.5+y_offset+ pos[29].y, rot[35]);
    a[29].Lizq(entre+pos[29].x+espacio, entre*2.5+y_offset+ pos[29].y, rot[35]);
    a[29].Ldir(entre+pos[29].x+espacio, entre*2.5+y_offset+ pos[29].y, rot[35]);
    a[29].palo(entre+pos[29].x+espacio, entre*2.5+y_offset+ pos[29].y, rot[35]);
    
    //-------------------
    
       espacio = entre*0;
    a[30].cuadrado(entre/2+pos[30].x+espacio, entre*3+y_offset+ pos[30].y, rot[3]);
    a[30].Lizq(entre/2+pos[30].x+espacio, entre*3+y_offset+ pos[30].y, rot[3]);
    a[30].Ldir(entre/2+pos[30].x+espacio, entre*3+y_offset+ pos[30].y, rot[3]);
    a[30].palo(entre/2+pos[30].x+espacio, entre*3+y_offset+ pos[30].y, rot[3]);

    espacio = entre*1;
    a[31].cuadrado(entre/2+pos[16].x+espacio, entre*3+y_offset+ pos[16].y, rot[8]);
    a[31].Lizq(entre/2+pos[16].x+espacio, entre*3+y_offset+ pos[16].y, rot[8]);
    a[31].Ldir(entre/2+pos[16].x+espacio, entre*3+y_offset+ pos[16].y, rot[8]);
    a[31].palo(entre/2+pos[16].x+espacio, entre*3+y_offset+ pos[16].y, rot[8]);
    
    espacio = entre*2;
    a[32].cuadrado(entre/2+pos[17].x+espacio, entre*3+y_offset+ pos[17].y, rot[13]);
    a[32].Lizq(entre/2+pos[17].x+espacio, entre*3+y_offset+ pos[17].y, rot[13]);
    a[32].Ldir(entre/2+pos[17].x+espacio, entre*3+y_offset+ pos[17].y, rot[13]);
    a[32].palo(entre/2+pos[17].x+espacio, entre*3+y_offset+ pos[17].y, rot[13]);
    
    espacio = entre*3;
    a[33].cuadrado(entre/2+pos[18].x+espacio, entre*3+y_offset+ pos[18].y, rot[18]);
    a[33].Lizq(entre/2+pos[18].x+espacio, entre*3+y_offset+ pos[18].y, rot[18]);
    a[33].Ldir(entre/2+pos[18].x+espacio, entre*3+y_offset+ pos[18].y, rot[18]);
    a[33].palo(entre/2+pos[18].x+espacio, entre*3+y_offset+ pos[18].y, rot[18]);
    
    espacio = entre*4;
    a[34].cuadrado(entre/2+pos[19].x+espacio, entre*3+y_offset+ pos[19].y, rot[23]);
    a[34].Lizq(entre/2+pos[19].x+espacio, entre*3+y_offset+ pos[19].y, rot[23]);
    a[34].Ldir(entre/2+pos[19].x+espacio, entre*3+y_offset+ pos[19].y, rot[23]);
    a[34].palo(entre/2+pos[19].x+espacio, entre*3+y_offset+ pos[19].y, rot[23]);
    
    espacio = entre*5;
    a[35].cuadrado(entre/2+pos[35].x+espacio, entre*3+y_offset+ pos[20].y, rot[28]);
    a[35].Lizq(entre/2+pos[35].x+espacio, entre*3+y_offset+ pos[20].y, rot[28]);
    a[35].Ldir(entre/2+pos[35].x+espacio, entre*3+y_offset+ pos[20].y, rot[28]);
    a[35].palo(entre/2+pos[35].x+espacio, entre*3+y_offset+ pos[20].y, rot[28]);
    
    espacio = entre*6;
    a[36].cuadrado(entre/2+pos[36].x+espacio, entre*3+y_offset+ pos[36].y, rot[33]);
    a[36].Lizq(entre/2+pos[36].x+espacio, entre*3+y_offset+ pos[38].y, rot[33]);
    a[36].Ldir(entre/2+pos[36].x+espacio, entre*3+y_offset+ pos[38].y, rot[33]);
    a[36].palo(entre/2+pos[36].x+espacio, entre*3+y_offset+ pos[21].y, rot[33]);
    
    espacio = entre*7;
    a[37].cuadrado(entre/2+pos[37].x+espacio, entre*3+y_offset+ pos[37].y, rot[38]);
    a[37].Lizq(entre/2+pos[37].x+espacio, entre*3+y_offset+ pos[37].y, rot[38]);
    a[37].Ldir(entre/2+pos[37].x+espacio, entre*3+y_offset+ pos[37].y, rot[38]);
    a[37].palo(entre/2+pos[37].x+espacio, entre*3+y_offset+ pos[37].y, rot[38]);






  //for (int i=8; i<15; i++) {
  //  float espacio = entre*(i-8);
  //  a[i].cuadrado(entre+pos[i].x+espacio, entre*1.5+y_offset+ pos[i].y);
  //  a[i].Lizq(entre+pos[i].x+espacio, entre*1.5+y_offset+ pos[i].y, rot[i+1]);
  //  a[i].Ldir(entre+pos[i].x+espacio, entre*1.5+y_offset+ pos[i].y, rot[i+1]);
  //  a[i].palo(entre+pos[i].x+espacio, entre*1.5+y_offset+ pos[i].y, rot[i+1]);
  //}
  //for (int i=15; i<23; i++) {
  //  float espacio = entre*(i-15);
  //  a[i].cuadrado(entre/2+pos[i].x+espacio, entre*2+y_offset+ pos[i].y);
  //  a[i].Lizq(entre/2+pos[i].x+espacio, entre*2+y_offset+ pos[i].y, rot[i+1]);
  //  a[i].Ldir(entre/2+pos[i].x+espacio, entre*2+y_offset+ pos[i].y, rot[i+1]);
  //  a[i].palo(entre/2+pos[i].x+espacio, entre*2+y_offset+ pos[i].y, rot[i+1]);
  //}
  //for (int i=23; i<30; i++) {
  //  float espacio = entre*(i-23);
  //  a[i].cuadrado(entre+pos[i].x+espacio, entre*2.5+y_offset+ pos[i].y);
  //  a[i].Lizq(entre+pos[i].x+espacio, entre*2.5+y_offset+ pos[i].y, rot[i+1]);
  //  a[i].Ldir(entre+pos[i].x+espacio, entre*2.5+y_offset+ pos[i].y, rot[i+1]);
  //  a[i].palo(entre+pos[i].x+espacio, entre*2.5+y_offset+ pos[i].y, rot[i+1]);
  //}
  //for (int i=30; i<38; i++) {
  //  float espacio = entre*(i-30);
  //  a[i].cuadrado(entre/2+pos[i].x+espacio, entre*3+y_offset+ pos[i].y);
  //  a[i].Lizq(entre/2+pos[i].x+espacio, entre*3+y_offset+ pos[i].y, rot[i+1]);
  //  a[i].Ldir(entre/2+pos[i].x+espacio, entre*3+y_offset+ pos[i].y, rot[i+1]);
  //  a[i].palo(entre/2+pos[i].x+espacio, entre*3+y_offset+ pos[i].y, rot[i+1]);
  //}
}

void oscEvent(OscMessage theOscMessage) {
  /* print the address pattern and the typetag of the received OscMessage */
  if (theOscMessage.checkAddrPattern("/motores")==true) {
    /* check if the typetag is the right one. */
    if (theOscMessage.checkTypetag("fffffffffffffffffffffffffffffffffffffff")) {
      /* parse theOscMessage and extract the values from the osc message arguments. */
      for (int i=0; i<39; i++) {
        rot[i] = theOscMessage.get(i).floatValue();
        println(rot[0]);
      }
    }
  }
  print("### received an osc message.");
  print(" addrpattern: "+theOscMessage.addrPattern());
  println(" typetag: "+theOscMessage.typetag());
}
