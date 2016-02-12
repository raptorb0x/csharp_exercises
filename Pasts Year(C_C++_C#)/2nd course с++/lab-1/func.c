#include "func.h"

void print ( void )
{
    int i=-1;
    FILE *in;
    if ((in = fopen( "bank.db" , "r" ))==NULL)
    {
        printf("Database not found");
        exit(1);
    }
    while( !feof( in ) )
    {

        fscanf( in , "%d", &rec.n);
        if (i==rec.n) break;
        fgets(temp,100,in);
        parser();
        printf("%d %s %s %s %s %s\n",rec.n,rec.d,rec.p,rec.name,rec.us,rec.per );
        i=rec.n;
    }
    fclose(in);
    getch();
}
void edit ( void)
{
    FILE *in, *out ,*tempf;
    int i,k;
    int a[10]={0,0,0,0,0,0,0,0,0,0};
    char switch2;
    //out=fopen ("bank.temp","w");
   // fclose(out);
    while (1)
    {
        system("cls");
        printf("Edit mode\n Press 1 to chose record to edit\n Press 2 to print temp file\n Press 3 to accept changes\n Press \"q\" to main menu\n");
        scanf("%c",&switch2);
        switch (switch2){
        case '1' :  printf ("Enter nomber record to edit\n");
                    scanf("%d",&i);
                    in=fopen ( "bank.db" , "r+" ) ;
                    while (!feof (in))
                    {
                        fscanf(in,"%d", &rec.n);
                        fgets(temp,100,in);
                        if (i==rec.n) break;

                    }
                    fclose(in);
                    parser();
                    printf("Old record %d %s %s %s %s %s\n",rec.n,rec.d,rec.p,rec.name,rec.us,rec.per );
                    printf ( "Enter new record through \";\"\n" ) ;
                    gets (temp);
                    gets (temp);
                    out=fopen ("bank.temp","a+");
                    fprintf ( out , "%d;%s\n" , rec.n ,temp) ;
                    fclose(out);
                    break;
        case '2' :
                    out=fopen ("bank.temp","r");
                    i=-1;
                    while( !feof( out ) )
                    {

                        fscanf( out , "%d", &rec.n);
                        if (i==rec.n) break;
                        fgets(temp,100,out);
                        parser();
                        printf("%d %s %s %s %s %s\n",rec.n,rec.d,rec.p,rec.name,rec.us,rec.per );
                        i=rec.n;
                    }
                    fclose(out);
                    getch();
                    break;
        case '3' :
                    out=fopen("bank.temp","r");
                    while(!feof(out))
                    {
                        fscanf(out, "%d",&i);
                        a[i]=1;
                        fgets(temp,100,out);
                    }
                    fclose(out);
                    tempf=fopen("bank.temp2","w");
                    for (i=0;i<10;i++)
                    {
                        if (a[i]==1)
                        {
                            out=fopen("bank.temp","r");
                            while (!feof(out))
                            {
                                fscanf(out,"%d",&k);
                                fgets(temp,100,out);
                                if(k==i) break;
                            }
                            fclose(out);
                            fprintf(tempf,"%d",k);
                            //fputs(temp,tempf);
                            fprintf(tempf,"%s",temp);
                        }
                         else
                         {
                            in=fopen("bank.db","r");
                            while (!feof(in))
                            {
                                fscanf(in,"%d",&k);
                                fgets(temp,100,in);
                                if(k==i) break;
                            }
                            fclose(in);
                            fprintf(tempf,"%d",k);
                            //fputs(temp,tempf);
                            fprintf(tempf,"%s",temp);
                         }

        }
                    fclose(tempf);
                    printf("\nDONE");
                    getch();
                    break;
        case 'q' :
        case 'Q' : goto loop;    }
}
loop: getch();
}
void parser (void)
{
    int i;
    strcpy(rec.d," ");
    while (1)
    {
        for (i=0;temp[i] != '\0';++i)
           temp[i] = temp[i + 1];
        if(temp[0]==';') break;
        strncat(rec.d,temp,1);
    }
    strcpy(rec.p," ");
    while (1)
    {
        for (i=0;temp[i] != '\0';++i)
           temp[i] = temp[i + 1];
        if(temp[0]==';') break;
        strncat(rec.p,temp,1);
    }
    strcpy(rec.name," ");
    while (1)
    {
        for (i=0;temp[i] != '\0';++i)
           temp[i] = temp[i + 1];
        if(temp[0]==';') break;
        strncat(rec.name,temp,1);
    }
    strcpy(rec.us," ");
    while (1)
    {
        for (i=0;temp[i] != '\0';++i)
           temp[i] = temp[i + 1];
        if(temp[0]==';') break;
        strncat(rec.us,temp,1);
    }
    strcpy(rec.per," ");
    while (1)
    {
        for (i=0;temp[i] != '\0';++i)
           temp[i] = temp[i + 1];
        if(temp[0]==';') break;
        strncat(rec.per,temp,1);
    }

}


