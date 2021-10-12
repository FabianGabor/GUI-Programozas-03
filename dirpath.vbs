'vbs program, kiirja egy adott mappa nevet, eleresi utjat, szulo mappat, almappak szamas es fajlok szamat

Dim fso
Set fso = CreateObject("Scripting.FileSystemObject")
GetCurrentPath = FSO.GetAbsolutePathName(".")
parentDir = CreateObject("Scripting.FileSystemObject").GetParentFolderName(GetCurrentPath)

'MsgBox("path = " &GetCurrentPath)
'MsgBox("parentDir = " &parentDir)

set currentDir = fso.GetFolder(GetCurrentPath)
with currentDir
M1 = "Name: " &.name & vbCrLf
M2 = "Current dir: " &.path & vbCrLf
M3 = "Parent dir: " &.parentfolder & vbCrLf
M4 = "Subfolder count: " &.subfolders.count & vbCrLf
M5 = "Filecount: " &.files.count & vbCrLf
MsgBox M1 + M2 + M3 + M4 + M5
end with
set fso = nothing
set currentDir = nothing