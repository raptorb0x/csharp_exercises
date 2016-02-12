"(S)loc = "+(dir -include *.cs,*.cpp,*.idl,*.asmx,*.c -recurse | select-string .).Count

