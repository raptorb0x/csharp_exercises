#include<stdio.h>

main()
{
FILE *out;
void trans(int **a,int *b,int *c,int n,int m );
int k=0,j,i,**a,n,m,*b,*c;
clrscr();
out=fopen("ff.dat","r");
fscanf(out,"%d%d",&n,&m);
a=(int **)malloc(n*sizeof(int*));
 for(i=0;i<n;i++)
  a[i]=(int *)malloc(m*sizeof(int));
for (i=0;i<n;i++)
 for (j=0;j<m;j++){
  fscanf (out,"%d",&a[i][j]);
  if(a[i][j]) k++;}
for (i=0;i<n;i++) {
 puts("\n");
 for (j=0;j<m;j++)
  printf("%4d",a[i][j]);};
  puts("");
b=(int *)malloc(k*sizeof(int));
c=(int *)malloc(k*sizeof(int));
trans(a,b,c,n,m);
printf("\nRESULT:\n");
for (i=0;i<k;i++)
 printf("\nElement %d   B ctolbcE  %d\n",b[i],c[i]);


}

void trans(int **a,int *b,int *c,int n,int m){
int i,j,x=0;
for (i=0;i<n;i++)
for (j=0;j<m;j++)
 if (a[i][j])   { b[x]=a[i][j]; c[x]=j; x++;
         }
}