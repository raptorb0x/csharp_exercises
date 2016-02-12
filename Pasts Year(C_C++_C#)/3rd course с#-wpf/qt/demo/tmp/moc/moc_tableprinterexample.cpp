/****************************************************************************
** Meta object code from reading C++ file 'tableprinterexample.h'
**
** Created: Tue 25. May 22:35:55 2010
**      by: The Qt Meta Object Compiler version 62 (Qt 4.6.2)
**
** WARNING! All changes made in this file will be lost!
*****************************************************************************/

#include "../../tableprinterexample.h"
#if !defined(Q_MOC_OUTPUT_REVISION)
#error "The header file 'tableprinterexample.h' doesn't include <QObject>."
#elif Q_MOC_OUTPUT_REVISION != 62
#error "This file was generated using the moc from 4.6.2. It"
#error "cannot be used with the include files from this version of Qt."
#error "(The moc has changed too much.)"
#endif

QT_BEGIN_MOC_NAMESPACE
static const uint qt_meta_data_TablePrinterExample[] = {

 // content:
       4,       // revision
       0,       // classname
       0,    0, // classinfo
       3,   14, // methods
       0,    0, // properties
       0,    0, // enums/sets
       0,    0, // constructors
       0,       // flags
       0,       // signalCount

 // slots: signature, parameters, type, tag, flags
      21,   20,   20,   20, 0x08,
      50,   20,   20,   20, 0x08,
      87,   81,   20,   20, 0x08,

       0        // eod
};

static const char qt_meta_stringdata_TablePrinterExample[] = {
    "TablePrinterExample\0\0on_printPushButton_clicked()\0"
    "on_previewPushButton_clicked()\0index\0"
    "on_comboBox_currentIndexChanged(int)\0"
};

const QMetaObject TablePrinterExample::staticMetaObject = {
    { &QWidget::staticMetaObject, qt_meta_stringdata_TablePrinterExample,
      qt_meta_data_TablePrinterExample, 0 }
};

#ifdef Q_NO_DATA_RELOCATION
const QMetaObject &TablePrinterExample::getStaticMetaObject() { return staticMetaObject; }
#endif //Q_NO_DATA_RELOCATION

const QMetaObject *TablePrinterExample::metaObject() const
{
    return QObject::d_ptr->metaObject ? QObject::d_ptr->metaObject : &staticMetaObject;
}

void *TablePrinterExample::qt_metacast(const char *_clname)
{
    if (!_clname) return 0;
    if (!strcmp(_clname, qt_meta_stringdata_TablePrinterExample))
        return static_cast<void*>(const_cast< TablePrinterExample*>(this));
    return QWidget::qt_metacast(_clname);
}

int TablePrinterExample::qt_metacall(QMetaObject::Call _c, int _id, void **_a)
{
    _id = QWidget::qt_metacall(_c, _id, _a);
    if (_id < 0)
        return _id;
    if (_c == QMetaObject::InvokeMetaMethod) {
        switch (_id) {
        case 0: on_printPushButton_clicked(); break;
        case 1: on_previewPushButton_clicked(); break;
        case 2: on_comboBox_currentIndexChanged((*reinterpret_cast< int(*)>(_a[1]))); break;
        default: ;
        }
        _id -= 3;
    }
    return _id;
}
QT_END_MOC_NAMESPACE
