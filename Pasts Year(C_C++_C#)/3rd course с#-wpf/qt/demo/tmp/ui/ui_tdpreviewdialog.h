/********************************************************************************
** Form generated from reading UI file 'tdpreviewdialog.ui'
**
** Created: Sun 16. May 20:06:25 2010
**      by: Qt User Interface Compiler version 4.6.2
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_TDPREVIEWDIALOG_H
#define UI_TDPREVIEWDIALOG_H

#include <QtCore/QVariant>
#include <QtGui/QAction>
#include <QtGui/QApplication>
#include <QtGui/QButtonGroup>
#include <QtGui/QDialog>
#include <QtGui/QGraphicsView>
#include <QtGui/QHBoxLayout>
#include <QtGui/QHeaderView>
#include <QtGui/QLabel>
#include <QtGui/QPushButton>
#include <QtGui/QSlider>
#include <QtGui/QSpacerItem>
#include <QtGui/QSpinBox>
#include <QtGui/QToolButton>
#include <QtGui/QVBoxLayout>

QT_BEGIN_NAMESPACE

class Ui_TDPreviewDialog
{
public:
    QVBoxLayout *vboxLayout;
    QHBoxLayout *hboxLayout;
    QToolButton *zoomInToolButton;
    QToolButton *zoomOutToolButton;
    QSpacerItem *spacerItem;
    QLabel *label;
    QSlider *horizontalSlider;
    QToolButton *prevToolButton;
    QSpinBox *pageSpinBox;
    QToolButton *nextToolButton;
    QSpacerItem *spacerItem1;
    QToolButton *setupToolButton;
    QGraphicsView *graphicsView;
    QHBoxLayout *hboxLayout1;
    QSpacerItem *spacerItem2;
    QPushButton *okPushButton;
    QPushButton *cancelPushButton;

    void setupUi(QDialog *TDPreviewDialog)
    {
        if (TDPreviewDialog->objectName().isEmpty())
            TDPreviewDialog->setObjectName(QString::fromUtf8("TDPreviewDialog"));
        TDPreviewDialog->resize(815, 745);
        vboxLayout = new QVBoxLayout(TDPreviewDialog);
        vboxLayout->setObjectName(QString::fromUtf8("vboxLayout"));
        hboxLayout = new QHBoxLayout();
        hboxLayout->setObjectName(QString::fromUtf8("hboxLayout"));
        zoomInToolButton = new QToolButton(TDPreviewDialog);
        zoomInToolButton->setObjectName(QString::fromUtf8("zoomInToolButton"));
        QIcon icon;
        icon.addFile(QString::fromUtf8(":/16x16/icons/16x16/actions/viewzoomin.png"), QSize(), QIcon::Normal, QIcon::Off);
        zoomInToolButton->setIcon(icon);

        hboxLayout->addWidget(zoomInToolButton);

        zoomOutToolButton = new QToolButton(TDPreviewDialog);
        zoomOutToolButton->setObjectName(QString::fromUtf8("zoomOutToolButton"));
        QIcon icon1;
        icon1.addFile(QString::fromUtf8(":/16x16/icons/16x16/actions/viewzoomout.png"), QSize(), QIcon::Normal, QIcon::Off);
        zoomOutToolButton->setIcon(icon1);

        hboxLayout->addWidget(zoomOutToolButton);

        spacerItem = new QSpacerItem(40, 20, QSizePolicy::Expanding, QSizePolicy::Minimum);

        hboxLayout->addItem(spacerItem);

        label = new QLabel(TDPreviewDialog);
        label->setObjectName(QString::fromUtf8("label"));

        hboxLayout->addWidget(label);

        horizontalSlider = new QSlider(TDPreviewDialog);
        horizontalSlider->setObjectName(QString::fromUtf8("horizontalSlider"));
        horizontalSlider->setMinimum(1);
        horizontalSlider->setPageStep(1);
        horizontalSlider->setValue(1);
        horizontalSlider->setTracking(false);
        horizontalSlider->setOrientation(Qt::Horizontal);
        horizontalSlider->setTickPosition(QSlider::NoTicks);
        horizontalSlider->setTickInterval(0);

        hboxLayout->addWidget(horizontalSlider);

        prevToolButton = new QToolButton(TDPreviewDialog);
        prevToolButton->setObjectName(QString::fromUtf8("prevToolButton"));
        QIcon icon2;
        icon2.addFile(QString::fromUtf8(":/16x16/icons/16x16/actions/1leftarrow.png"), QSize(), QIcon::Normal, QIcon::Off);
        prevToolButton->setIcon(icon2);

        hboxLayout->addWidget(prevToolButton);

        pageSpinBox = new QSpinBox(TDPreviewDialog);
        pageSpinBox->setObjectName(QString::fromUtf8("pageSpinBox"));
        pageSpinBox->setButtonSymbols(QAbstractSpinBox::NoButtons);
        pageSpinBox->setKeyboardTracking(false);
        pageSpinBox->setMinimum(1);

        hboxLayout->addWidget(pageSpinBox);

        nextToolButton = new QToolButton(TDPreviewDialog);
        nextToolButton->setObjectName(QString::fromUtf8("nextToolButton"));
        QIcon icon3;
        icon3.addFile(QString::fromUtf8(":/16x16/icons/16x16/actions/1rightarrow.png"), QSize(), QIcon::Normal, QIcon::Off);
        nextToolButton->setIcon(icon3);

        hboxLayout->addWidget(nextToolButton);

        spacerItem1 = new QSpacerItem(40, 20, QSizePolicy::Expanding, QSizePolicy::Minimum);

        hboxLayout->addItem(spacerItem1);

        setupToolButton = new QToolButton(TDPreviewDialog);
        setupToolButton->setObjectName(QString::fromUtf8("setupToolButton"));
        QIcon icon4;
        icon4.addFile(QString::fromUtf8(":/16x16/icons/16x16/actions/configure.png"), QSize(), QIcon::Normal, QIcon::Off);
        setupToolButton->setIcon(icon4);

        hboxLayout->addWidget(setupToolButton);


        vboxLayout->addLayout(hboxLayout);

        graphicsView = new QGraphicsView(TDPreviewDialog);
        graphicsView->setObjectName(QString::fromUtf8("graphicsView"));
        graphicsView->setRenderHints(QPainter::TextAntialiasing);
        graphicsView->setDragMode(QGraphicsView::ScrollHandDrag);

        vboxLayout->addWidget(graphicsView);

        hboxLayout1 = new QHBoxLayout();
        hboxLayout1->setObjectName(QString::fromUtf8("hboxLayout1"));
        spacerItem2 = new QSpacerItem(40, 20, QSizePolicy::Expanding, QSizePolicy::Minimum);

        hboxLayout1->addItem(spacerItem2);

        okPushButton = new QPushButton(TDPreviewDialog);
        okPushButton->setObjectName(QString::fromUtf8("okPushButton"));
        QIcon icon5;
        icon5.addFile(QString::fromUtf8(":/16x16/icons/16x16/actions/ok.png"), QSize(), QIcon::Normal, QIcon::Off);
        okPushButton->setIcon(icon5);

        hboxLayout1->addWidget(okPushButton);

        cancelPushButton = new QPushButton(TDPreviewDialog);
        cancelPushButton->setObjectName(QString::fromUtf8("cancelPushButton"));
        QIcon icon6;
        icon6.addFile(QString::fromUtf8(":/16x16/icons/16x16/actions/button_cancel.png"), QSize(), QIcon::Normal, QIcon::Off);
        cancelPushButton->setIcon(icon6);

        hboxLayout1->addWidget(cancelPushButton);


        vboxLayout->addLayout(hboxLayout1);

        QWidget::setTabOrder(okPushButton, cancelPushButton);
        QWidget::setTabOrder(cancelPushButton, zoomInToolButton);
        QWidget::setTabOrder(zoomInToolButton, zoomOutToolButton);
        QWidget::setTabOrder(zoomOutToolButton, setupToolButton);

        retranslateUi(TDPreviewDialog);
        QObject::connect(cancelPushButton, SIGNAL(clicked()), TDPreviewDialog, SLOT(reject()));
        QObject::connect(okPushButton, SIGNAL(clicked()), TDPreviewDialog, SLOT(accept()));
        QObject::connect(pageSpinBox, SIGNAL(valueChanged(int)), horizontalSlider, SLOT(setValue(int)));

        QMetaObject::connectSlotsByName(TDPreviewDialog);
    } // setupUi

    void retranslateUi(QDialog *TDPreviewDialog)
    {
        TDPreviewDialog->setWindowTitle(QApplication::translate("TDPreviewDialog", "Dialog", 0, QApplication::UnicodeUTF8));
#ifndef QT_NO_TOOLTIP
        zoomInToolButton->setToolTip(QApplication::translate("TDPreviewDialog", "Zoom in", 0, QApplication::UnicodeUTF8));
#endif // QT_NO_TOOLTIP
        zoomInToolButton->setText(QApplication::translate("TDPreviewDialog", "...", 0, QApplication::UnicodeUTF8));
#ifndef QT_NO_TOOLTIP
        zoomOutToolButton->setToolTip(QApplication::translate("TDPreviewDialog", "Zoom Out", 0, QApplication::UnicodeUTF8));
#endif // QT_NO_TOOLTIP
        zoomOutToolButton->setText(QApplication::translate("TDPreviewDialog", "...", 0, QApplication::UnicodeUTF8));
        label->setText(QApplication::translate("TDPreviewDialog", "Page", 0, QApplication::UnicodeUTF8));
#ifndef QT_NO_TOOLTIP
        horizontalSlider->setToolTip(QApplication::translate("TDPreviewDialog", "Select Page", 0, QApplication::UnicodeUTF8));
#endif // QT_NO_TOOLTIP
#ifndef QT_NO_TOOLTIP
        prevToolButton->setToolTip(QApplication::translate("TDPreviewDialog", "Previous Page", 0, QApplication::UnicodeUTF8));
#endif // QT_NO_TOOLTIP
        prevToolButton->setText(QApplication::translate("TDPreviewDialog", "<", 0, QApplication::UnicodeUTF8));
#ifndef QT_NO_TOOLTIP
        pageSpinBox->setToolTip(QApplication::translate("TDPreviewDialog", "Type page number here", 0, QApplication::UnicodeUTF8));
#endif // QT_NO_TOOLTIP
#ifndef QT_NO_TOOLTIP
        nextToolButton->setToolTip(QApplication::translate("TDPreviewDialog", "Next Page", 0, QApplication::UnicodeUTF8));
#endif // QT_NO_TOOLTIP
        nextToolButton->setText(QApplication::translate("TDPreviewDialog", ">", 0, QApplication::UnicodeUTF8));
#ifndef QT_NO_TOOLTIP
        setupToolButton->setToolTip(QApplication::translate("TDPreviewDialog", "Page Settings", 0, QApplication::UnicodeUTF8));
#endif // QT_NO_TOOLTIP
        setupToolButton->setText(QApplication::translate("TDPreviewDialog", "...", 0, QApplication::UnicodeUTF8));
#ifndef QT_NO_TOOLTIP
        okPushButton->setToolTip(QApplication::translate("TDPreviewDialog", "Print Document", 0, QApplication::UnicodeUTF8));
#endif // QT_NO_TOOLTIP
        okPushButton->setText(QApplication::translate("TDPreviewDialog", "&Ok", 0, QApplication::UnicodeUTF8));
#ifndef QT_NO_TOOLTIP
        cancelPushButton->setToolTip(QApplication::translate("TDPreviewDialog", "Cancel", 0, QApplication::UnicodeUTF8));
#endif // QT_NO_TOOLTIP
        cancelPushButton->setText(QApplication::translate("TDPreviewDialog", "&Cancel", 0, QApplication::UnicodeUTF8));
    } // retranslateUi

};

namespace Ui {
    class TDPreviewDialog: public Ui_TDPreviewDialog {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_TDPREVIEWDIALOG_H
