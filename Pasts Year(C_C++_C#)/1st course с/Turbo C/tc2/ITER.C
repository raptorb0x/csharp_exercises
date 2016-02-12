#include<stdio.h>
#include<math.h>
#include<alloc.h>
Zeidel(int m, float **a, float *b, float *x, float eps)
{
int i, j;
float y, delta;
   for(i=0; i<m; i++)
  {
       y=a[i][i];
      b[i]/=y;
      for(j=0; j<m; j++)
           if(i!=j)   a[i][j]/=y;
      a[i][i]=0;
}
for(i=0; i<m; i++)
      x[i]=b[i];
do{delta=0;
   for(i=0; i<m; i++){
       y=b[i];
       for(j=0; j<m; j++)
             y+=a[i][j]*x[j];
       delta+=fabs(y-x[i]);
       x[i]=y;
  }
}while(delta>eps);
}
main()
{
extern Zeidel(int, float **, float *, float *, float);
float **a, *b, *x, eps; int i, j, k, m;
 printf("zadaite dannbe");
scanf("%d%f", &m, &eps);   a=(float **)malloc(m*sizeof(float *));
  b=(float *)malloc(m*sizeof(float));
  x=(float *)malloc(m*sizeof(float));
  for(i=0; i<m; i++)
       a[i]=(float *)malloc(m*sizeof(float));
  printf(У\n «адайте коэффициенты: \nФ);
  for(i=0; i<m; i++)
     for(j=0; j<m; j++)
         scanf(У%fФ, &a[i][j]);
  printf(У\n«адайте свободные члены\nФ);
 for(i=0; i<m; i++)
    scanf(У%fФ, &b[i]);
  Zeidel(m, a, b, x, eps);
  puts(У Ф);
  for(i=0; i<m; i++)
     printf(Уx(%d)=%3.1fФ, i+1, x[i]);
}

