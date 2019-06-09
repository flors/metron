class aguja {
  float rot;
  float vel;
  float suma;
  float rad = 5;
  float r_w= 2;
  float r_h= 80;
  float col= 50;
  boolean toca = false;
  float red=1;

  aguja() {
  }



  void palo(float x, float y, float rot) {

    //if (rot <= 3*PI/4 || rot >=5*PI/4) {
    //  suma *=-1;
    //  toca=true;
    //}
    //rot+= suma*vel;

    pushMatrix();
    translate(x, y-10);
    fill(255);

    //  text(i, 0, 0);

    ellipse(0, 0, rad, rad);
    rotate(radians(135+rot));
    rectMode(CENTER);
    rect(0, r_h/2, r_w, r_h);
    popMatrix();
  }
  
  // Que hace en lado derecho
  
  void Ldir (float x, float y, float ang) {
    pushMatrix();
    translate(x+65, y-77);
    if (ang>85) {

      fill(0,0); // Color tira LEDS
    } else {
      fill(0, 0);
    }
    rectMode(CORNER);
    rotate(radians(45));
    rect(0, 0, 10, 105);
    popMatrix();
  }

// Que hace cuando toca lado izquierdo

  void Lizq (float x, float y, float ang) {
    pushMatrix();
    translate(x-73, y-70);
    if (ang<5) {
      fill(0,0); // Color tira LEDS
    } else {
      fill(0, 0);
    }
    rectMode(CORNER);
    rotate(radians(-45));
    rect(0, 0, 10, 105);
    popMatrix();
  }

  void cuadrado(float x, float y, float m) {
    pushMatrix();
    translate(x, y);
    rectMode(CORNER);
    rotate(radians(45));



    if (m>40 && m<50) {
      fill(10); // COLOR CUANDO ESTA EN MEDIO
    } else {
      fill(10);
    }

    rect(-100, -100, 90, 90);
    popMatrix();
  }
}
