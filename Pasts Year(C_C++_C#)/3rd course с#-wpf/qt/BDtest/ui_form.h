/********************************************************************************
** Form generated from reading UI file 'form.ui'
**
** Created: Sat Mar 13 20:59:58 2010
**      by: Qt User Interface Compiler version 4.6.2
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_FORM_H
#define UI_FORM_H

#include <QtCore/QVariant>
#include <QtGui/QAction>
#include <QtGui/QApplication>
#include <QtGui/QButtonGroup>
#include <QtGui/QHBoxLayout>
#include <QtGui/QHeaderView>
#include <QtGui/QLineEdit>
#include <QtGui/QPushButton>
#include <QtGui/QSpacerItem>
#include <QtGui/QVBoxLayout>
#include <QtGui/QWidget>

QT_BEGIN_NAMESPACE

class Ui_Form
{
public:
    QVBoxLayout *verticalLayout_2;
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

    void setupUi(QWidget *Form)
    {
        if (Form->objectName().isEmpty())
            Form->setObjectName(QString::fromUtf8("Form"));
        Form->resize(223, 184);
        Form->setInputMethodHints(Qt::ImhDialableCharactersOnly|Qt::ImhDigitsOnly|Qt::ImhEmailCharactersOnly|Qt::ImhExclusiveInputMask|Qt::ImhFormattedNumbersOnly|Qt::ImhHiddenText|Qt::ImhLowercaseOnly|Qt::ImhNoAutoUppercase|Qt::ImhNoPredictiveText|Qt::ImhPreferLowercase|Qt::ImhPreferNumbers|Qt::ImhPreferUppercase|Qt::ImhUppercaseOnly|Qt::ImhUrlCharactersOnly);
        verticalLayout_2 = new QVBoxLayout(Form);
        verticalLayout_2->setObjectName(QString::fromUtf8("verticalLayout_2"));
        verticalLayout_3 = new QVBoxLayout();
        verticalLayout_3->setObjectName(QString::fromUtf8("verticalLayout_3"));
        verticalLayout = new QVBoxLayout();
        verticalLayout->setObjectName(QString::fromUtf8("verticalLayout"));
        HostAdresslineEdit = new QLineEdit(Form);
        HostAdresslineEdit->setObjectName(QString::fromUtf8("HostAdresslineEdit"));

        verticalLayout->addWidget(HostAdresslineEdit);

        DataBaseNamelineEdit = new QLineEdit(Form);
        DataBaseNamelineEdit->setObjectName(QString::fromUtf8("DataBaseNamelineEdit"));

        verticalLayout->addWidget(DataBaseNamelineEdit);

        UserNamelineEdit = new QLineEdit(Form);
        UserNamelineEdit->setObjectName(QString::fromUtf8("UserNamelineEdit"));

        verticalLayout->addWidget(UserNamelineEdit);

        UserPasswordlineEdit = new QLineEdit(Form);
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
        OpenDataBasePushButton = new QPushButton(Form);
        OpenDataBasePushButton->setObjectName(QString::fromUtf8("OpenDataBasePushButton"));

        horizontalLayout->addWidget(OpenDataBasePushButton);

        horizontalSpacer = new QSpacerItem(40, 20, QSizePolicy::Expanding, QSizePolicy::Minimum);

        horizontalLayout->addItem(horizontalSpacer);

        CancelPushButton = new QPushButton(Form);
        CancelPushButton->setObjectName(QString::fromUtf8("CancelPushButton"));

        horizontalLayout->addWidget(CancelPushButton);


        verticalLayout_3->addLayout(horizontalLayout);


        verticalLayout_2->addLayout(verticalLayout_3);

        QWidget::setTabOrder(HostAdresslineEdit, DataBaseNamelineEdit);
        QWidget::setTabOrder(DataBaseNamelineEdit, UserNamelineEdit);
        QWidget::setTabOrder(UserNamelineEdit, UserPasswordlineEdit);
        QWidget::setTabOrder(UserPasswordlineEdit, OpenDataBasePushButton);
        QWidget::setTabOrder(OpenDataBasePushButton, CancelPushButton);

        retranslateUi(Form);
        QObject::connect(CancelPushButton, SIGNAL(clicked()), Form, SLOT(close()));

        QMetaObject::connectSlotsByName(Form);
    } // setupUi

    void retranslateUi(QWidget *Form)
    {
        Form->setWindowTitle(QApplication::translate("Form", "Form", 0, QApplication::UnicodeUTF8));
        HostAdresslineEdit->setText(QApplication::translate("Form", "217.172.21.199", 0, QApplication::UnicodeUTF8));
        DataBaseNamelineEdit->setText(QApplication::translate("Form", "cddb", 0, QApplication::UnicodeUTF8));
        UserNamelineEdit->setText(QApplication::translate("Form", "student", 0, QApplication::UnicodeUTF8));
        OpenDataBasePushButton->setText(QApplication::translate("Form", "Open Data Base", 0, QApplication::UnicodeUTF8));
        CancelPushButton->setText(QApplication::translate("Form", "Cancel", 0, QApplication::UnicodeUTF8));
    } // retranslateUi

};

namespace Ui {
    class Form: public Ui_Form {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_FORM_H
