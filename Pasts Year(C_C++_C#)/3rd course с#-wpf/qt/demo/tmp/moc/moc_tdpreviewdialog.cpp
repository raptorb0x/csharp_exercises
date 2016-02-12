/****************************************************************************
** Meta object code from reading C++ file 'tdpreviewdialog.h'
**
** Created: Sun 16. May 20:06:40 2010
**      by: The Qt Meta Object Compiler version 62 (Qt 4.6.2)
**
** WARNING! All changes made in this file will be lost!
*****************************************************************************/

#include "../../../src/tdpreviewdialog.h"
#if !defined(Q_MOC_OUTPUT_REVISION)
#error "The header file 'tdpreviewdialog.h' doesn't include <QObject>."
#elif Q_MOC_OUTPUT_REVISION != 62
#error "This file was generated using the moc from 4.6.2. It"
#error "cannot be used with the include files from this version of Qt."
#error "(The moc has changed too much.)"
#endif

QT_BEGIN_MOC_NAMESPACE
static const uint qt_meta_data_TDPreviewDialog[] = {

 // content:
       4,       // revision
       0,       // classname
       0,    0, // classinfo
       4,   14, // methods
       0,    0, // properties
       1,   34, // enums/sets
       0,    0, // constructors
       0,       // flags
       0,       // signalCount

 // slots: signature, parameters, type, tag, flags
      17,   16,   16,   16, 0x08,
      46,   16,   16,   16, 0x08,
      76,   16,   16,   16, 0x08,
     113,  107,   16,   16, 0x08,

 // enums: name, flags, count, data
     146, 0x0,    4,   38,

 // enum data: key, value
     152, uint(TDPreviewDialog::NoGrid),
     159, uint(TDPreviewDialog::NormalGrid),
     170, uint(TDPreviewDialog::AlternateColor),
     185, uint(TDPreviewDialog::AlternateWithGrid),

       0        // eod
};

static const char qt_meta_stringdata_TDPreviewDialog[] = {
    "TDPreviewDialog\0\0on_setupToolButton_clicked()\0"
    "on_zoomInToolButton_clicked()\0"
    "on_zoomOutToolButton_clicked()\0value\0"
    "on_pageSpinBox_valueChanged(int)\0Grids\0"
    "NoGrid\0NormalGrid\0AlternateColor\0"
    "AlternateWithGrid\0"
};

const QMetaObject TDPreviewDialog::staticMetaObject = {
    { &QDialog::staticMetaObject, qt_meta_stringdata_TDPreviewDialog,
      qt_meta_data_TDPreviewDialog, 0 }
};

#ifdef Q_NO_DATA_RELOCATION
const QMetaObject &TDPreviewDialog::getStaticMetaObject() { return staticMetaObject; }
#endif //Q_NO_DATA_RELOCATION

const QMetaObject *TDPreviewDialog::metaObject() const
{
    return QObject::d_ptr->metaObject ? QObject::d_ptr->metaObject : &staticMetaObject;
}

void *TDPreviewDialog::qt_metacast(const char *_clname)
{
    if (!_clname) return 0;
    if (!strcmp(_clname, qt_meta_stringdata_TDPreviewDialog))
        return static_cast<void*>(const_cast< TDPreviewDialog*>(this));
    return QDialog::qt_metacast(_clname);
}

int TDPreviewDialog::qt_metacall(QMetaObject::Call _c, int _id, void **_a)
{
    _id = QDialog::qt_metacall(_c, _id, _a);
    if (_id < 0)
        return _id;
    if (_c == QMetaObject::InvokeMetaMethod) {
        switch (_id) {
        case 0: on_setupToolButton_clicked(); break;
        case 1: on_zoomInToolButton_clicked(); break;
        case 2: on_zoomOutToolButton_clicked(); break;
        case 3: on_pageSpinBox_valueChanged((*reinterpret_cast< int(*)>(_a[1]))); break;
        default: ;
        }
        _id -= 4;
    }
    return _id;
}
QT_END_MOC_NAMESPACE
