/********************************************************************************
** Form generated from reading UI file 'cdframe.ui'
**
** Created: Sat Mar 13 01:07:01 2010
**      by: Qt User Interface Compiler version 4.6.2
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_CDFRAME_H
#define UI_CDFRAME_H

#include <QtCore/QVariant>
#include <QtGui/QAction>
#include <QtGui/QApplication>
#include <QtGui/QButtonGroup>
#include <QtGui/QDialog>
#include <QtGui/QHBoxLayout>
#include <QtGui/QHeaderView>
#include <QtGui/QPushButton>
#include <QtGui/QSpacerItem>
#include <QtGui/QTableView>
#include <QtGui/QVBoxLayout>
#include <QtGui/QWidget>

QT_BEGIN_NAMESPACE

class Ui_CDFrame
{
public:
    QWidget *widget;
    QVBoxLayout *verticalLayout;
    QTableView *tableView;
    QHBoxLayout *horizontalLayout;
    QPushButton *CommitPushButton;
    QPushButton *RollbackPushButton;
    QSpacerItem *horizontalSpacer;
    QPushButton *ClosePushButton;

    void setupUi(QDialog *CDFrame)
    {
        if (CDFrame->objectName().isEmpty())
            CDFrame->setObjectName(QString::fromUtf8("CDFrame"));
        CDFrame->resize(640, 480);
        CDFrame->setContextMenuPolicy(Qt::ActionsContextMenu);
        CDFrame->setAcceptDrops(false);
        CDFrame->setAutoFillBackground(false);
        CDFrame->setFrameShape(QDialog::Panel);
        CDFrame->setFrameShadow(QFrame::Raised);
        CDFrame->setMidLineWidth(1);
        widget = new QWidget(CDFrame);
        widget->setObjectName(QString::fromUtf8("widget"));
        widget->setGeometry(QRect(10, 10, 621, 461));
        verticalLayout = new QVBoxLayout(widget);
        verticalLayout->setObjectName(QString::fromUtf8("verticalLayout"));
        verticalLayout->setContentsMargins(0, 0, 0, 0);
        tableView = new QTableView(widget);
        tableView->setObjectName(QString::fromUtf8("tableView"));

        verticalLayout->addWidget(tableView);

        horizontalLayout = new QHBoxLayout();
        horizontalLayout->setObjectName(QString::fromUtf8("horizontalLayout"));
        CommitPushButton = new QPushButton(widget);
        CommitPushButton->setObjectName(QString::fromUtf8("CommitPushButton"));

        horizontalLayout->addWidget(CommitPushButton);

        RollbackPushButton = new QPushButton(widget);
        RollbackPushButton->setObjectName(QString::fromUtf8("RollbackPushButton"));

        horizontalLayout->addWidget(RollbackPushButton);

        horizontalSpacer = new QSpacerItem(40, 20, QSizePolicy::Expanding, QSizePolicy::Minimum);

        horizontalLayout->addItem(horizontalSpacer);

        ClosePushButton = new QPushButton(widget);
        ClosePushButton->setObjectName(QString::fromUtf8("ClosePushButton"));

        horizontalLayout->addWidget(ClosePushButton);


        verticalLayout->addLayout(horizontalLayout);


        retranslateUi(CDFrame);
        QObject::connect(ClosePushButton, SIGNAL(clicked()), CDFrame, SLOT(close()));

        QMetaObject::connectSlotsByName(CDFrame);
    } // setupUi

    void retranslateUi(QDialog *CDFrame)
    {
        CDFrame->setWindowTitle(QApplication::translate("CDFrame", "Frame", 0, QApplication::UnicodeUTF8));
        CommitPushButton->setText(QApplication::translate("CDFrame", "Commit", 0, QApplication::UnicodeUTF8));
        RollbackPushButton->setText(QApplication::translate("CDFrame", "Rollback", 0, QApplication::UnicodeUTF8));
        ClosePushButton->setText(QApplication::translate("CDFrame", "Close", 0, QApplication::UnicodeUTF8));
    } // retranslateUi

};

namespace Ui {
    class CDFrame: public Ui_CDFrame {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_CDFRAME_H
