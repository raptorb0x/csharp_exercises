#include "mainwindow.hpp"
#include "ui_mainwindow.h"

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow),
	queryform(0),
	cdWindow(0),
	opendbdialog(0)
{
    ui->setupUi(this);

	connect(ui->actionExit, SIGNAL(activated()), qApp, SLOT(quit()));
	connect(ui->actionAbout_Qt, SIGNAL(activated()), qApp, SLOT(aboutQt()));
	connect(ui->actionAbout, SIGNAL(activated()), this, SLOT(AboutProgramm()));
	connect(ui->actionAdd_cd_disk, SIGNAL(activated()), this, SLOT(CDEdit()));
	connect(ui->actionQuery, SIGNAL(activated()), this, SLOT(QueryBD()));
	connect(ui->actionOpen, SIGNAL(activated()), this, SLOT(OpenDataBaseDialog()));
	connect(ui->actionClose_Data_Base, SIGNAL(activated()), this, SLOT(CloseDataBase()));

	ui->tableView->setSelectionBehavior(QAbstractItemView::SelectRows); // устанавливает возможность выделять только строки

	// расположим окно по центру экрана
	QDesktopWidget desktop;
	QRect rect = desktop.availableGeometry(desktop.primaryScreen());
	// получаем прямоугольник с размерами как у экрана
	QPoint center = rect.center(); // получаем координаты центра этого прямоуглольника
	center.setX(center.x() - (this->width() / 2));
	center.setY(center.y() - (this->height() / 2));
	move(center); // двигаем наше окно в центр экрана

	connect(ui->addpushButton, SIGNAL(clicked()), this, SLOT(addRow()));
	connect(ui->deletepushButton, SIGNAL(clicked()), this, SLOT(delRow()));

	connect(ui->actionRemove_Data_Base, SIGNAL(activated()), this, SLOT(removeDB()));
}

MainWindow::~MainWindow()
{
	rtmodel->query().finish();
	delete rtmodel;
	QSqlDatabase::removeDatabase("sales");
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

bool MainWindow::OpenDB()
{
        QSqlDatabase db = QSqlDatabase::addDatabase("QPSQL", "MyConnect");
	db.setHostName(opendbdialog->getHstName());
	db.setDatabaseName(opendbdialog->getDBName());
	db.setUserName(opendbdialog->getUsrName());
	db.setPassword(opendbdialog->getPass());

	if (!db.open()) {
		ui->statusBar->showMessage(db.lastError().text());
		return false;
	}
	ui->statusBar->showMessage("DataBase is Opened!");
	rtmodel = new QSqlRelationalTableModel(this, db);
	rtmodel->setTable("cd_db");
	rtmodel->setSort(0, Qt::AscendingOrder); //сортируем по 1-му столбцу
	rtmodel->setRelation(1, QSqlRelation("cd", "id", "title")); // установление связи между таблицими по ключам
	rtmodel->setHeaderData(1, Qt::Horizontal, "Compact-Disk"); // задаём заголовок столбца
	rtmodel->setHeaderData(2, Qt::Horizontal, "Count"); // вместо заголовка столбца из БД
	rtmodel->setHeaderData(3, Qt::Horizontal, "Price");
	rtmodel->select(); // делаем выборку

	ui->tableView->setModel(rtmodel); // устанавливает связь таблицы отображения и модели данных
	ui->tableView->setItemDelegate(new QSqlRelationalDelegate(this)); // включение выпадающего списка
	ui->tableView->setSelectionBehavior(QAbstractItemView::SelectRows); // устанавливает возможность выделять только строки
	ui->tableView->resizeColumnsToContents(); // установить размер столбцов
																			// по длине содержимого

	connect(rtmodel, SIGNAL(beforeInsert(QSqlRecord&)),
					this, SLOT(beforeInsertRowCD(QSqlRecord&)));
	MainWindow::setWindowTitle(db.connectionName());
	opendbdialog->close();
	return true;
}

void MainWindow::AboutProgramm()
{
	AboutDialog about(this);
	about.exec();
}

void MainWindow::QueryBD()
{
	if (!queryform)
		queryform = new QueryForm(this); // если объект уже есть то зачем его опять создавать?
	queryform->show();
}

void MainWindow::OpenDataBaseDialog()
{
	if (!opendbdialog) {
		opendbdialog = new openDBDialog(this);
		connect(opendbdialog, SIGNAL(openClicked()), this, SLOT(OpenDB()));
	}
	opendbdialog->exec();
	delete opendbdialog;
	opendbdialog = 0;
}

void MainWindow::CDEdit()
{
	if (!cdWindow) {
		cdWindow = new CDDialog(this);
		cdWindow->setAttribute(Qt::WA_DeleteOnClose); // удалять окно из памяти
																						// при его закрытии

		// поскольку указатель не обнуляется при закрытии окна
		connect(cdWindow, SIGNAL(destroyed()), this, SLOT(deleteframe()));
	}

	QSqlDatabase db = QSqlDatabase::database("MyConnect");
	ui->statusBar->showMessage(db.lastError().text());

	cdWindow->show();
	cdWindow->activateWindow();
}

void MainWindow::deleteframe()
{
	cdWindow = 0; // указатель требует обнуления
}

void MainWindow::CloseDataBase()
{
	QSqlDatabase db = QSqlDatabase::database("MyConnect");
	rtmodel->query().finish();

	db.close();
	delete rtmodel;
	delete query;
}

void MainWindow::removeDB()
{
	QSqlDatabase::removeDatabase("MyConnect");
	MainWindow::setWindowTitle("MainWindow");
}

void MainWindow::addRow()
{
	int row = 0;
	if (ui->tableView->currentIndex().isValid())
		row = ui->tableView->currentIndex().row();
	rtmodel->insertRow(row);
	QModelIndex index = rtmodel->index(row, 1);
	ui->tableView->setCurrentIndex(index);
	ui->tableView->edit(index);
}

void MainWindow::beforeInsertRowCD(QSqlRecord& record)
{
	record.setValue("id", generateRowId());
}

void MainWindow::delRow()
{
	ui->tableView->setFocus();
	QModelIndex index = ui->tableView->currentIndex();
	if (!index.isValid())
		return;
	QSqlRecord record = rtmodel->record(index.row());

	QSqlTableModel cd_dbModel(this, QSqlDatabase::database("MyConnect"));
	cd_dbModel.setTable("cd_db");
	cd_dbModel.select();
	if (cd_dbModel.rowCount()) {
		rtmodel->removeRow(ui->tableView->currentIndex().row());
	}
}
