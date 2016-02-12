
#ifndef TABLEPRINTEREXAMPLE_H
#define TABLEPRINTEREXAMPLE_H
#include <QMainWindow>
#include <QWorkspace>
#include <QObject>
#include "tdpreviewdialog.h"
#include <ui_tableprinterexample.h>

class TablePrinterExample;
class TablePrinterExample : public QWidget
{
        Q_OBJECT

public:
        TablePrinterExample( QWidget* parent = 0);
        ~TablePrinterExample();

private:
        Ui_TablePrinterExample ui;
	QPrinter *printer;
	TDPreviewDialog::Grids grid;

private slots:
	virtual void on_printPushButton_clicked();
	virtual void on_previewPushButton_clicked();
	virtual void on_comboBox_currentIndexChanged ( int index );
};
#endif
