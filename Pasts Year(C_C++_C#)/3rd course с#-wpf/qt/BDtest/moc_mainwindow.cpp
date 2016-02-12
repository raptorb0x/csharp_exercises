/****************************************************************************
** Meta object code from reading C++ file 'mainwindow.hpp'
**
** Created: Mon Mar 29 13:05:55 2010
**      by: The Qt Meta Object Compiler version 62 (Qt 4.6.2)
**
** WARNING! All changes made in this file will be lost!
*****************************************************************************/

#include "mainwindow.hpp"
#if !defined(Q_MOC_OUTPUT_REVISION)
#error "The header file 'mainwindow.hpp' doesn't include <QObject>."
#elif Q_MOC_OUTPUT_REVISION != 62
#error "This file was generated using the moc from 4.6.2. It"
#error "cannot be used with the include files from this version of Qt."
#error "(The moc has changed too much.)"
#endif

QT_BEGIN_MOC_NAMESPACE
static const uint qt_meta_data_MainWindow[] = {

 // content:
       4,       // revision
       0,       // classname
       0,    0, // classinfo
      12,   14, // methods
       0,    0, // properties
       0,    0, // enums/sets
       0,    0, // constructors
       0,       // flags
       1,       // signalCount

 // signals: signature, parameters, type, tag, flags
      12,   11,   11,   11, 0x05,

 // slots: signature, parameters, type, tag, flags
      30,   11,   11,   11, 0x08,
      46,   11,   11,   11, 0x08,
      56,   11,   11,   11, 0x08,
      77,   11,   11,   11, 0x08,
      91,   11,   86,   11, 0x08,
     100,   11,   11,   11, 0x08,
     114,   11,   11,   11, 0x08,
     123,   11,   11,   11, 0x08,
     132,   11,   11,   11, 0x08,
     155,  148,   11,   11, 0x08,
     186,   11,   11,   11, 0x08,

       0        // eod
};

static const char qt_meta_stringdata_MainWindow[] = {
    "MainWindow\0\0removeConnectDB()\0"
    "AboutProgramm()\0QueryBD()\0"
    "OpenDataBaseDialog()\0CDEdit()\0bool\0"
    "OpenDB()\0deleteframe()\0addRow()\0"
    "delRow()\0CloseDataBase()\0record\0"
    "beforeInsertRowCD(QSqlRecord&)\0"
    "removeDB()\0"
};

const QMetaObject MainWindow::staticMetaObject = {
    { &QMainWindow::staticMetaObject, qt_meta_stringdata_MainWindow,
      qt_meta_data_MainWindow, 0 }
};

#ifdef Q_NO_DATA_RELOCATION
const QMetaObject &MainWindow::getStaticMetaObject() { return staticMetaObject; }
#endif //Q_NO_DATA_RELOCATION

const QMetaObject *MainWindow::metaObject() const
{
    return QObject::d_ptr->metaObject ? QObject::d_ptr->metaObject : &staticMetaObject;
}

void *MainWindow::qt_metacast(const char *_clname)
{
    if (!_clname) return 0;
    if (!strcmp(_clname, qt_meta_stringdata_MainWindow))
        return static_cast<void*>(const_cast< MainWindow*>(this));
    return QMainWindow::qt_metacast(_clname);
}

int MainWindow::qt_metacall(QMetaObject::Call _c, int _id, void **_a)
{
    _id = QMainWindow::qt_metacall(_c, _id, _a);
    if (_id < 0)
        return _id;
    if (_c == QMetaObject::InvokeMetaMethod) {
        switch (_id) {
        case 0: removeConnectDB(); break;
        case 1: AboutProgramm(); break;
        case 2: QueryBD(); break;
        case 3: OpenDataBaseDialog(); break;
        case 4: CDEdit(); break;
        case 5: { bool _r = OpenDB();
            if (_a[0]) *reinterpret_cast< bool*>(_a[0]) = _r; }  break;
        case 6: deleteframe(); break;
        case 7: addRow(); break;
        case 8: delRow(); break;
        case 9: CloseDataBase(); break;
        case 10: beforeInsertRowCD((*reinterpret_cast< QSqlRecord(*)>(_a[1]))); break;
        case 11: removeDB(); break;
        default: ;
        }
        _id -= 12;
    }
    return _id;
}

// SIGNAL 0
void MainWindow::removeConnectDB()
{
    QMetaObject::activate(this, &staticMetaObject, 0, 0);
}
QT_END_MOC_NAMESPACE
