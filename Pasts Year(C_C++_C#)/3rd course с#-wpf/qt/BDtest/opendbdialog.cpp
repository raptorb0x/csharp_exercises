#include "opendbdialog.hpp"
#include "ui_opendbdialog.h"

openDBDialog::openDBDialog(QWidget *parent) :
    QDialog(parent),
    ui(new Ui::openDBDialog)
{
    ui->setupUi(this);
	connect(ui->OpenDataBasePushButton, SIGNAL(clicked()), this, SLOT(stOpenClicked()));
}

openDBDialog::~openDBDialog()
{
    delete ui;
}

void openDBDialog::changeEvent(QEvent *e)
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

void openDBDialog::stOpenClicked()
{
	emit openClicked();
}

QString openDBDialog::getHstName()
{
	return ui->HostAdresslineEdit->text();
}

QString openDBDialog::getDBName()
{
	return ui->DataBaseNamelineEdit->text();
}

QString openDBDialog::getUsrName()
{
	return ui->UserNamelineEdit->text();
}

QString openDBDialog::getPass()
{
	return ui->UserPasswordlineEdit->text();
}
