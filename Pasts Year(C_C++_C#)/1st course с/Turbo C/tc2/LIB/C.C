

#include <stdio.h>
#include <alloc.h>
unsigned long int i,j;
void matric (int n, int m, double *prmatr, double c)
{
	for (i=0; i<n; i++ )

 {
  for (j=0; j<m; j++)
	 {
	*(prmatr+i*n+j)=*(prmatr+i*n+j)*c;
	printf("     %9.9e", *(prmatr+i*n+j));

 }
 printf("\n");
}
scanf("%lf");
}
main ()
{
unsigned long int n, m;

	double c, *prmatr;
	printf("Enter constant:");
	scanf("%lf", &c);
	printf("\n");
	printf("Enter size of string:");
	scanf("%ld", &n);
	printf("Enter size of colons:");
	scanf("%ld", &m);
	prmatr=(double *)malloc(n*m*sizeof(double));
	if (prmatr!=NULL)
	{
	 for (i=0; i<n; i++ )
 {
  for (j=0; j<m; j++)
	 {
	printf("Enter matrix's element:",i+1,j+1);
	scanf("%lf", &*(prmatr+i*n+j));
}
}
}
else
{
printf("STOP, too big point");
return;
}
matric (n, m, prmatr, c);
}
