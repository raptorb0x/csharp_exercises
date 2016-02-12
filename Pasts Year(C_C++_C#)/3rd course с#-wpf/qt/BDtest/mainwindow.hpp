#ifndef MAINWINDOW_HPP
#define MAINWINDOW_HPP

#include <QMainWindow>
#include <QSqlDatabase>
#include <QtSql>
#include "opendbdialog.hpp"
#include "aboutdialog.hpp"
#include "queryform.hpp"
#include "cddialog.hpp"
#include <QMessageBox>
#include <QDesktopWidget>
#include <QPrinter>
#include <QPainter>
#include <QPrintDialog>


class CDDialog;

namespace Ui {
    class MainWindow;
	class openDBDialog;
}

class MainWindow : public QMainWindow {
    Q_OBJECT
public:
    MainWindow(QWidget *parent = 0);
    ~MainWindow();

signals:
	void removeConnectDB();

protected:
    void changeEvent(QEvent *e);

private:
    Ui::MainWindow *ui;
	QSqlQuery *query;
//	QSqlDatabase db;
	QSqlRelationalTableModel *rtmodel;
	QueryForm *queryform;
	CDDialog *cdWindow;
	openDBDialog *opendbdialog;

private slots:
	void AboutProgramm();
	void QueryBD();
	void OpenDataBaseDialog();
	void CDEdit();
	bool OpenDB();
	void deleteframe();
	void addRow();
	void delRow();
	void CloseDataBase();
	void beforeInsertRowCD(QSqlRecord& record);
	void removeDB();
};

inline int generateRowId()
{
	QSqlQuery query(QSqlDatabase::database("MyConnect"));
	query.exec("SELECT nextval('cd_db_id_seq')");
	int id = 0;
	if (query.next())
		id = query.value(0).toInt();
	return id;
}

#endif // MAINWINDOW_HPP
