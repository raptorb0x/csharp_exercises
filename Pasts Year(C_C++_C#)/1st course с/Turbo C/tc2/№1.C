#include<stdio.h>
#include<graphics.h>
#include<math.h>
main()
 {
int gr1=0, gr2,
    x=320,  y=240,
    r1=50,  r2=20;
float i=0.0;
initgraph(&gr1,&gr2,"");
setcolor(14);
circle(x,y,r1);
while(!kbhit())
  {

      setcolor(14);
      circle(x+(r1+r2)*cos(i),y+(r1+r2)*sin(i),r2-2);
      sleep(0.1);

      setcolor(0);
      circle(x+(r1+r2)*cos(i),y+(r1+r2)*sin(i),r2-2);
      i+=0.1;

		}
}
