/********************************************************************************
** Form generated from reading UI file 'cddialog.ui'
**
** Created: Sun 16. May 20:19:24 2010
**      by: Qt User Interface Compiler version 4.6.2
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_CDDIALOG_H
#define UI_CDDIALOG_H

#include <QtCore/QVariant>
#include <QtGui/QAction>
#include <QtGui/QApplication>
#include <QtGui/QButtonGroup>
#include <QtGui/QDialog>
#include <QtGui/QGridLayout>
#include <QtGui/QHBoxLayout>
#include <QtGui/QHeaderView>
#include <QtGui/QLabel>
#include <QtGui/QPushButton>
#include <QtGui/QSpacerItem>
#include <QtGui/QTableView>
#include <QtGui/QVBoxLayout>

QT_BEGIN_NAMESPACE

class Ui_CDDialog
{
public:
    QGridLayout *gridLayout;
    QVBoxLayout *verticalLayout;
    QTableView *tableView;
    QHBoxLayout *horizontalLayout;
    QPushButton *addPushButton;
    QPushButton *deletePushButton;
    QPushButton *resetPushButton;
    QSpacerItem *horizontalSpacer;
    QPushButton *ClosePushButton;
    QLabel *label;
    QPushButton *pushButton;

    void setupUi(QDialog *CDDialog)
    {
        if (CDDialog->objectName().isEmpty())
            CDDialog->setObjectName(QString::fromUtf8("CDDialog"));
        CDDialog->resize(346, 257);
        gridLayout = new QGridLayout(CDDialog);
        gridLayout->setObjectName(QString::fromUtf8("gridLayout"));
        verticalLayout = new QVBoxLayout();
        verticalLayout->setObjectName(QString::fromUtf8("verticalLayout"));
        tableView = new QTableView(CDDialog);
        tableView->setObjectName(QString::fromUtf8("tableView"));

        verticalLayout->addWidget(tableView);

        horizontalLayout = new QHBoxLayout();
        horizontalLayout->setObjectName(QString::fromUtf8("horizontalLayout"));
        addPushButton = new QPushButton(CDDialog);
        addPushButton->setObjectName(QString::fromUtf8("addPushButton"));

        horizontalLayout->addWidget(addPushButton);

        deletePushButton = new QPushButton(CDDialog);
        deletePushButton->setObjectName(QString::fromUtf8("deletePushButton"));

        horizontalLayout->addWidget(deletePushButton);

        resetPushButton = new QPushButton(CDDialog);
        resetPushButton->setObjectName(QString::fromUtf8("resetPushButton"));

        horizontalLayout->addWidget(resetPushButton);

        horizontalSpacer = new QSpacerItem(40, 20, QSizePolicy::Expanding, QSizePolicy::Minimum);

        horizontalLayout->addItem(horizontalSpacer);

        ClosePushButton = new QPushButton(CDDialog);
        ClosePushButton->setObjectName(QString::fromUtf8("ClosePushButton"));

        horizontalLayout->addWidget(ClosePushButton);


        verticalLayout->addLayout(horizontalLayout);


        gridLayout->addLayout(verticalLayout, 0, 0, 1, 1);

        label = new QLabel(CDDialog);
        label->setObjectName(QString::fromUtf8("label"));

        gridLayout->addWidget(label, 2, 0, 1, 1);

        pushButton = new QPushButton(CDDialog);
        pushButton->setObjectName(QString::fromUtf8("pushButton"));

        gridLayout->addWidget(pushButton, 1, 0, 1, 1);


        retranslateUi(CDDialog);
        QObject::connect(ClosePushButton, SIGNAL(clicked()), CDDialog, SLOT(close()));

        QMetaObject::connectSlotsByName(CDDialog);
    } // setupUi

    void retranslateUi(QDialog *CDDialog)
    {
        CDDialog->setWindowTitle(QApplication::translate("CDDialog", "Dialog", 0, QApplication::UnicodeUTF8));
        addPushButton->setText(QApplication::translate("CDDialog", "Add", 0, QApplication::UnicodeUTF8));
        deletePushButton->setText(QApplication::translate("CDDialog", "Delete", 0, QApplication::UnicodeUTF8));
        resetPushButton->setText(QApplication::translate("CDDialog", "Reset", 0, QApplication::UnicodeUTF8));
        ClosePushButton->setText(QApplication::translate("CDDialog", "Close", 0, QApplication::UnicodeUTF8));
        label->setText(QString());
        pushButton->setText(QApplication::translate("CDDialog", "PushButton", 0, QApplication::UnicodeUTF8));
    } // retranslateUi

};

namespace Ui {
    class CDDialog: public Ui_CDDialog {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_CDDIALOG_H
