@echo off
echo Installing...


robocopy E:\Work\C#\SshLink\Payload\ "C:\Program Files\ItsTheNikolai\sshLink" /E >NUL


if %ERRORLEVEL% EQU 16 echo ***FATAL ERROR*** & goto end
if %ERRORLEVEL% EQU 15 echo OKCOPY + FAIL + MISMATCHES + XTRA & goto end
if %ERRORLEVEL% EQU 14 echo FAIL + MISMATCHES + XTRA & goto end
if %ERRORLEVEL% EQU 13 echo OKCOPY + FAIL + MISMATCHES & goto end
if %ERRORLEVEL% EQU 12 echo FAIL + MISMATCHES& goto end
if %ERRORLEVEL% EQU 11 echo OKCOPY + FAIL + XTRA & goto end
if %ERRORLEVEL% EQU 10 echo FAIL + XTRA & goto end
if %ERRORLEVEL% EQU 9 echo OKCOPY + FAIL & goto end
if %ERRORLEVEL% EQU 8 echo FAIL & goto end
if %ERRORLEVEL% EQU 7 echo OKCOPY + MISMATCHES + XTRA & goto end
if %ERRORLEVEL% EQU 6 echo MISMATCHES + XTRA & goto end
if %ERRORLEVEL% EQU 5 echo OKCOPY + MISMATCHES & goto end
if %ERRORLEVEL% EQU 4 echo MISMATCHES & goto end
if %ERRORLEVEL% EQU 3 echo OKCOPY + XTRA & goto end
if errorlevel 2 echo XTRA & goto end
if errorlevel 1 echo "Install Successful!" & goto end
if %ERRORLEVEL% EQU 0 echo "Program Already Installed!" & goto end
:end  

pause