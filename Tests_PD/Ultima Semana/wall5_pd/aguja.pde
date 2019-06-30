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
    if (t_apaga == 1){
    rotate(radians(135+rot));
    } else {
    rotate(radians(180));
    }
    rectMode(CENTER);
    rect(0, r_h/2, r_w, r_h);
    popMatrix();
  }
  void Ldir (float x, float y, float ang) {
    pushMatrix();
    translate(x+65, y-77);
    fill(0, 0);
    if (t_laterales ==1) {
      if (ang>85) {

        fill(255);
      } else {
        fill(0, 0);
      }
    }
    rectMode(CORNER);
    rotate(radians(45));
    rect(0, 0, 10, 105);
    popMatrix();
  }

  void Lizq (float x, float y, float ang) {
    pushMatrix();
    translate(x-73, y-70);
    fill(0, 0);
    if (t_laterales ==1) {
      if (ang<5) {
        fill(255);
      } else {
        fill(0, 0);
      }
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
    fill(100);

    if (t_interior ==1) {
      if (m>40 && m<50) {
        fill(130);
      } else {
        fill(100);
      }
    }
    rect(-100, -100, 90, 90);
    popMatrix();
  }
}

