#include <stdio.h>
#include <alloc.h>
#include <math.h>

umnm (int **a,int *b,int m) {
int i,j,k=0;
for (i=0;i<m;i++)
for (j=0;j<m;j++)
a[i][j]=(int)pow((double)b[k++],(double)i+1);
}
main ()
{ int **a,*b,m,i,j;
FILE *in;
clrscr();
in=fopen ("ff.dat","r");
fscanf (in,"%d", &m);
b=(int*)malloc(m*m*sizeof(int));
a=(int**)malloc(m*sizeof(int*));
for (i=0;i<m;i++)
a[i]=(int*)malloc(m*sizeof(int));
for (i=0;i<m*m;i++)
fscanf(in,"%d", &b[i]);
for (i=0;i<m*m;i++)
printf ("%2d", b[i]);
umnm(a,b,m);
for(i=0;i<m;i++){
 puts("");
 for(j=0;j<m;j++)
 printf("%3d",a[i][j]);
 }

 }