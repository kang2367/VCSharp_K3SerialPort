@echo ========================================
@echo          Source compress (Alzip)
@echo ========================================

rem @echo off

if exist %CD%\exclude.lst set exclude=/exclude:%CD%\exclude.lst

xcopy %exclude% /sedchriy %CD% ..\CompressTemp

set exclude=

for /f "tokens=1-3 delims=- " %%A in ('echo %DATE%') do (set YY=%%A&SET MM=%%B&SET DD=%%C)

set YY=%YY:~2,2%

start "Alzip" "d:\Program Files (x86)\ESTsoft\ALZip\alzipcon" -a -d ..\CompressTemp\*.* %CD%_%YY%%MM%%DD%.zip

