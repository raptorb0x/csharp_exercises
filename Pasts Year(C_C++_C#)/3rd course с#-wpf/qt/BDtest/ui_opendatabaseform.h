/********************************************************************************
** Form generated from reading UI file 'opendatabaseform.ui'
**
** Created: Sat Mar 13 20:59:58 2010
**      by: Qt User Interface Compiler version 4.6.2
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_OPENDATABASEFORM_H
#define UI_OPENDATABASEFORM_H

#include <QtCore/QVariant>
#include <QtGui/QAction>
#include <QtGui/QApplication>
#include <QtGui/QButtonGroup>
#include <QtGui/QGridLayout>
#include <QtGui/QHBoxLayout>
#include <QtGui/QHeaderView>
#include <QtGui/QLineEdit>
#include <QtGui/QPushButton>
#include <QtGui/QSpacerItem>
#include <QtGui/QVBoxLayout>
#include <QtGui/QWidget>

QT_BEGIN_NAMESPACE

class Ui_OpenDataBaseForm
{
public:
    QGridLayout *gridLayout;
    QVBoxLayout *verticalLayout_3;
    QVBoxLayout *verticalLayout;
    QLineEdit *HostAdresslineEdit;
    QLineEdit *DataBaseNamelineEdit;
    QLineEdit *UserNamelineEdit;
    QLineEdit *UserPasswordlineEdit;
    QSpacerItem *verticalSpacer;
    QHBoxLayout *horizontalLayout;
    QPushButton *OpenDataBasePushButton;
    QSpacerItem *horizontalSpacer;
    QPushButton *CancelPushButton;

    void setupUi(QWidget *OpenDataBaseForm)
    {
        if (OpenDataBaseForm->objectName().isEmpty())
            OpenDataBaseForm->setObjectName(QString::fromUtf8("OpenDataBaseForm"));
        OpenDataBaseForm->setWindowModality(Qt::NonModal);
        OpenDataBaseForm->resize(245, 162);
        OpenDataBaseForm->setFocusPolicy(Qt::ClickFocus);
        OpenDataBaseForm->setAutoFillBackground(false);
        gridLayout = new QGridLayout(OpenDataBaseForm);
        gridLayout->setObjectName(QString::fromUtf8("gridLayout"));
        verticalLayout_3 = new QVBoxLayout();
        verticalLayout_3->setObjectName(QString::fromUtf8("verticalLayout_3"));
        verticalLayout = new QVBoxLayout();
        verticalLayout->setObjectName(QString::fromUtf8("verticalLayout"));
        HostAdresslineEdit = new QLineEdit(OpenDataBaseForm);
        HostAdresslineEdit->setObjectName(QString::fromUtf8("HostAdresslineEdit"));

        verticalLayout->addWidget(HostAdresslineEdit);

        DataBaseNamelineEdit = new QLineEdit(OpenDataBaseForm);
        DataBaseNamelineEdit->setObjectName(QString::fromUtf8("DataBaseNamelineEdit"));

        verticalLayout->addWidget(DataBaseNamelineEdit);

        UserNamelineEdit = new QLineEdit(OpenDataBaseForm);
        UserNamelineEdit->setObjectName(QString::fromUtf8("UserNamelineEdit"));

        verticalLayout->addWidget(UserNamelineEdit);

        UserPasswordlineEdit = new QLineEdit(OpenDataBaseForm);
        UserPasswordlineEdit->setObjectName(QString::fromUtf8("UserPasswordlineEdit"));
        UserPasswordlineEdit->setText(QString::fromUtf8("3265"));
        UserPasswordlineEdit->setFrame(true);
        UserPasswordlineEdit->setEchoMode(QLineEdit::Password);

        verticalLayout->addWidget(UserPasswordlineEdit);


        verticalLayout_3->addLayout(verticalLayout);

        verticalSpacer = new QSpacerItem(20, 40, QSizePolicy::Minimum, QSizePolicy::Expanding);

        verticalLayout_3->addItem(verticalSpacer);

        horizontalLayout = new QHBoxLayout();
        horizontalLayout->setObjectName(QString::fromUtf8("horizontalLayout"));
        OpenDataBasePushButton = new QPushButton(OpenDataBaseForm);
        OpenDataBasePushButton->setObjectName(QString::fromUtf8("OpenDataBasePushButton"));

        horizontalLayout->addWidget(OpenDataBasePushButton);

        horizontalSpacer = new QSpacerItem(40, 20, QSizePolicy::Expanding, QSizePolicy::Minimum);

        horizontalLayout->addItem(horizontalSpacer);

        CancelPushButton = new QPushButton(OpenDataBaseForm);
        CancelPushButton->setObjectName(QString::fromUtf8("CancelPushButton"));

        horizontalLayout->addWidget(CancelPushButton);


        verticalLayout_3->addLayout(horizontalLayout);


        gridLayout->addLayout(verticalLayout_3, 0, 0, 1, 1);


        retranslateUi(OpenDataBaseForm);
        QObject::connect(CancelPushButton, SIGNAL(clicked()), OpenDataBaseForm, SLOT(close()));

        QMetaObject::connectSlotsByName(OpenDataBaseForm);
    } // setupUi

    void retranslateUi(QWidget *OpenDataBaseForm)
    {
        OpenDataBaseForm->setWindowTitle(QApplication::translate("OpenDataBaseForm", "Form", 0, QApplication::UnicodeUTF8));
        HostAdresslineEdit->setText(QApplication::translate("OpenDataBaseForm", "217.172.21.199", 0, QApplication::UnicodeUTF8));
        DataBaseNamelineEdit->setText(QApplication::translate("OpenDataBaseForm", "cddb", 0, QApplication::UnicodeUTF8));
        UserNamelineEdit->setText(QApplication::translate("OpenDataBaseForm", "student", 0, QApplication::UnicodeUTF8));
        OpenDataBasePushButton->setText(QApplication::translate("OpenDataBaseForm", "Open Data Base", 0, QApplication::UnicodeUTF8));
        CancelPushButton->setText(QApplication::translate("OpenDataBaseForm", "Cancel", 0, QApplication::UnicodeUTF8));
    } // retranslateUi

};

namespace Ui {
    class OpenDataBaseForm: public Ui_OpenDataBaseForm {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_OPENDATABASEFORM_H
