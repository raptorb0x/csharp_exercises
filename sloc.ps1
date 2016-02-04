"(S)loc = "+(dir -include *.cs,*.cpp,*.h,*.idl,*.asmx -recurse | select-string .).Count
$host.UI.RawUI.ReadKey()|out-null
