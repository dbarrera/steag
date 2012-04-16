..\Lib\nant\bin\NAnt.exe -buildfile:Release-Steag-Security.build > build.log

@echo **** done.  check build.log for errors ****
pause
start notepad.exe build.log