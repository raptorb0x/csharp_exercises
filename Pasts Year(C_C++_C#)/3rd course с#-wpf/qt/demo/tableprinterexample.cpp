
#include "tableprinterexample.h"
#include "custommodel.h"
#include <QMessageBox>
#include <QDebug>

TablePrinterExample::TablePrinterExample( QWidget* parent) : QWidget( parent)
{
	grid=TDPreviewDialog::NoGrid;
        ui.setupUi(this);
	printer= new QPrinter(QPrinter::HighResolution);
	CustomModel *model=new CustomModel(this);
	ui.tableView->setModel(model);
}

//========================================

TablePrinterExample::~TablePrinterExample()
{
}

//========================================

void TablePrinterExample::on_printPushButton_clicked()
{
	TDPreviewDialog *dialog = new TDPreviewDialog(ui.tableView,printer,this);
	dialog->setGridMode(grid);
	dialog->print();
	delete dialog;
}

//========================================

void TablePrinterExample::on_previewPushButton_clicked()
{

	TDPreviewDialog *dialog = new TDPreviewDialog(ui.tableView,printer,this);
	dialog->setGridMode(grid);
	dialog->exec();
	delete dialog;
}

//========================================

void TablePrinterExample::on_comboBox_currentIndexChanged ( int index ) 
{
	switch (index)
	{
		case 0:
			grid=TDPreviewDialog::NoGrid;
			break;
		case 1:
			grid=TDPreviewDialog::NormalGrid;
			break;
		case 2:
			grid=TDPreviewDialog::AlternateColor;
			break;
		case 3:
			grid= TDPreviewDialog::AlternateWithGrid;
	}
}
