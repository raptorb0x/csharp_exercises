#include <stdio.h>
#include <stdlib.h>

int main(void)
{
    int group[8]={1,2,3};
    char discipl[8][3]={"M","DM","CG","TB"};
    char prepod[8][15]={"Tolstova","Klashanov","Postnov","Grayznyuh","Sadovskiy"};
    char date[8][10]={"10.11","11.11","12.11","13.11"};
    int aud[8]={630,212,629,530};
    int i,j,g=3,d1=4,p=5,d2=4,a=4,w=0;
    char exit;
    int matrix [5][5];

    struct a{
        int gr;
        char dis[3];
        char prep[15];
        char dat[10];
        int ad;
    }rasp[5];


    for(i=0;i<5;i++)
     for(j=0;j<5;j++)
       matrix[i][j]=9;

 for(j=0;j<5;j++)
    {printf("\Please,enter data (Group, Discipline,teacher, Date, # classrom): \n");
     scanf("%d %s %s %s %d",
            &rasp[j].gr,
            rasp[j].dis,
            rasp[j].prep,
            rasp[j].dat,
            &rasp[j].ad);
    w=0;
    for(i=0;i<g;i++)
        if(rasp[j].gr==group[i]) matrix[j][0]=i;
        else w++;
    if(w==g) {group[g]=rasp[j].gr;
               matrix[j][0]=g;
                  g++;}
    w=0;

    for(i=0;i<d1;i++)
        if(strcmp(rasp[j].dis,discipl[i])==0) matrix[j][1]=i;
        else w++;
    if(w==d1) {strcpy(discipl[d1],rasp[j].dis);
                  matrix[j][1]=d1;
                  d1++;}
    w=0;

    for(i=0;i<p;i++)
        if(strcmp(rasp[j].prep,prepod[i])==0) matrix[j][2]=i;
        else w++;
    if(w==p) {strcpy(prepod[p],rasp[j].prep);
                  matrix[j][2]=p;
                  p++;}
    w=0;

    for(i=0;i<d2;i++)
        if(strcmp(rasp[j].dat,date[i])==0) matrix[j][3]=i;
        else w++;
    if(w==d2) {strcpy(date[d2],rasp[j].dat);
                  matrix[j][3]=d2;
                  d2++;}
    w=0;

    for(i=0;i<a;i++)
        if(rasp[j].ad==aud[i]) matrix[j][4]=i;
        else w++;
    if(w==a) {aud[a]=rasp[j].ad;
               matrix[j][4]=a;
              a++;}
    }

    printf("Array:\n");
    for(i=0;i<5;i++){
        printf("\n");
        for(j=0;j<5;j++)
         printf("%d ",matrix[i][j]);
    }

    printf("\n\n");
    for(j=0;j<5;j++)
    printf("%d %s %s %s %d\n",group[matrix[j][0]],discipl[matrix[j][1]],prepod[matrix[j][2]],
                             date[matrix[j][3]],aud[matrix[j][4]]);

return 0;
}
