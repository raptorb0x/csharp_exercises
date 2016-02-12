
#ifndef CUSTOMSQLMODEL_H
#define CUSTOMSQLMODEL_H

#include <QAbstractTableModel>

class CustomModel : public QAbstractTableModel
{
        Q_OBJECT

public:
        CustomModel(QObject *parent = 0);

        QVariant data(const QModelIndex &item, int role) const;
        int rowCount(const QModelIndex &parent = QModelIndex()) const;
        int columnCount(const QModelIndex &parent = QModelIndex()) const;
private:
};

#endif
