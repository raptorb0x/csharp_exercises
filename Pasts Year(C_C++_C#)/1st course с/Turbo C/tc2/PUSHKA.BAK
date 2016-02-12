#include <stdio.h>
#include <math.h>
#include <graphics.h>
#include <conio.h>
main() {
int xm,ym,gr1=0,gr2,dx,dy,i=0;
void *buf;
initgraph(&gr1,&gr2,"");
xm=getmaxx();
ym=getmaxy();
circle(xm/2,ym/2,40);
circle(xm/2+60,ym,20);
buf=malloc(sizeof((xm/2)+40,ym-20,(xm/2)+80,ym+20));
getimage((xm/2)+40,ym-20,(xm/2)+80,ym+20,buf);
putimage(xm/2+40,ym-20,buf,1);
do {
i++;
putimage(20,20*sin(i),buf,2);
delay(20000);
putimage(20*cos(i),20*sin(i),buf,2);
}while(!kbhit());

}