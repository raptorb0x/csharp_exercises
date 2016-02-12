/********************************************************************************
** Form generated from reading UI file 'tdtableprinter.ui'
**
** Created: Mon 17. May 21:30:23 2010
**      by: Qt User Interface Compiler version 4.6.2
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_TDTABLEPRINTER_H
#define UI_TDTABLEPRINTER_H

#include <QtCore/QVariant>
#include <QtGui/QAction>
#include <QtGui/QApplication>
#include <QtGui/QButtonGroup>
#include <QtGui/QCheckBox>
#include <QtGui/QComboBox>
#include <QtGui/QDialog>
#include <QtGui/QFrame>
#include <QtGui/QGridLayout>
#include <QtGui/QGroupBox>
#include <QtGui/QHBoxLayout>
#include <QtGui/QHeaderView>
#include <QtGui/QLabel>
#include <QtGui/QLineEdit>
#include <QtGui/QPushButton>
#include <QtGui/QRadioButton>
#include <QtGui/QSpacerItem>
#include <QtGui/QSpinBox>
#include <QtGui/QStackedWidget>
#include <QtGui/QVBoxLayout>
#include <QtGui/QWidget>

QT_BEGIN_NAMESPACE

class Ui_TDTablePrinter
{
public:
    QGridLayout *gridLayout;
    QGroupBox *gbDestination;
    QVBoxLayout *vboxLayout;
    QStackedWidget *stackedWidget;
    QWidget *page;
    QVBoxLayout *vboxLayout1;
    QHBoxLayout *hboxLayout;
    QComboBox *cbPrinters;
    QPushButton *btnProperties;
    QHBoxLayout *hboxLayout1;
    QLabel *label_6;
    QLabel *lbPrinterInfo;
    QWidget *page_2;
    QVBoxLayout *vboxLayout2;
    QHBoxLayout *hboxLayout2;
    QLineEdit *leFile;
    QPushButton *btnBrowse;
    QFrame *line;
    QCheckBox *chbPrintToFile;
    QGroupBox *gbPrintRange;
    QVBoxLayout *vboxLayout3;
    QRadioButton *rbPrintAll;
    QHBoxLayout *hboxLayout3;
    QRadioButton *rbPrintRange;
    QSpinBox *sbFrom;
    QLabel *label_3;
    QSpinBox *sbTo;
    QSpacerItem *spacerItem;
    QRadioButton *rbPrintSelection;
    QGroupBox *gbCopies;
    QVBoxLayout *vboxLayout4;
    QHBoxLayout *hboxLayout4;
    QLabel *label_8;
    QSpinBox *sbNumCopies;
    QSpacerItem *spacerItem1;
    QCheckBox *chbCollate;
    QCheckBox *chbPrintLastFirst;
    QGroupBox *gbPageProperties;
    QGridLayout *gridLayout1;
    QLabel *label_4;
    QLabel *label_5;
    QComboBox *cbPaperLayout;
    QComboBox *cbPaperSize;
    QGroupBox *gbOther;
    QVBoxLayout *vboxLayout5;
    QCheckBox *chbColor;
    QCheckBox *chbDuplex;
    QSpacerItem *spacerItem2;
    QHBoxLayout *hboxLayout5;
    QSpacerItem *spacerItem3;
    QHBoxLayout *hboxLayout6;
    QPushButton *printPushButton;
    QPushButton *previewPushButton;
    QPushButton *cancelPushButton;

    void setupUi(QDialog *TDTablePrinter)
    {
        if (TDTablePrinter->objectName().isEmpty())
            TDTablePrinter->setObjectName(QString::fromUtf8("TDTablePrinter"));
        TDTablePrinter->resize(409, 396);
        gridLayout = new QGridLayout(TDTablePrinter);
        gridLayout->setObjectName(QString::fromUtf8("gridLayout"));
        gbDestination = new QGroupBox(TDTablePrinter);
        gbDestination->setObjectName(QString::fromUtf8("gbDestination"));
        QSizePolicy sizePolicy(QSizePolicy::Preferred, QSizePolicy::Minimum);
        sizePolicy.setHorizontalStretch(0);
        sizePolicy.setVerticalStretch(0);
        sizePolicy.setHeightForWidth(gbDestination->sizePolicy().hasHeightForWidth());
        gbDestination->setSizePolicy(sizePolicy);
        vboxLayout = new QVBoxLayout(gbDestination);
        vboxLayout->setSpacing(6);
        vboxLayout->setObjectName(QString::fromUtf8("vboxLayout"));
        vboxLayout->setContentsMargins(9, 9, 9, 9);
        stackedWidget = new QStackedWidget(gbDestination);
        stackedWidget->setObjectName(QString::fromUtf8("stackedWidget"));
        sizePolicy.setHeightForWidth(stackedWidget->sizePolicy().hasHeightForWidth());
        stackedWidget->setSizePolicy(sizePolicy);
        page = new QWidget();
        page->setObjectName(QString::fromUtf8("page"));
        vboxLayout1 = new QVBoxLayout(page);
        vboxLayout1->setSpacing(6);
        vboxLayout1->setObjectName(QString::fromUtf8("vboxLayout1"));
        vboxLayout1->setContentsMargins(0, 0, 0, 0);
        hboxLayout = new QHBoxLayout();
        hboxLayout->setSpacing(6);
        hboxLayout->setObjectName(QString::fromUtf8("hboxLayout"));
        hboxLayout->setContentsMargins(0, 0, 0, 0);
        cbPrinters = new QComboBox(page);
        cbPrinters->setObjectName(QString::fromUtf8("cbPrinters"));
        QSizePolicy sizePolicy1(QSizePolicy::Expanding, QSizePolicy::Minimum);
        sizePolicy1.setHorizontalStretch(0);
        sizePolicy1.setVerticalStretch(0);
        sizePolicy1.setHeightForWidth(cbPrinters->sizePolicy().hasHeightForWidth());
        cbPrinters->setSizePolicy(sizePolicy1);

        hboxLayout->addWidget(cbPrinters);

        btnProperties = new QPushButton(page);
        btnProperties->setObjectName(QString::fromUtf8("btnProperties"));
        btnProperties->setEnabled(false);
        QSizePolicy sizePolicy2(QSizePolicy::Minimum, QSizePolicy::Minimum);
        sizePolicy2.setHorizontalStretch(0);
        sizePolicy2.setVerticalStretch(0);
        sizePolicy2.setHeightForWidth(btnProperties->sizePolicy().hasHeightForWidth());
        btnProperties->setSizePolicy(sizePolicy2);
        const QIcon icon = QIcon(QString::fromUtf8(":/16x16/icons/16x16/actions/configure.png"));
        btnProperties->setIcon(icon);

        hboxLayout->addWidget(btnProperties);


        vboxLayout1->addLayout(hboxLayout);

        hboxLayout1 = new QHBoxLayout();
        hboxLayout1->setSpacing(6);
        hboxLayout1->setObjectName(QString::fromUtf8("hboxLayout1"));
        hboxLayout1->setContentsMargins(0, 0, 0, 0);
        label_6 = new QLabel(page);
        label_6->setObjectName(QString::fromUtf8("label_6"));

        hboxLayout1->addWidget(label_6);

        lbPrinterInfo = new QLabel(page);
        lbPrinterInfo->setObjectName(QString::fromUtf8("lbPrinterInfo"));
        QSizePolicy sizePolicy3(QSizePolicy::MinimumExpanding, QSizePolicy::Preferred);
        sizePolicy3.setHorizontalStretch(0);
        sizePolicy3.setVerticalStretch(0);
        sizePolicy3.setHeightForWidth(lbPrinterInfo->sizePolicy().hasHeightForWidth());
        lbPrinterInfo->setSizePolicy(sizePolicy3);

        hboxLayout1->addWidget(lbPrinterInfo);


        vboxLayout1->addLayout(hboxLayout1);

        stackedWidget->addWidget(page);
        page_2 = new QWidget();
        page_2->setObjectName(QString::fromUtf8("page_2"));
        vboxLayout2 = new QVBoxLayout(page_2);
        vboxLayout2->setSpacing(6);
        vboxLayout2->setObjectName(QString::fromUtf8("vboxLayout2"));
        vboxLayout2->setContentsMargins(0, 0, 0, 0);
        hboxLayout2 = new QHBoxLayout();
        hboxLayout2->setSpacing(6);
        hboxLayout2->setObjectName(QString::fromUtf8("hboxLayout2"));
        hboxLayout2->setContentsMargins(0, 0, 0, 0);
        leFile = new QLineEdit(page_2);
        leFile->setObjectName(QString::fromUtf8("leFile"));
        leFile->setEnabled(true);
        QSizePolicy sizePolicy4(QSizePolicy::Expanding, QSizePolicy::Preferred);
        sizePolicy4.setHorizontalStretch(0);
        sizePolicy4.setVerticalStretch(0);
        sizePolicy4.setHeightForWidth(leFile->sizePolicy().hasHeightForWidth());
        leFile->setSizePolicy(sizePolicy4);

        hboxLayout2->addWidget(leFile);

        btnBrowse = new QPushButton(page_2);
        btnBrowse->setObjectName(QString::fromUtf8("btnBrowse"));
        btnBrowse->setEnabled(true);
        const QIcon icon1 = QIcon(QString::fromUtf8(":/16x16/icons/16x16/actions/fileopen.png"));
        btnBrowse->setIcon(icon1);

        hboxLayout2->addWidget(btnBrowse);


        vboxLayout2->addLayout(hboxLayout2);

        stackedWidget->addWidget(page_2);

        vboxLayout->addWidget(stackedWidget);

        line = new QFrame(gbDestination);
        line->setObjectName(QString::fromUtf8("line"));
        line->setFrameShape(QFrame::HLine);
        line->setFrameShadow(QFrame::Sunken);

        vboxLayout->addWidget(line);

        chbPrintToFile = new QCheckBox(gbDestination);
        chbPrintToFile->setObjectName(QString::fromUtf8("chbPrintToFile"));

        vboxLayout->addWidget(chbPrintToFile);


        gridLayout->addWidget(gbDestination, 0, 0, 1, 2);

        gbPrintRange = new QGroupBox(TDTablePrinter);
        gbPrintRange->setObjectName(QString::fromUtf8("gbPrintRange"));
        sizePolicy.setHeightForWidth(gbPrintRange->sizePolicy().hasHeightForWidth());
        gbPrintRange->setSizePolicy(sizePolicy);
        vboxLayout3 = new QVBoxLayout(gbPrintRange);
        vboxLayout3->setSpacing(4);
        vboxLayout3->setObjectName(QString::fromUtf8("vboxLayout3"));
        vboxLayout3->setContentsMargins(6, 6, 6, 6);
        rbPrintAll = new QRadioButton(gbPrintRange);
        rbPrintAll->setObjectName(QString::fromUtf8("rbPrintAll"));
        rbPrintAll->setChecked(true);

        vboxLayout3->addWidget(rbPrintAll);

        hboxLayout3 = new QHBoxLayout();
        hboxLayout3->setSpacing(6);
        hboxLayout3->setObjectName(QString::fromUtf8("hboxLayout3"));
        hboxLayout3->setContentsMargins(0, 0, 0, 0);
        rbPrintRange = new QRadioButton(gbPrintRange);
        rbPrintRange->setObjectName(QString::fromUtf8("rbPrintRange"));

        hboxLayout3->addWidget(rbPrintRange);

        sbFrom = new QSpinBox(gbPrintRange);
        sbFrom->setObjectName(QString::fromUtf8("sbFrom"));
        sbFrom->setEnabled(false);

        hboxLayout3->addWidget(sbFrom);

        label_3 = new QLabel(gbPrintRange);
        label_3->setObjectName(QString::fromUtf8("label_3"));

        hboxLayout3->addWidget(label_3);

        sbTo = new QSpinBox(gbPrintRange);
        sbTo->setObjectName(QString::fromUtf8("sbTo"));
        sbTo->setEnabled(false);

        hboxLayout3->addWidget(sbTo);

        spacerItem = new QSpacerItem(0, 20, QSizePolicy::Expanding, QSizePolicy::Minimum);

        hboxLayout3->addItem(spacerItem);


        vboxLayout3->addLayout(hboxLayout3);

        rbPrintSelection = new QRadioButton(gbPrintRange);
        rbPrintSelection->setObjectName(QString::fromUtf8("rbPrintSelection"));

        vboxLayout3->addWidget(rbPrintSelection);


        gridLayout->addWidget(gbPrintRange, 1, 0, 1, 1);

        gbCopies = new QGroupBox(TDTablePrinter);
        gbCopies->setObjectName(QString::fromUtf8("gbCopies"));
        sizePolicy2.setHeightForWidth(gbCopies->sizePolicy().hasHeightForWidth());
        gbCopies->setSizePolicy(sizePolicy2);
        vboxLayout4 = new QVBoxLayout(gbCopies);
        vboxLayout4->setSpacing(6);
        vboxLayout4->setObjectName(QString::fromUtf8("vboxLayout4"));
        vboxLayout4->setContentsMargins(9, 9, 9, 9);
        hboxLayout4 = new QHBoxLayout();
        hboxLayout4->setSpacing(6);
        hboxLayout4->setObjectName(QString::fromUtf8("hboxLayout4"));
        hboxLayout4->setContentsMargins(0, 0, 0, 0);
        label_8 = new QLabel(gbCopies);
        label_8->setObjectName(QString::fromUtf8("label_8"));

        hboxLayout4->addWidget(label_8);

        sbNumCopies = new QSpinBox(gbCopies);
        sbNumCopies->setObjectName(QString::fromUtf8("sbNumCopies"));
        sbNumCopies->setMinimum(1);
        sbNumCopies->setMaximum(999);
        sbNumCopies->setValue(1);

        hboxLayout4->addWidget(sbNumCopies);

        spacerItem1 = new QSpacerItem(0, 20, QSizePolicy::Expanding, QSizePolicy::Minimum);

        hboxLayout4->addItem(spacerItem1);


        vboxLayout4->addLayout(hboxLayout4);

        chbCollate = new QCheckBox(gbCopies);
        chbCollate->setObjectName(QString::fromUtf8("chbCollate"));

        vboxLayout4->addWidget(chbCollate);

        chbPrintLastFirst = new QCheckBox(gbCopies);
        chbPrintLastFirst->setObjectName(QString::fromUtf8("chbPrintLastFirst"));

        vboxLayout4->addWidget(chbPrintLastFirst);


        gridLayout->addWidget(gbCopies, 1, 1, 1, 1);

        gbPageProperties = new QGroupBox(TDTablePrinter);
        gbPageProperties->setObjectName(QString::fromUtf8("gbPageProperties"));
        gridLayout1 = new QGridLayout(gbPageProperties);
        gridLayout1->setObjectName(QString::fromUtf8("gridLayout1"));
        gridLayout1->setHorizontalSpacing(6);
        gridLayout1->setVerticalSpacing(6);
        gridLayout1->setContentsMargins(9, 9, 9, 9);
        label_4 = new QLabel(gbPageProperties);
        label_4->setObjectName(QString::fromUtf8("label_4"));

        gridLayout1->addWidget(label_4, 1, 0, 1, 1);

        label_5 = new QLabel(gbPageProperties);
        label_5->setObjectName(QString::fromUtf8("label_5"));

        gridLayout1->addWidget(label_5, 0, 0, 1, 1);

        cbPaperLayout = new QComboBox(gbPageProperties);
        cbPaperLayout->setObjectName(QString::fromUtf8("cbPaperLayout"));
        QSizePolicy sizePolicy5(QSizePolicy::Expanding, QSizePolicy::Fixed);
        sizePolicy5.setHorizontalStretch(0);
        sizePolicy5.setVerticalStretch(0);
        sizePolicy5.setHeightForWidth(cbPaperLayout->sizePolicy().hasHeightForWidth());
        cbPaperLayout->setSizePolicy(sizePolicy5);

        gridLayout1->addWidget(cbPaperLayout, 0, 1, 1, 1);

        cbPaperSize = new QComboBox(gbPageProperties);
        cbPaperSize->setObjectName(QString::fromUtf8("cbPaperSize"));
        sizePolicy5.setHeightForWidth(cbPaperSize->sizePolicy().hasHeightForWidth());
        cbPaperSize->setSizePolicy(sizePolicy5);

        gridLayout1->addWidget(cbPaperSize, 1, 1, 1, 1);


        gridLayout->addWidget(gbPageProperties, 2, 0, 1, 1);

        gbOther = new QGroupBox(TDTablePrinter);
        gbOther->setObjectName(QString::fromUtf8("gbOther"));
        QSizePolicy sizePolicy6(QSizePolicy::Minimum, QSizePolicy::Preferred);
        sizePolicy6.setHorizontalStretch(0);
        sizePolicy6.setVerticalStretch(0);
        sizePolicy6.setHeightForWidth(gbOther->sizePolicy().hasHeightForWidth());
        gbOther->setSizePolicy(sizePolicy6);
        vboxLayout5 = new QVBoxLayout(gbOther);
        vboxLayout5->setSpacing(6);
        vboxLayout5->setObjectName(QString::fromUtf8("vboxLayout5"));
        vboxLayout5->setContentsMargins(9, 9, 9, 9);
        chbColor = new QCheckBox(gbOther);
        chbColor->setObjectName(QString::fromUtf8("chbColor"));
        chbColor->setChecked(true);

        vboxLayout5->addWidget(chbColor);

        chbDuplex = new QCheckBox(gbOther);
        chbDuplex->setObjectName(QString::fromUtf8("chbDuplex"));

        vboxLayout5->addWidget(chbDuplex);


        gridLayout->addWidget(gbOther, 2, 1, 1, 1);

        spacerItem2 = new QSpacerItem(391, 16, QSizePolicy::Minimum, QSizePolicy::Expanding);

        gridLayout->addItem(spacerItem2, 3, 0, 1, 2);

        hboxLayout5 = new QHBoxLayout();
        hboxLayout5->setObjectName(QString::fromUtf8("hboxLayout5"));
        spacerItem3 = new QSpacerItem(40, 20, QSizePolicy::Expanding, QSizePolicy::Minimum);

        hboxLayout5->addItem(spacerItem3);

        hboxLayout6 = new QHBoxLayout();
        hboxLayout6->setObjectName(QString::fromUtf8("hboxLayout6"));
        printPushButton = new QPushButton(TDTablePrinter);
        printPushButton->setObjectName(QString::fromUtf8("printPushButton"));
        const QIcon icon2 = QIcon(QString::fromUtf8(":/16x16/icons/16x16/actions/fileprint.png"));
        printPushButton->setIcon(icon2);

        hboxLayout6->addWidget(printPushButton);

        previewPushButton = new QPushButton(TDTablePrinter);
        previewPushButton->setObjectName(QString::fromUtf8("previewPushButton"));
        const QIcon icon3 = QIcon(QString::fromUtf8(":/16x16/icons/16x16/actions/preview.png"));
        previewPushButton->setIcon(icon3);

        hboxLayout6->addWidget(previewPushButton);

        cancelPushButton = new QPushButton(TDTablePrinter);
        cancelPushButton->setObjectName(QString::fromUtf8("cancelPushButton"));
        const QIcon icon4 = QIcon(QString::fromUtf8(":/16x16/icons/16x16/actions/button_cancel.png"));
        cancelPushButton->setIcon(icon4);

        hboxLayout6->addWidget(cancelPushButton);


        hboxLayout5->addLayout(hboxLayout6);


        gridLayout->addLayout(hboxLayout5, 4, 0, 1, 2);

        QWidget::setTabOrder(printPushButton, previewPushButton);
        QWidget::setTabOrder(previewPushButton, cancelPushButton);

        retranslateUi(TDTablePrinter);
        QObject::connect(cancelPushButton, SIGNAL(clicked()), TDTablePrinter, SLOT(reject()));

        stackedWidget->setCurrentIndex(1);


        QMetaObject::connectSlotsByName(TDTablePrinter);
    } // setupUi

    void retranslateUi(QDialog *TDTablePrinter)
    {
        TDTablePrinter->setWindowTitle(QApplication::translate("TDTablePrinter", "Printing...", 0, QApplication::UnicodeUTF8));
        gbDestination->setTitle(QApplication::translate("TDTablePrinter", "Printer", 0, QApplication::UnicodeUTF8));
        btnProperties->setText(QApplication::translate("TDTablePrinter", "Properties", 0, QApplication::UnicodeUTF8));
        label_6->setText(QApplication::translate("TDTablePrinter", "Printer info:", 0, QApplication::UnicodeUTF8));
        lbPrinterInfo->setText(QString());
        btnBrowse->setText(QApplication::translate("TDTablePrinter", "Browse", 0, QApplication::UnicodeUTF8));
        chbPrintToFile->setText(QApplication::translate("TDTablePrinter", "Print to PDF file", 0, QApplication::UnicodeUTF8));
        gbPrintRange->setTitle(QApplication::translate("TDTablePrinter", "Print range", 0, QApplication::UnicodeUTF8));
        rbPrintAll->setText(QApplication::translate("TDTablePrinter", "Print all", 0, QApplication::UnicodeUTF8));
        rbPrintRange->setText(QApplication::translate("TDTablePrinter", "Pages from", 0, QApplication::UnicodeUTF8));
        label_3->setText(QApplication::translate("TDTablePrinter", "to", 0, QApplication::UnicodeUTF8));
        rbPrintSelection->setText(QApplication::translate("TDTablePrinter", "Selection", 0, QApplication::UnicodeUTF8));
        gbCopies->setTitle(QApplication::translate("TDTablePrinter", "Copies", 0, QApplication::UnicodeUTF8));
        label_8->setText(QApplication::translate("TDTablePrinter", "Number of copies:", 0, QApplication::UnicodeUTF8));
        chbCollate->setText(QApplication::translate("TDTablePrinter", "Collate", 0, QApplication::UnicodeUTF8));
        chbPrintLastFirst->setText(QApplication::translate("TDTablePrinter", "Print last page first", 0, QApplication::UnicodeUTF8));
        gbPageProperties->setTitle(QApplication::translate("TDTablePrinter", "Paper format", 0, QApplication::UnicodeUTF8));
        label_4->setText(QApplication::translate("TDTablePrinter", "Size:", 0, QApplication::UnicodeUTF8));
        label_5->setText(QApplication::translate("TDTablePrinter", "Orientation:", 0, QApplication::UnicodeUTF8));
        gbOther->setTitle(QApplication::translate("TDTablePrinter", "Other", 0, QApplication::UnicodeUTF8));
        chbColor->setText(QApplication::translate("TDTablePrinter", "Print in color if available", 0, QApplication::UnicodeUTF8));
        chbDuplex->setText(QApplication::translate("TDTablePrinter", "Double side printing", 0, QApplication::UnicodeUTF8));
#ifndef QT_NO_TOOLTIP
        printPushButton->setToolTip(QApplication::translate("TDTablePrinter", "Print Document", 0, QApplication::UnicodeUTF8));
#endif // QT_NO_TOOLTIP
        printPushButton->setText(QApplication::translate("TDTablePrinter", "&Print", 0, QApplication::UnicodeUTF8));
#ifndef QT_NO_TOOLTIP
        previewPushButton->setToolTip(QApplication::translate("TDTablePrinter", "Preview Document", 0, QApplication::UnicodeUTF8));
#endif // QT_NO_TOOLTIP
        previewPushButton->setText(QApplication::translate("TDTablePrinter", "Pre&view", 0, QApplication::UnicodeUTF8));
#ifndef QT_NO_TOOLTIP
        cancelPushButton->setToolTip(QApplication::translate("TDTablePrinter", "Cancel", 0, QApplication::UnicodeUTF8));
#endif // QT_NO_TOOLTIP
        cancelPushButton->setText(QApplication::translate("TDTablePrinter", "&Cancel", 0, QApplication::UnicodeUTF8));
    } // retranslateUi

};

namespace Ui {
    class TDTablePrinter: public Ui_TDTablePrinter {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_TDTABLEPRINTER_H
