#include <stdio.h>
main()
{
FILE *out;
int l=1;
char ch[30];
out=fopen("s.c","r");
printf("\n%5d",l);
while(l<14) {
fgets(ch,30,out);
 puts(ch);
 printf("\n%5d  ",++l);

}
}