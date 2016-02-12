#include "simple_class.h"

//using namespace std;

void streamer::write(const char *str)
{
    char temp;
    if (tapelong < strlen(str))
        {
            cout<< "Capacities of the tape do not suffice for record. Need "<<strlen(str)-tapelong<<" more"<<endl;
            goto over;
        }
    if(clear)
    {
        strcpy(data,str);
        clear=0;
    }
    else
    {
        temp=data[strlen(str)];
        strcpy(data,str);
        data[strlen(str)]=temp;
    }
    over: ;
}

void streamer::write(const char *str, const int n)
{
    int i;
    char temp;
    if (tapelong-n < strlen(str))
        {
            cout<< "Capacities of the tape do not suffice for record. Need "<<strlen(str)-tapelong+n<<" more"<<endl;
            goto end;
        }
    if (clear)
    {
        strcpy(data,str);
        clear=0;
        goto end;
    }
    if (strlen(data)<n)
    {
        i=strlen(data);
        data+=i;
        strcpy(data,str);
        data-=i;
        goto end;
    }
    if (strlen(data)>strlen(str)+n)
    {
        data+=n;
        temp=data[strlen(str)];
        strcpy(data,str);
        data[strlen(str)]=temp;
        data-=n;
        goto end;
    }
    data+=n;
    strcpy(data,str);
    data-=n;
    end: ;

}

void streamer::sclear()
{
    clear=0;
    delete data;
}
void streamer::status()
{
    cout<<"Tape status:"<<endl;
    cout<<"The written clusters  :   "<<strlen(data)<<endl;
    cout<<"From total            :   "<<tapelong<< endl;
}
void streamer::read()
{
    cout<<"Datasteam from tape    :   "<<data<<endl;
}
void streamer::read(int n)
{
    if(strlen(data) < n) cout << "Claster "<< n << " is free" << endl;
    else
    cout<<"Data from "<<n<<" claster is: " << data[n] <<endl;
}
void streamer::read(int n, int k)
{
    int i;
    if(strlen(data) < k) { cout << "No data in this range"<< endl; goto endread;}
    if(n>k) {cout << "Error in data entry"; goto endread;}
    cout <<"Data from a range ";
    for (i=n;i<k;i++)
    cout<<data[i];
    cout<<endl;
    endread: ;
}
