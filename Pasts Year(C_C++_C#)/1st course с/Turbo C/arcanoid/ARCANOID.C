#include <stdio.h>
//#include <graphics.h>
//#include <alloc.h>
#include <conio.h>
#include <dos.h>

enum timetipe {begin,end};
static int first =1;
static const int max = 32767;
static h1,h2,m1,m2,s1,s2,hund1,hund2;
static unsigned seed1,seed2;
 /* polu4aem Brem9 */
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
unsigned time(unsigned h,unsigned m,unsigned s,unsigned hu) {
return hu+s*100+m*6000+h*360000; }

void pause(unsigned timer){
unsigned t1,t2,h3,m3,s3,hund3;
gtime(&h3,&m3,&s3,&hund3)  ;
t1= time(h3,m3,s3,hund3)  ;
do { gtime(&h3,&m3,&s3,&hund3) ;
t2=time(h3,m3,s3,hund3); }
while(t2-t1<=timer)  ;
}

void rpttiming(enum timetype p)
{
if(p==begin)
 gtime (&h1,&m1,&s1,&hund1);
 if(p==end)
 { gtime(&h2,&m2,&s2,&hund2);
 if(hund2<hund1)
 {
  hund2+=100;
  s2-=1;
 }
 if(s2<s1)
 {
  s2+=60;
  m2-=1;}
  if(m2<m1)
   {
    m2+=60;
    h2-=1;
   }
 if(h2>h1) h2+=24;
 if (h2-h1){ printf("\n\n%d 4acoB,  %d minut,  %d secund, %d sotbIX\n",h2-h1,m2-m1,s2-s1,hund2-hund1);goto next;}
 if (m2-m1){ printf("\n\n%d minut,  %d secund, %d sotbIX\n",m2-m1,s2-s1,hund2-hund1);goto next;}
 if (s2-s1){ printf("\n\n%d secund, %d sotbIX\n",s2-s1,hund2-hund1);goto next;}
 if (hund2-hund1){printf ("\n\n%d sotbIX\n",hund2-hund1);goto next;} }; next:  ;
 }

/* random bloks*/
void randbloks(int *bx,int *by,int lx,int rx,int vy,int ny,int n,int raz)
{
 int i,j,k;
 loop1:
 for(i=0;i<n;i++)
  { bx[i]=random(lx+1,rx-raz-1);
    by[i]=random(vy+1,ny-100);
  }
  for(i=0;i<n;i++)
   for (j=i+1;j<n;j++)
    if((bx[i]-raz<=bx[j])&&(bx[j]<=bx[i]+raz)&&(by[i]-raz<=by[j])&&(by[j]<=by[i]+raz)) goto loop1;
    }

/*random ot 0.0 do 1.0 */
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
/* random ot low do high*/
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

char keypress,nick[15];
unsigned hour,minute,sec,hud ;
fint gr1=0,gr2,x,y,e,i,j,m=0,k,r=20,lx,px,kol,bdl,razp,py,ny,rx,vy,dx,dy,xm,ym,*bx,*by,p;
FILE *in;
void *buf,*dest,*plat;
begin:
initgraph(&gr1,&gr2,"");
e=graphresult();
if((in=fopen("last.dat","r+"))==NULL)  in=fopen("last.dat","w+");
/*podgotoBka pol9 i ic4islenie peremennbIX*/
kol=15;           /* koli4estBo blokoB*/
razp=30;           /* dlina platformbI  */
bdl=10;            /*razmer Blokov */
bx=(int*)malloc(kol*sizeof(int));
by=(int*)malloc(kol*sizeof(int));
xm=getmaxx();
ym=getmaxy();
lx=xm/3;
rx=lx*2;
vy=ym/5;
ny=vy*4;
e=10;
gotoxy(10,10);
printf("LIFES %2d",e);
gotoxy(10,20);
printf("BLOKS %2d",m);
x=lx+(rx-lx)/2;
y=ny-4;
randbloks(bx,by,lx,rx,vy,ny,kol,bdl);
for(i=0;i<kol;i++)
rectangle(bx[i],by[i],bx[i]+bdl,by[i]+bdl);
fillellipse(x,y,2,2);
buf=malloc(imagesize(x-2,y-2,x+2,y+2));
dest=malloc(imagesize(0,0,bdl,bdl));
getimage(x-2,y-2,x+2,y+2,buf);
putimage(x-2,y-2,buf,1);
getimage(0,0,bdl,bdl,dest);
dy=-1;     /*speed po y*/
dx=1;     /*speed po x*/

y-=3;
x-=3;
/* px,py koordinatbi leB.Berh. ugla; risuem platformu i Bstabl9em ee B bufer*/
px=lx+3;
py=ny-10;
rectangle(px,py,px+razp,py+8);
plat=malloc(imagesize(px,py,px+razp,py+8));
floodfill(px+1,py+1,15);
getimage(px,py,px+razp,py+8,plat);
putimage(px,py,plat,1);
rectangle(lx,vy,rx,ny);
/*rabo4iY cikl*/
rpttiming(begin);
while(e){
putimage(x,y,buf,1);
putimage(px,py,plat,1);
/* root of evil begin*/
delay(5000);
/* root of evil end*/
putimage(x,y,buf,1);
putimage(px,py,plat,1);
loop:   x+=dx;
y+=dy;
/*gtime(&hour,&minute,&sec,&hud);
gotoxy(10,15);
printf("Time is %2u:%2u:%2u",hour,minute,sec); */
/*proBerka na stolknoBenie so stenkoY*/
if((x<lx)||(x+4>rx)) {
x-=dx; y-=dy;
dx=-dx;
goto loop; }
if((y-1<vy)||(y+5>ny)) {
x-=dx;y-=dy;
dy=-dy;
if (y+6>ny) { gotoxy(10,10); printf("LIFES %2d",--e);}
goto loop;
};
/*proberka na stolknoBenie s blokami*/
for (i=0;i<kol;i++)
if ((bx[i]-4<=x)&&(x<=bx[i]+bdl)&&(by[i]-4<=y)&&(y<=by[i]+bdl))
{
if(((x+4==bx[i])||(bx[i]+bdl==x))&&!(y==by[i]+bdl)&&!(y+4==by[i]))   {
x-=dx; y-=dy;
dx=-dx;                           }
else { x-=dx;y-=dy;  dy=-dy; };
putimage(bx[i],by[i],dest,0);
bx[i]=0;
by[i]=0;
gotoxy(10,20);
printf("BLOKS %2d",++m);
goto loop;};
/*proberka na stolknoBenie s paltformoY*/
if((px-4<=x)&&(x<=px+razp)&&(py-5<=y)) {
x-=dx;y-=dy;
if((x+5==px)||(px+razp+1==x)) dx=-dx; else
dy=-dy;   goto loop;                           };
/*random pol9*/
k=0;
for(i=0;i<kol;i++)
  if(bx[i]!=0) k++;
if(k==0){
randbloks(bx,by,lx,rx,vy,ny,kol,bdl);
for(i=0;i<kol;i++){
rectangle(bx[i],by[i],bx[i]+bdl,by[i]+bdl);
} ;
};
/*proberka na nagatie*/
if(kbhit())
{ keypress=getch();
 if((keypress=='p')||(keypress=='P'))
  getch();
 if((keypress=='a')||(keypress=='A'))
  if(lx<=px-7)  px-=7;
   else px=lx+1;
 if((keypress=='d')||(keypress=='D'))
  if(px<=rx-razp-7) px+=7;
   else px=rx-razp-1;
 if((x-razp-1<=px)&&(px<=x+5)&&(y>=py-5)) {
   if ((x-razp-1<=px)&&(px<=x-7))  px=x-razp-1;
    else
    px=x+5;
   }
 if((keypress=='x')||(keypress=='X'))
  e=0;  }
};
rpttiming(end);
printf("%.2f Bloks/sec",(float)m/(time(h2-h1,m2-m1,s2-s1,hund2-hund1)/100));
gotoxy(20,7);
strcpy(nick,'');
printf("Enter your nickname:");
gets(nick);
if(strcmp(nick,'\n')) strcpy(nick,"name");
fprintf(in,"%d  %.2f  %s",m,(float)m/(time(h2-h1,m2-m1,s2-s1,hund2-hund1)/100),nick);
zap:
gotoxy(35,13);
printf("RESTART? (y/n)");
scanf("%s",&keypress);
switch(keypress){
case 'y': {goto begin;}
case 'Y': {goto begin;}
case 'n': {break;}
case 'N': {break;}
default:{ goto zap;  }    } ;
}
