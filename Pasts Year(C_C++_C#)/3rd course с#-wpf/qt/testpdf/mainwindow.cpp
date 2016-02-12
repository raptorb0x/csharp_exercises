#include "mainwindow.h"
#include "ui_mainwindow.h"
#include "pdflib.hpp"

std::wstring
qs2ws(const QString& str)
{
    return (std::wstring((wchar_t*)str.unicode(), str.length()));
}

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);
}

MainWindow::~MainWindow()
{
    delete ui;
}

void MainWindow::changeEvent(QEvent *e)
{
    QMainWindow::changeEvent(e);
    switch (e->type()) {
    case QEvent::LanguageChange:
        ui->retranslateUi(this);
        break;
    default:
        break;
    }
}


void MainWindow::on_pushButton_3_clicked()
{
    QPrinter *printer = new QPrinter(QPrinter::HighResolution);
    printer->setOutputFormat( QPrinter::PdfFormat );
    printer->setOutputFileName( "test.pdf" );

    printer->setOrientation(QPrinter::Landscape);
    printer->setColorMode(QPrinter::GrayScale);
    printer->setPageSize(QPrinter::A4);
    QPainter painter;
    painter.begin(printer);
    painter.drawRect( printer->pageRect() );
    painter.drawLine( printer->pageRect().topRight(),
       printer->pageRect().bottomLeft() );
    //painter.drawText(printer->pageRect().center(),ui->plain->toPlainText());
    painter.end();
}

void MainWindow::on_pushButton_2_clicked()
{

    QPrinter *printer = new QPrinter(QPrinter::HighResolution);
    QPainter painter;

        printer->setOrientation(QPrinter::Landscape);
        printer->setNumCopies(1);
        printer->setColorMode(QPrinter::GrayScale);
        printer->setPageSize(QPrinter::A4);

       QPrintDialog printDialog(printer, this);
       printDialog.setWindowTitle("Print Document");
       if(printDialog.exec() == QDialog::Accepted)
       {
          painter.begin(printer);
          //painter.drawText(printer->pageRect().center(), ui->plain->toPlainText());
          painter.end();
       }

}
