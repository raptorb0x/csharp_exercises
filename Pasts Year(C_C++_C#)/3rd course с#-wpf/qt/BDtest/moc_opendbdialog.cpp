/****************************************************************************
** Meta object code from reading C++ file 'opendbdialog.hpp'
**
** Created: Mon Mar 15 13:05:18 2010
**      by: The Qt Meta Object Compiler version 62 (Qt 4.6.2)
**
** WARNING! All changes made in this file will be lost!
*****************************************************************************/

#include "opendbdialog.hpp"
#if !defined(Q_MOC_OUTPUT_REVISION)
#error "The header file 'opendbdialog.hpp' doesn't include <QObject>."
#elif Q_MOC_OUTPUT_REVISION != 62
#error "This file was generated using the moc from 4.6.2. It"
#error "cannot be used with the include files from this version of Qt."
#error "(The moc has changed too much.)"
#endif

QT_BEGIN_MOC_NAMESPACE
static const uint qt_meta_data_openDBDialog[] = {

 // content:
       4,       // revision
       0,       // classname
       0,    0, // classinfo
       2,   14, // methods
       0,    0, // properties
       0,    0, // enums/sets
       0,    0, // constructors
       0,       // flags
       1,       // signalCount

 // signals: signature, parameters, type, tag, flags
      14,   13,   13,   13, 0x05,

 // slots: signature, parameters, type, tag, flags
      28,   13,   13,   13, 0x0a,

       0        // eod
};

static const char qt_meta_stringdata_openDBDialog[] = {
    "openDBDialog\0\0openClicked()\0stOpenClicked()\0"
};

const QMetaObject openDBDialog::staticMetaObject = {
    { &QDialog::staticMetaObject, qt_meta_stringdata_openDBDialog,
      qt_meta_data_openDBDialog, 0 }
};

#ifdef Q_NO_DATA_RELOCATION
const QMetaObject &openDBDialog::getStaticMetaObject() { return staticMetaObject; }
#endif //Q_NO_DATA_RELOCATION

const QMetaObject *openDBDialog::metaObject() const
{
    return QObject::d_ptr->metaObject ? QObject::d_ptr->metaObject : &staticMetaObject;
}

void *openDBDialog::qt_metacast(const char *_clname)
{
    if (!_clname) return 0;
    if (!strcmp(_clname, qt_meta_stringdata_openDBDialog))
        return static_cast<void*>(const_cast< openDBDialog*>(this));
    return QDialog::qt_metacast(_clname);
}

int openDBDialog::qt_metacall(QMetaObject::Call _c, int _id, void **_a)
{
    _id = QDialog::qt_metacall(_c, _id, _a);
    if (_id < 0)
        return _id;
    if (_c == QMetaObject::InvokeMetaMethod) {
        switch (_id) {
        case 0: openClicked(); break;
        case 1: stOpenClicked(); break;
        default: ;
        }
        _id -= 2;
    }
    return _id;
}

// SIGNAL 0
void openDBDialog::openClicked()
{
    QMetaObject::activate(this, &staticMetaObject, 0, 0);
}
QT_END_MOC_NAMESPACE
