#ifndef CDDIALOG_HPP
#define CDDIALOG_HPP

#include <QDialog>
#include <QSqlTableModel>
#include <QSqlRecord>
#include <QAbstractItemView>
#include <QSqlQuery>
#include <QPrinter>
#include <QPainter>
#include <QPrintDialog>
#include <QItemDelegate>
#include <QMainWindow>
#include <QAbstractTableModel>
#include <QImage>
#include <QAbstractItemDelegate>
#include <QFontMetrics>
#include <QModelIndex>
#include <QSize>
#include <QAbstractItemView>
#include <QFont>
#include <QItemSelection>
#include <QItemSelectionModel>
#include <QModelIndex>
#include <QRect>
#include <QSize>
#include <QPoint>
#include <QWidget>

QT_BEGIN_NAMESPACE
class QAbstractItemModel;
class QAbstractItemView;
class QItemSelectionModel;
class QObject;
class QPainter;
QT_END_NAMESPACE

namespace Ui {
    class CDDialog;
}


class CDDialog : public QDialog, public QAbstractItemDelegate {
    Q_OBJECT
public:
    CDDialog(QWidget *parent = 0);
    ~CDDialog();

protected:
    void changeEvent(QEvent *e);

private:
	enum {CD_id = 0, CD_title, CD_artist, CD_year};

    Ui::CDDialog *ui;
	QSqlDatabase db;
	QSqlTableModel *model;

private slots:
        void on_pushButton_clicked();
 void addCD();
	void delCD();
	void beforeInsertArtist(QSqlRecord &record);
	void resetTable();
};


inline int generateCDId()
{
	QSqlQuery query(QSqlDatabase::database("MyConnect"));
	query.exec("SELECT nextval('cd_id_seq')");
	int id = 0;
	if (query.next())
		id = query.value(0).toInt();
	return id;
}


#endif // CDDIALOG_HPP
