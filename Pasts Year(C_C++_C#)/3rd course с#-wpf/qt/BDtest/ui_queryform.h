/********************************************************************************
** Form generated from reading UI file 'queryform.ui'
**
** Created: Fri 2. Apr 06:15:27 2010
**      by: Qt User Interface Compiler version 4.6.2
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_QUERYFORM_H
#define UI_QUERYFORM_H

#include <QtCore/QVariant>
#include <QtGui/QAction>
#include <QtGui/QApplication>
#include <QtGui/QButtonGroup>
#include <QtGui/QGridLayout>
#include <QtGui/QHBoxLayout>
#include <QtGui/QHeaderView>
#include <QtGui/QPushButton>
#include <QtGui/QSpacerItem>
#include <QtGui/QTableView>
#include <QtGui/QTextEdit>
#include <QtGui/QWidget>

QT_BEGIN_NAMESPACE

class Ui_QueryForm
{
public:
    QGridLayout *gridLayout_2;
    QGridLayout *gridLayout;
    QTextEdit *QueryTextEdit;
    QHBoxLayout *horizontalLayout_2;
    QSpacerItem *horizontalSpacer_2;
    QPushButton *QueryPushButton;
    QTableView *tableView;
    QHBoxLayout *horizontalLayout;
    QSpacerItem *horizontalSpacer;
    QPushButton *ClosePushButton;

    void setupUi(QWidget *QueryForm)
    {
        if (QueryForm->objectName().isEmpty())
            QueryForm->setObjectName(QString::fromUtf8("QueryForm"));
        QueryForm->resize(331, 486);
        QueryForm->setAutoFillBackground(false);
        gridLayout_2 = new QGridLayout(QueryForm);
        gridLayout_2->setObjectName(QString::fromUtf8("gridLayout_2"));
        gridLayout = new QGridLayout();
        gridLayout->setObjectName(QString::fromUtf8("gridLayout"));
        QueryTextEdit = new QTextEdit(QueryForm);
        QueryTextEdit->setObjectName(QString::fromUtf8("QueryTextEdit"));
        QSizePolicy sizePolicy(QSizePolicy::Expanding, QSizePolicy::MinimumExpanding);
        sizePolicy.setHorizontalStretch(0);
        sizePolicy.setVerticalStretch(0);
        sizePolicy.setHeightForWidth(QueryTextEdit->sizePolicy().hasHeightForWidth());
        QueryTextEdit->setSizePolicy(sizePolicy);

        gridLayout->addWidget(QueryTextEdit, 0, 0, 1, 1);

        horizontalLayout_2 = new QHBoxLayout();
        horizontalLayout_2->setObjectName(QString::fromUtf8("horizontalLayout_2"));
        horizontalSpacer_2 = new QSpacerItem(40, 20, QSizePolicy::Expanding, QSizePolicy::Minimum);

        horizontalLayout_2->addItem(horizontalSpacer_2);

        QueryPushButton = new QPushButton(QueryForm);
        QueryPushButton->setObjectName(QString::fromUtf8("QueryPushButton"));

        horizontalLayout_2->addWidget(QueryPushButton);


        gridLayout->addLayout(horizontalLayout_2, 1, 0, 1, 1);

        tableView = new QTableView(QueryForm);
        tableView->setObjectName(QString::fromUtf8("tableView"));
        QSizePolicy sizePolicy1(QSizePolicy::Expanding, QSizePolicy::Maximum);
        sizePolicy1.setHorizontalStretch(0);
        sizePolicy1.setVerticalStretch(0);
        sizePolicy1.setHeightForWidth(tableView->sizePolicy().hasHeightForWidth());
        tableView->setSizePolicy(sizePolicy1);
        tableView->setAutoFillBackground(true);

        gridLayout->addWidget(tableView, 2, 0, 1, 1);

        horizontalLayout = new QHBoxLayout();
        horizontalLayout->setObjectName(QString::fromUtf8("horizontalLayout"));
        horizontalSpacer = new QSpacerItem(40, 20, QSizePolicy::Expanding, QSizePolicy::Minimum);

        horizontalLayout->addItem(horizontalSpacer);

        ClosePushButton = new QPushButton(QueryForm);
        ClosePushButton->setObjectName(QString::fromUtf8("ClosePushButton"));

        horizontalLayout->addWidget(ClosePushButton);


        gridLayout->addLayout(horizontalLayout, 3, 0, 1, 1);


        gridLayout_2->addLayout(gridLayout, 0, 0, 1, 1);


        retranslateUi(QueryForm);
        QObject::connect(ClosePushButton, SIGNAL(clicked()), QueryForm, SLOT(close()));

        QMetaObject::connectSlotsByName(QueryForm);
    } // setupUi

    void retranslateUi(QWidget *QueryForm)
    {
        QueryForm->setWindowTitle(QApplication::translate("QueryForm", "Form", 0, QApplication::UnicodeUTF8));
        QueryTextEdit->setDocumentTitle(QString());
        QueryTextEdit->setHtml(QApplication::translate("QueryForm", "<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.0//EN\" \"http://www.w3.org/TR/REC-html40/strict.dtd\">\n"
"<html><head><meta name=\"qrichtext\" content=\"1\" /><style type=\"text/css\">\n"
"p, li { white-space: pre-wrap; }\n"
"</style></head><body style=\" font-family:'Sans Serif'; font-size:9pt; font-weight:400; font-style:normal;\">\n"
"<p style=\" margin-top:0px; margin-bottom:0px; margin-left:0px; margin-right:0px; -qt-block-indent:0; text-indent:0px;\"><span style=\" font-size:10pt;\">select * from cd;</span></p></body></html>", 0, QApplication::UnicodeUTF8));
        QueryPushButton->setText(QApplication::translate("QueryForm", "Query", 0, QApplication::UnicodeUTF8));
        ClosePushButton->setText(QApplication::translate("QueryForm", "Close", 0, QApplication::UnicodeUTF8));
    } // retranslateUi

};

namespace Ui {
    class QueryForm: public Ui_QueryForm {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_QUERYFORM_H
