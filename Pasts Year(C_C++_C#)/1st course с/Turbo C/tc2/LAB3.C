#include <stdio.h>
main ()
{
FILE *out;
void per (int n,int **a);
int **a,i,j,n;
out=fopen("ff.dat","r");
fscanf(out,"%d",&n);
a=(int **)malloc(n*sizeof(int*));
 for(i=0;i<n;i++)
  a[i]=(int *)malloc(n*sizeof(int));
for (i=0;i<n;i++)
 for (j=0;j<n;j++)
  fscanf (out,"%d",&a[i][j]);
for (i=0;i<n;i++) {
 puts("\n");
 for (j=0;j<n;j++)
  printf("%4d",a[i][j]);};
  puts("");
  per(n,a);
for(i=0;i<n;i++)
 { puts("\n");
 for (j=0;j<n;j++)
  printf("%4d",a[i][j]);
  };
  puts("\n\n\n\n");
}


void per(int n, int **a)
{
int i,j,z;
for (i=0;i<n;i++)
 for (j=i;j<n-1-i;j++)
  {
   z=a[i][j];
   a[i][j]=a[j][n-1-i];
   a[j][n-1-i]=a[n-1-i][n-1-j];
   a[n-1-i][n-1-j]=a[n-1-j][i];
   a[n-1-j][i]=z;
  };
}