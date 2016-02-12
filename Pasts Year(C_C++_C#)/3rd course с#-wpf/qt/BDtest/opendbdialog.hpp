#ifndef OPENDBDIALOG_HPP
#define OPENDBDIALOG_HPP

#include <QDialog>

namespace Ui {
    class openDBDialog;
}

class openDBDialog : public QDialog {
    Q_OBJECT
public:
    openDBDialog(QWidget *parent = 0);
    ~openDBDialog();

	QString getHstName();
	QString getDBName();
	QString getUsrName();
	QString getPass();

signals:
	void openClicked();

protected:
    void changeEvent(QEvent *e);

private:
    Ui::openDBDialog *ui;

public slots:
	void stOpenClicked();
};

#endif // OPENDBDIALOG_HPP
