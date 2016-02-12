#ifndef CLASS_H_INCLUDED
#define CLASS_H_INCLUDED

#include <iostream>
#include <string>
#include <windows.h>
#include <conio.h>

using namespace std;

class midikey
{
    string keyhis;
    public:
    midikey(){if (Beep(0,0)) cout << "Keyboard is on" << endl; else cout << "Error" << endl;};//конструктор с проверкой работоспособности звука
    ~midikey(){cout << "Keyboard is off";};
    void game(); //играет пользователь
    void game (char* demo); // играется демо
};


#endif // CLASS_H_INCLUDED
