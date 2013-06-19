@echo off

set psakeversion=4.2.0.1

if '%1'=='/?' goto help
if '%1'=='-help' goto help
if '%1'=='-h' goto help

call "%~dp0vsvars32.bat"

powershell -NoProfile -ExecutionPolicy Bypass -Command "& '%~dp0packages\psake.%psakeversion%\tools\psake.ps1' %*; if ($psake.build_success -eq $false) { exit 1 } else { exit 0 }"
goto :eof

:help
powershell -NoProfile -ExecutionPolicy Bypass -Command "& '%~dp0packages\psake.%psakeversion%\tools\psake.ps1' -help"
