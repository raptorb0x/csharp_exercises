#include "simple_class.h"

using namespace std;

int main()
{
    streamer dev(100);
    dev.write("abcdefghi");
    dev.write("1234");
    dev.write("5678",4);
    dev.read();
    dev.read(4);
    dev.read(19);
    dev.read(4,9);
    return 0;
}
