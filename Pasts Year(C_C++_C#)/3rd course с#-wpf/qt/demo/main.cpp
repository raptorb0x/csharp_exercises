
#include "tableprinterexample.h"

#include <QtGui/QApplication>

int main(int argc, char * argv[])
{
        QApplication app(argc, argv);
        Q_INIT_RESOURCE(tableprinterresource);
        TablePrinterExample win;
        win.show();

        return app.exec();
}
