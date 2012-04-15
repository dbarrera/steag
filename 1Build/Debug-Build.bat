..\Lib\nant\bin\NAnt.exe -buildfile:debug-steag-security.build > build.log

@echo **** done.  check build.log for errors ****
pause
start notepad.exe build.log