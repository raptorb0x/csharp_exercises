/****************************************************************************
** Meta object code from reading C++ file 'cddialog.hpp'
**
** Created: Mon Mar 29 13:03:40 2010
**      by: The Qt Meta Object Compiler version 62 (Qt 4.6.2)
**
** WARNING! All changes made in this file will be lost!
*****************************************************************************/

#include "cddialog.hpp"
#if !defined(Q_MOC_OUTPUT_REVISION)
#error "The header file 'cddialog.hpp' doesn't include <QObject>."
#elif Q_MOC_OUTPUT_REVISION != 62
#error "This file was generated using the moc from 4.6.2. It"
#error "cannot be used with the include files from this version of Qt."
#error "(The moc has changed too much.)"
#endif

QT_BEGIN_MOC_NAMESPACE
static const uint qt_meta_data_CDDialog[] = {

 // content:
       4,       // revision
       0,       // classname
       0,    0, // classinfo
       4,   14, // methods
       0,    0, // properties
       0,    0, // enums/sets
       0,    0, // constructors
       0,       // flags
       0,       // signalCount

 // slots: signature, parameters, type, tag, flags
      10,    9,    9,    9, 0x08,
      18,    9,    9,    9, 0x08,
      33,   26,    9,    9, 0x08,
      65,    9,    9,    9, 0x08,

       0        // eod
};

static const char qt_meta_stringdata_CDDialog[] = {
    "CDDialog\0\0addCD()\0delCD()\0record\0"
    "beforeInsertArtist(QSqlRecord&)\0"
    "resetTable()\0"
};

const QMetaObject CDDialog::staticMetaObject = {
    { &QDialog::staticMetaObject, qt_meta_stringdata_CDDialog,
      qt_meta_data_CDDialog, 0 }
};

#ifdef Q_NO_DATA_RELOCATION
const QMetaObject &CDDialog::getStaticMetaObject() { return staticMetaObject; }
#endif //Q_NO_DATA_RELOCATION

const QMetaObject *CDDialog::metaObject() const
{
    return QObject::d_ptr->metaObject ? QObject::d_ptr->metaObject : &staticMetaObject;
}

void *CDDialog::qt_metacast(const char *_clname)
{
    if (!_clname) return 0;
    if (!strcmp(_clname, qt_meta_stringdata_CDDialog))
        return static_cast<void*>(const_cast< CDDialog*>(this));
    return QDialog::qt_metacast(_clname);
}

int CDDialog::qt_metacall(QMetaObject::Call _c, int _id, void **_a)
{
    _id = QDialog::qt_metacall(_c, _id, _a);
    if (_id < 0)
        return _id;
    if (_c == QMetaObject::InvokeMetaMethod) {
        switch (_id) {
        case 0: addCD(); break;
        case 1: delCD(); break;
        case 2: beforeInsertArtist((*reinterpret_cast< QSqlRecord(*)>(_a[1]))); break;
        case 3: resetTable(); break;
        default: ;
        }
        _id -= 4;
    }
    return _id;
}
QT_END_MOC_NAMESPACE
