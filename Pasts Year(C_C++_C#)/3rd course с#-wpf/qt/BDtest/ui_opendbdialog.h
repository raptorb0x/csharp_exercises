/********************************************************************************
** Form generated from reading UI file 'opendbdialog.ui'
**
** Created: Fri 2. Apr 06:15:27 2010
**      by: Qt User Interface Compiler version 4.6.2
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_OPENDBDIALOG_H
#define UI_OPENDBDIALOG_H

#include <QtCore/QVariant>
#include <QtGui/QAction>
#include <QtGui/QApplication>
#include <QtGui/QButtonGroup>
#include <QtGui/QDialog>
#include <QtGui/QGridLayout>
#include <QtGui/QHBoxLayout>
#include <QtGui/QHeaderView>
#include <QtGui/QLineEdit>
#include <QtGui/QPushButton>
#include <QtGui/QSpacerItem>
#include <QtGui/QVBoxLayout>

QT_BEGIN_NAMESPACE

class Ui_openDBDialog
{
public:
    QGridLayout *gridLayout;
    QVBoxLayout *verticalLayoutMain;
    QVBoxLayout *verticalLayout;
    QLineEdit *HostAdresslineEdit;
    QLineEdit *DataBaseNamelineEdit;
    QLineEdit *UserNamelineEdit;
    QLineEdit *UserPasswordlineEdit;
    QSpacerItem *verticalSpacer;
    QHBoxLayout *horizontalLayout;
    QPushButton *OpenDataBasePushButton;
    QSpacerItem *horizontalSpacer;
    QPushButton *ClosePushButton;

    void setupUi(QDialog *openDBDialog)
    {
        if (openDBDialog->objectName().isEmpty())
            openDBDialog->setObjectName(QString::fromUtf8("openDBDialog"));
        openDBDialog->resize(223, 175);
        gridLayout = new QGridLayout(openDBDialog);
        gridLayout->setObjectName(QString::fromUtf8("gridLayout"));
        verticalLayoutMain = new QVBoxLayout();
        verticalLayoutMain->setObjectName(QString::fromUtf8("verticalLayoutMain"));
        verticalLayout = new QVBoxLayout();
        verticalLayout->setObjectName(QString::fromUtf8("verticalLayout"));
        HostAdresslineEdit = new QLineEdit(openDBDialog);
        HostAdresslineEdit->setObjectName(QString::fromUtf8("HostAdresslineEdit"));

        verticalLayout->addWidget(HostAdresslineEdit);

        DataBaseNamelineEdit = new QLineEdit(openDBDialog);
        DataBaseNamelineEdit->setObjectName(QString::fromUtf8("DataBaseNamelineEdit"));

        verticalLayout->addWidget(DataBaseNamelineEdit);

        UserNamelineEdit = new QLineEdit(openDBDialog);
        UserNamelineEdit->setObjectName(QString::fromUtf8("UserNamelineEdit"));

        verticalLayout->addWidget(UserNamelineEdit);

        UserPasswordlineEdit = new QLineEdit(openDBDialog);
        UserPasswordlineEdit->setObjectName(QString::fromUtf8("UserPasswordlineEdit"));
        UserPasswordlineEdit->setText(QString::fromUtf8("3265"));
        UserPasswordlineEdit->setFrame(true);
        UserPasswordlineEdit->setEchoMode(QLineEdit::Password);

        verticalLayout->addWidget(UserPasswordlineEdit);


        verticalLayoutMain->addLayout(verticalLayout);

        verticalSpacer = new QSpacerItem(20, 40, QSizePolicy::Minimum, QSizePolicy::Expanding);

        verticalLayoutMain->addItem(verticalSpacer);

        horizontalLayout = new QHBoxLayout();
        horizontalLayout->setObjectName(QString::fromUtf8("horizontalLayout"));
        OpenDataBasePushButton = new QPushButton(openDBDialog);
        OpenDataBasePushButton->setObjectName(QString::fromUtf8("OpenDataBasePushButton"));

        horizontalLayout->addWidget(OpenDataBasePushButton);

        horizontalSpacer = new QSpacerItem(40, 20, QSizePolicy::Expanding, QSizePolicy::Minimum);

        horizontalLayout->addItem(horizontalSpacer);

        ClosePushButton = new QPushButton(openDBDialog);
        ClosePushButton->setObjectName(QString::fromUtf8("ClosePushButton"));

        horizontalLayout->addWidget(ClosePushButton);


        verticalLayoutMain->addLayout(horizontalLayout);


        gridLayout->addLayout(verticalLayoutMain, 0, 0, 1, 1);


        retranslateUi(openDBDialog);
        QObject::connect(ClosePushButton, SIGNAL(clicked()), openDBDialog, SLOT(close()));

        QMetaObject::connectSlotsByName(openDBDialog);
    } // setupUi

    void retranslateUi(QDialog *openDBDialog)
    {
        openDBDialog->setWindowTitle(QApplication::translate("openDBDialog", "Dialog", 0, QApplication::UnicodeUTF8));
        HostAdresslineEdit->setText(QApplication::translate("openDBDialog", "217.172.21.199", 0, QApplication::UnicodeUTF8));
        DataBaseNamelineEdit->setText(QApplication::translate("openDBDialog", "cddb", 0, QApplication::UnicodeUTF8));
        UserNamelineEdit->setText(QApplication::translate("openDBDialog", "student", 0, QApplication::UnicodeUTF8));
        OpenDataBasePushButton->setText(QApplication::translate("openDBDialog", "Open Data Base", 0, QApplication::UnicodeUTF8));
        ClosePushButton->setText(QApplication::translate("openDBDialog", "Close", 0, QApplication::UnicodeUTF8));
    } // retranslateUi

};

namespace Ui {
    class openDBDialog: public Ui_openDBDialog {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_OPENDBDIALOG_H
