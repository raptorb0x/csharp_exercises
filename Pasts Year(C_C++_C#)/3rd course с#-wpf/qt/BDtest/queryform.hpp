#ifndef QUERYFORM_HPP
#define QUERYFORM_HPP

#include <QWidget>
#include <QSqlQuery>
#include <QSqlQueryModel>
#include <QKeyEvent>

namespace Ui {
    class QueryForm;
}

class QueryForm : public QWidget {
    Q_OBJECT
public:
    QueryForm(QWidget *parent = 0);
    ~QueryForm();

protected:
    void changeEvent(QEvent *e);

signals:
	void EscKeyCloseWindow();

private:
    Ui::QueryForm *ui;
	QSqlQueryModel *query;
	void keyPressEvent(QKeyEvent *event);

private slots:
    void on_QueryPushButton_clicked();
};

#endif // QUERYFORM_HPP
