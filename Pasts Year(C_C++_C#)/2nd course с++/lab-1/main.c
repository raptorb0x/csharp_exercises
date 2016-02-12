#include "func.h"

int main( void )
{
    char switch1;
    while (1){
    system("cls");
    printf( "1 - Print database \n2 - Edit database \ni - Info\n" ) ;
    printf( "q - Exit\n" ) ;
    scanf( "%c", &switch1 ) ;
    switch ( switch1 )
    {
        case '1' : { print( ) ; break; }
        case '2' : { edit( ) ; break; }
        case 'i' :
        case 'I' : { printf( "1 лабораторная работа по технологии программирования Шишина Ивана\nИСТАС II-1 (c) 2009" ); getch(); break ; }
        case 'q' :
        case 'Q' : goto end;
        default  : break ;
    } }
end:
    return 0 ;
}
