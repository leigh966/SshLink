@echo off
arp -a | find /I %1 > temp.txt
set /p line=<temp.txt
set ip=%line:~2,13%
set out=%2@%ip%
C:\Windows\System32\OpenSSH\ssh.exe %out%
PAUSE