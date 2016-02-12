/********************************************************************************
** Form generated from reading UI file 'tableprinterexample.ui'
**
** Created: Tue 25. May 22:35:50 2010
**      by: Qt User Interface Compiler version 4.6.2
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_TABLEPRINTEREXAMPLE_H
#define UI_TABLEPRINTEREXAMPLE_H

#include <QtCore/QVariant>
#include <QtGui/QAction>
#include <QtGui/QApplication>
#include <QtGui/QButtonGroup>
#include <QtGui/QComboBox>
#include <QtGui/QHBoxLayout>
#include <QtGui/QHeaderView>
#include <QtGui/QPushButton>
#include <QtGui/QSpacerItem>
#include <QtGui/QTableView>
#include <QtGui/QVBoxLayout>
#include <QtGui/QWidget>

QT_BEGIN_NAMESPACE

class Ui_TablePrinterExample
{
public:
    QHBoxLayout *hboxLayout;
    QTableView *tableView;
    QVBoxLayout *vboxLayout;
    QComboBox *comboBox;
    QPushButton *previewPushButton;
    QPushButton *closePushButton;
    QSpacerItem *spacerItem;

    void setupUi(QWidget *TablePrinterExample)
    {
        if (TablePrinterExample->objectName().isEmpty())
            TablePrinterExample->setObjectName(QString::fromUtf8("TablePrinterExample"));
        TablePrinterExample->resize(652, 300);
        hboxLayout = new QHBoxLayout(TablePrinterExample);
        hboxLayout->setObjectName(QString::fromUtf8("hboxLayout"));
        tableView = new QTableView(TablePrinterExample);
        tableView->setObjectName(QString::fromUtf8("tableView"));
        tableView->setSortingEnabled(true);

        hboxLayout->addWidget(tableView);

        vboxLayout = new QVBoxLayout();
        vboxLayout->setObjectName(QString::fromUtf8("vboxLayout"));
        comboBox = new QComboBox(TablePrinterExample);
        comboBox->setObjectName(QString::fromUtf8("comboBox"));
        comboBox->setSizeAdjustPolicy(QComboBox::AdjustToContents);

        vboxLayout->addWidget(comboBox);

        previewPushButton = new QPushButton(TablePrinterExample);
        previewPushButton->setObjectName(QString::fromUtf8("previewPushButton"));

        vboxLayout->addWidget(previewPushButton);

        closePushButton = new QPushButton(TablePrinterExample);
        closePushButton->setObjectName(QString::fromUtf8("closePushButton"));

        vboxLayout->addWidget(closePushButton);

        spacerItem = new QSpacerItem(20, 40, QSizePolicy::Minimum, QSizePolicy::Expanding);

        vboxLayout->addItem(spacerItem);


        hboxLayout->addLayout(vboxLayout);


        retranslateUi(TablePrinterExample);
        QObject::connect(closePushButton, SIGNAL(clicked()), TablePrinterExample, SLOT(close()));

        QMetaObject::connectSlotsByName(TablePrinterExample);
    } // setupUi

    void retranslateUi(QWidget *TablePrinterExample)
    {
        TablePrinterExample->setWindowTitle(QApplication::translate("TablePrinterExample", "Form", 0, QApplication::UnicodeUTF8));
        comboBox->clear();
        comboBox->insertItems(0, QStringList()
         << QApplication::translate("TablePrinterExample", "NoGrid", 0, QApplication::UnicodeUTF8)
         << QApplication::translate("TablePrinterExample", "NormalGrid", 0, QApplication::UnicodeUTF8)
         << QApplication::translate("TablePrinterExample", "AlternateColor", 0, QApplication::UnicodeUTF8)
         << QApplication::translate("TablePrinterExample", "AlternateColor & Normal Grid", 0, QApplication::UnicodeUTF8)
        );
        previewPushButton->setText(QApplication::translate("TablePrinterExample", "Preview", 0, QApplication::UnicodeUTF8));
        closePushButton->setText(QApplication::translate("TablePrinterExample", "Close", 0, QApplication::UnicodeUTF8));
    } // retranslateUi

};

namespace Ui {
    class TablePrinterExample: public Ui_TablePrinterExample {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_TABLEPRINTEREXAMPLE_H
