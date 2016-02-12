#include "class.h"

using namespace std;

void midikey::game ( void )
{
    char a;
    int freq=100;

    while(1)
    {
        cout<<keyhis;
        a=getch();
        keyhis+=a;
        switch(a){
        case 'a':
        {
            system("cls");
            Beep(523,freq);
            break;
        }
        case 's':
        {
            system("cls");
            Beep(587,freq);
            break;
        }
        case 'd':
        {
            system("cls");
            Beep(660,freq);
            break;
        }
        case 'f':
        {
            system("cls");
            Beep(698,freq);
            break;
        }
        case 'g':
        {
            system("cls");
            Beep(783,freq);
            break;
        }
        case 'h':
        {
            system("cls");
            Beep(880,freq);
            break;
        }
        case 'j':
        {
            system("cls");
            Beep(987,freq);
            break;
        }

        case 'q':
            goto end;
        default :
        {
            system("cls");
            break;
        }
    }
}
end: ;
}
void midikey::game ( char* demo)
{
    char a;
    int i=0;
    int freq=300;
    while(1)
    {
        if(demo[i]=='\0') goto end;
        a=demo[i];
        i++;
        switch(a){
        case 'a':
        {
            system("cls");
            Beep(523,freq);
            break;
        }
        case 's':
        {
            system("cls");
            Beep(587,freq);
            break;
        }
        case 'd':
        {
            system("cls");
            Beep(660,freq);
            break;
        }
        case 'f':
        {
            system("cls");
            Beep(698,freq);
            break;
        }
        case 'g':
        {
            system("cls");
            Beep(783,freq);
            break;
        }
        case 'h':
        {
            system("cls");
            Beep(880,freq);
            break;
        }
        case 'j':
        {
            system("cls");
            Beep(987,freq);
            break;
        }

        case 'q':
            goto end;
        default :
        {
            system("cls");
            break;
        }
    }
}
end: ;
}

