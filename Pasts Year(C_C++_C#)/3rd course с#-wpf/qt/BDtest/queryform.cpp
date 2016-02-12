#include "queryform.hpp"
#include "ui_queryform.h"

QueryForm::QueryForm(QWidget *parent) :
    QWidget(parent),
    ui(new Ui::QueryForm),
	query(0)
{
    ui->setupUi(this);
	QWidget::setWindowFlags(Qt::Window);
	connect(this, SIGNAL(EscKeyCloseWindow()), this, SLOT(close()));
}

QueryForm::~QueryForm()
{
    delete ui;
	delete query;
}

void QueryForm::changeEvent(QEvent *e)
{
    QWidget::changeEvent(e);
    switch (e->type()) {
    case QEvent::LanguageChange:
        ui->retranslateUi(this);
        break;
    default:
        break;
    }
}

void QueryForm::keyPressEvent(QKeyEvent *event)
{
	switch (event->key()) {
		case Qt::Key_Escape:
			emit EscKeyCloseWindow();
			break;
		default:
			QWidget::keyPressEvent(event);
	}
}

void QueryForm::on_QueryPushButton_clicked()
{
	if (!query) query = new QSqlQueryModel(this);
	ui->tableView->setModel(query);

	query->setQuery(ui->QueryTextEdit->toPlainText(), QSqlDatabase::database("MyConnect"));
}
