#ifndef SIMPLE_CLASS_H_INCLUDED
#define SIMPLE_CLASS_H_INCLUDED

#include <iostream>
#include <string>

using namespace std;

class streamer
{
    public:
    char *data; // датапоток ленты
    int tapelong; // длина ленты
    bool clear;
    streamer() { cout<<"Default size of tape is 100"<<endl; data = new char[100]; strcpy(data,""); tapelong=100;clear=1;};
    streamer(const int n) { cout<<"Set size of tape is "<<n<<endl; data = new char[n];  strcpy(data,""); tapelong=n;clear=1;};
    ~streamer () {};
    void write(const char* );//запись с начала
    void write(const char*, const int ); //запись с n-ого кластера
    void read(); //чтение все
    void status(); // статус
    void read (const int n); //чтение кластера
    void read (const int n, const int k); //чтение диапазона
    void sclear ();
};


#endif // SIMPLE_CLASS_H_INCLUDED
