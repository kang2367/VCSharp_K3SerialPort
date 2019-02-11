@echo ========================================
@echo          Source compress (7zip)
@echo ========================================

rem @echo off

if exist %CD%\exclude.lst set exclude=/exclude:%CD%\exclude.lst

xcopy %exclude% /sedchriy %CD% ..\CompressTemp

set exclude=

for /f "tokens=1-3 delims=- " %%A in ('echo %DATE%') do (set YY=%%A&SET MM=%%B&SET DD=%%C)

set YY=%YY:~2,2%

start "7z" "C:\Program Files\Bandizip\7z\7z.exe" a %CD%_%YY%%MM%%DD%.zip ..\CompressTemp\*

pause

rmdir /Q /S ..\CompressTemp


