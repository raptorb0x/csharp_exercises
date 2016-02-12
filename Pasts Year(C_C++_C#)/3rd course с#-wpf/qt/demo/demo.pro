include(demo.pri)
LANGUAGE = C++

# CONFIG += qt release
CONFIG += static debug warn_on  exceptions
CONFIG -= release

MOC_DIR = tmp/moc
UI_DIR = tmp/ui
OBJECTS_DIR = tmp/obj
RCC_DIR = tmp/rcc

QT += core gui

TEMPLATE = app

DEPENDPATH += ./ ../forms ../src
INCLUDEPATH += ./ ../src

TARGET = demo_tableprinter

LANGUAGE = C++


LIBS += ./libtableprinter.a
