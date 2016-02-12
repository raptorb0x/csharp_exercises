#include "cddialog.hpp"
#include "ui_cddialog.h"

CDDialog::CDDialog(QWidget *parent) :
    QDialog(parent),
    ui(new Ui::CDDialog),
	db(QSqlDatabase::database("MyConnect")),
	model(0)
{
    ui->setupUi(this);
	model = new QSqlTableModel(this, db); // создаём модель представление
	model->setTable("cd"); // подсоединяем таблицу из БД
	model->setSort(CD_id, Qt::AscendingOrder); //сортируем по 1-му столбцу
	model->setHeaderData(CD_title, Qt::Horizontal, "Title"); // задаём заголовок всместо заголовка из БД
	model->setHeaderData(CD_artist, Qt::Horizontal, "Artist");
	model->setHeaderData(CD_year, Qt::Horizontal, "Year");
	model->select(); // делаем выборку из базы

	connect(model, SIGNAL(beforeInsert(QSqlRecord&)),
					this, SLOT(beforeInsertArtist(QSqlRecord&)));

	connect(ui->addPushButton, SIGNAL(clicked()), this, SLOT(addCD()));
	connect(ui->deletePushButton, SIGNAL(clicked()), this, SLOT(delCD()));
	connect(ui->resetPushButton, SIGNAL(clicked()), this, SLOT(resetTable()));

	ui->tableView->setModel(model); // соединяем модель и таблицу отображения
	ui->tableView->setColumnHidden(CD_id, true); // прячем столбец ID
	ui->tableView->setSelectionBehavior(QAbstractItemView::SelectRows); // устанавливает возможность выделять только строки
	ui->tableView->resizeColumnsToContents(); // установить размер столбцов
	// по длине содержимого
}

CDDialog::~CDDialog()
{
    delete ui;
	model->query().finish();
	delete model;
}

void CDDialog::changeEvent(QEvent *e)
{
    QDialog::changeEvent(e);
    switch (e->type()) {
    case QEvent::LanguageChange:
        ui->retranslateUi(this);
        break;
    default:
        break;
    }
}

void CDDialog::addCD()
{
	int row = model->rowCount(); // определяем колличество строк
	model->insertRow(row); // встовляем новую строчку в конец
	QModelIndex index = model->index(row, CD_artist); // индекс строки и столбца
	ui->tableView->setCurrentIndex(index); // устанавсливаем текущию строку последней
	ui->tableView->edit(index); // открываем редактирование текущей строки
}

void CDDialog::delCD()
{
	ui->tableView->setFocus();
	QModelIndex index = ui->tableView->currentIndex();
	if (!index.isValid())
		return;
	QSqlRecord record = model->record(index.row());

	QSqlTableModel cdModel(this, db);
	cdModel.setTable("cd");
	cdModel.select();
	if (cdModel.rowCount()) {
		model->removeRow(ui->tableView->currentIndex().row());
	}
}

void CDDialog::resetTable()
{
	model->clear();
	model->query().finish();
}

void CDDialog::beforeInsertArtist(QSqlRecord &record)
{
	record.setValue("id", generateCDId());
	ui->label->setText(db.connectionName());
}

void CDDialog::on_pushButton_clicked()
{
    QPrinter *printer = new QPrinter(QPrinter::HighResolution);
    printer->setOutputFormat( QPrinter::PdfFormat );
    printer->setOutputFileName( "test.pdf" );

    QPainter painter(printer);
    const int rows = ui->tableView->model()->rowCount();
    const int cols = ui->tableView->model()->columnCount();
    // calculate the total width/height table would need without scaling
    double totalWidth = 0.0;
    for (int c = 0; c < cols; ++c)
    {
        totalWidth += ui->tableView->columnWidth(c);
    }
    double totalHeight = 0.0;
    for (int r = 0; r < rows; ++r)
    {
    totalHeight += ui->tableView->rowHeight(r);
    }

    // paint cells
    for (int r = 0; r < rows; ++r)
    {
    for (int c = 0; c < cols; ++c)
    {
    QModelIndex idx = ui->tableView->model()->index(r,c);
    QStyleOptionViewItem option = ui->tableView->viewOptions();
    option.rect = ui->tableView->visualRect(idx);

    ui->tableView->itemDelegate()->paint(&painter, option, idx);
    }
    }
    }


