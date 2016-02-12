# -------------------------------------------------
# Project created by QtCreator 2010-01-25T15:08:05
# -------------------------------------------------
QT += network \
    sql \
    script \
    svg \
    xml \
    xmlpatterns

TARGET = BDtest
TEMPLATE = app
SOURCES += main.cpp \
    mainwindow.cpp \
    queryform.cpp \
    aboutdialog.cpp \
    cddialog.cpp \
    opendbdialog.cpp
HEADERS += mainwindow.hpp \
    queryform.hpp \
    aboutdialog.hpp \
    cddialog.hpp \
    opendbdialog.hpp
FORMS += mainwindow.ui \
    queryform.ui \
    aboutdialog.ui \
    cddialog.ui \
    opendbdialog.ui
RESOURCES += image.qrc
