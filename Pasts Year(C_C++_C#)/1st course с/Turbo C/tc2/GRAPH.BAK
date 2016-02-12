#include <graphics.h>
#include <alloc.h>
#include <dos.h>
static int first =1;
static const int max = 32767;
static h1,h2,m1,m2,s1,s2,hund1,hund2;
static unsigned seed1,seed2;
void gtime(unsigned *hour,unsigned *minute,unsigned *sec,unsigned *hund)
{
 union REGS inreg,outreg;
 inreg.h.ah=0x2C;
 intdos(&inreg,&outreg);
 *hour=outreg.h.ch;
 *minute=outreg.h.cl;
 *sec=outreg.h.dh;
 *hund=outreg.h.dl;
}
float rand_real( void )
{
unsigned h,m,s,hu,c;
float r;
int index;
if (first)
{

 gtime(&h,&m,&s,&hu);
 seed1=hu+m+2*s;
 seed2=h+s*m+s;
 seed1*=2;
 seed2*=2;
 if (seed1>max) seed1-=max;
 if (seed2>max) seed2-=max;
 first=0;
 for (index=1;index<=30;index++)
  r=rand_real();
 }
 c=seed1+seed2;
 if(c>max) c-=max;
 c*=2;
 if(c>max) c-=max;
 seed1=seed2;
 seed2=c;
 return((float)c/32767.0);
}


int random(int low,int high)
{
 float r,t;
 int c;
 r=(float)high-(float)low+1.0;
 t=r*rand_real();
 c=(int) t ;
 return(low+c);
}
main()
{

int gr1=0,gr2,x,y,e,i,r=20,lx,ly,rx,ry,width,height,dx,dy,xm,ym;
void *buf;
initgraph(&gr1,&gr2,"");
e=graphresult();
if(e!=grOk) printf(grapherrormsg(e));
x=r*5;
y=r*2;
xm=getmaxx();
ym=getmaxy();
ellipse(x,y,0,360,r,(r/3)+2);
ellipse(x,y-4,190,357,r,r/3);
line(x+7,y-6,x+10,y-12);
line(x-7,y-6,x-10,y-12);
circle(x+10,y-12,2);
circle(x-10,y-12,2);
floodfill(x+1,y+4,15);
lx=x-r-1;
ly=y-14;
rx=x+r+1;
ry=y+r/3+3;
width=rx-lx+1;
height=ry-ly+1;
buf=malloc(imagesize(lx,ly,rx,ry));
getimage(lx,ly,rx,ry,buf);
putimage(lx,ly,buf,1);
x=xm/2;
y=ym/2 ;
dx=10;
dy=10;
for(i=0;i<150;i++){
 putpixel(random(0,xm),random(0,ym),15);
 fillellipse(random(0,xm),random(0,ym),1,1);
 };
do
 {
  putimage(x,y,buf,1);
  delay(20000);
  putimage(x,y,buf,1);
target: x=x+dx;
 y=y+dy;
 if((x<0)||(x+width+1>xm)||(y<0)||(y+height+1>ym))
  {
   x=x-dx; y=y-dy;
   dx=1+xm/10-random(0,xm/5);
   dy=1+ym/30-random(0,ym/15);
  goto target;
}

 } while(!kbhit());

}