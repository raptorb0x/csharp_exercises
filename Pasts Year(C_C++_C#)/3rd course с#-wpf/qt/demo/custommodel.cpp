/*
  создаем наполнение для tableview
  */
#include <QtGui>
#include <QtCore/QDate>
#include <QtCore/QVariant>
#include "custommodel.h"

CustomModel::CustomModel(QObject *parent) : QAbstractTableModel(parent)
{
}

//======================================================================

QVariant CustomModel::data(const QModelIndex &index, int role) const
{
	if (role!=Qt::DisplayRole )
	{
		return QVariant();
	}
	
        QVariant value;
        QDate ret = QDate::currentDate();
        if (index.column() == 0) {
		ret=ret.addDays(index.row());
                value= ret.toString();
		return value;
        }

        if (index.column() == 1) {
                ret=ret.addDays(index.row());
                value= QDate::longMonthName(ret.month());
                return value;
        }

        if (index.column() == 2) {
		ret=ret.addDays(index.row());
                value= QDate::longDayName(ret.dayOfWeek());
                return value;
        }
        return value;
}

//======================================================================

int CustomModel::rowCount(const QModelIndex & /*parent*/) const
{
        return 200;
}

//======================================================================

int CustomModel::columnCount(const QModelIndex & /*parent*/) const
{
        return 3;
}
