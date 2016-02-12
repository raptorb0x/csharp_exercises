#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
#include<alloc.h>
#include<math.h>
#include<graphics.h>
int m;
char dan[6][40]={"Credniy reiting vsech oteley", "Oteli s 5*", "Oteli s odinakovim rasstoianiem ot moria", "Spisok", "Diagramma", "Exit"};
struct s{
char nusv[40];
char kur[15];
int star;
int sea;
unsigned center;
int air;
float reiting; } *a;

struct sp{
char txt[40];

struct sp *sled;
};

struct sp *stud;

main()
{
int i, j, v;
FILE *in;
if((in=fopen("oteli.dan", "r"))==NULL)
{ printf("\no file");
exit(1); }
fscanf(in, "%d", &m);
a=(struct s*)malloc(m*sizeof(struct s));
for(i=0; i<m; i++)
fscanf(in, "%s%s%d%d%u%d%f", a[i].nusv, a[i].kur, &a[i].star, &a[i].sea, &a[i].center, &a[i].air, &a[i].reiting);
for(i=0; i<m; i++)
printf("%s%s%d%d%u%d%f", a[i].nusv, a[i].kur, &a[i].star, &a[i].sea, &a[i].center, &a[i].air, &a[i].reiting);

while(1) {
window (1, 1, 80, 25);
textattr(7);
clrscr();
window(15,9,70,15);
textattr(16*3+3);
clrscr();
textattr(0);
for(i=0; i<6; i++) {
gotoxy (3, i+1);
cprintf("%s", dan[i]); }
v=menu(6);
switch(v) {
case1: f1(); break;
case2: f2(); break;
case3: f3(); break;
case4: spis(); break;
case5: DIAG(); break;
case6: case27:
window (1,1,80,25);
textattr (7);
clrscr();
exit(1);
}
 }
   }



menu (int n)
{
int y=1;
char c;
gotoxy (3,1);
textattr (16*1+14);

cprintf ("%s", dan[0]);
do{
c=getch();
textattr (16*3+0);
gotoxy (3,y);
cprintf ("%s", dan[y-1]);
switch (c) {
case 'P': y++; break;
case 'H': y--; break;
case '\r': return y;
}
if (y>n) y=1;
if (y<1) y=n;
textattr (30);
gotoxy (3,y);
cprintf ("%s", dan[y-1]);
}
while (c!=27);
return c;
}


f1() {
float sum=0,i;
window(1,1,80,25);
gotoxy(10,20);
for(i=0;i<m;i++)
sum+=a[i].reiting;
printf("%f", sum/m);
getch();
}


f2() {
int i;
window(1,1,80,25);
gotoxy(10,20);
for(i=0;i<m;i++)
if(a[i].star==5)
printf("%s\n",a[i].nusv);
getch();
}


f3()
{
int i, j;
textattr(7);
window (1,1,80,25);
clrscr();
for(i=0; i<m; i++)
  for(j=0; j<m; j++)
    if((a[i].sea==a[j].sea)&&(i!=j))
    {
     gotoxy(10,10);
     printf("\n Takie oteli est', "
	 "Naprimer,%s.", a[i].nusv, a[i].sea, a[j].nusv); }
     getch();

  }


 vst()
 {
  struct sp *nov,*nt,*s=0;
     for(nt=s; nt!=0 && strcmp(nt->txt.b)<0; z=nt,nt=nt->sled);
   nov=(struct sp *)malloc(sizeof(struct sp));
     strcpy(nov->txt,b);
      nov->sled=nt;
       if(!z) *s=nov;
     if(z) z->sled=nov;

}
spis()
{
struct sp *nt;
char nusv[20];
int i;
stud=0;
for(i=0; i<m; i++)
  vst(a[i].nusv);
 window(1,1,80,25);
 textattr(7);
 clrscr();
for(nt=stud; nt; nt=nt->sled)
 printf("%s\n", nt->txt);
 getch();
return i;
}

DIAG()
 {
  int gr1=0,gr2;
   char str[15];
    int i,m[8]={0},v=36,k[8]={0},j=0,z=0;
  float x,y,x1;
struct sp *nt;
 for(nt=stud;nt!=0;nt=nt->sled)
   {  for(i=0;i<m;i++)
       if(strcmp(a[i].nusv,nt->txt)==0)
          {m[j]+=v; k[j]+=10;}
      j++;
    }

 initgraph(&gr1,&gr2,"");
for(i=0;i<8;i++)
{
 x1=M_PI*(m[i]+z)/360;
   x=170+120*cos(x1);
     y=160-120*sin(x1);

setfillstyle(i+2,2);
 pieslice(170,160,z,m[i],120);
bar(350,50+40*i,400,90+40*i);
 z=m[i];
sprintf(str,"%d",k[i]);
 outtextxy(x,y,str);
 sprintf(str,"%s",nt->txt);
outtextxy(410,75+40*i,str);

}

 getch();
closegraph(); 
}