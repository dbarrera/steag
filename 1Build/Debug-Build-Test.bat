..\Lib\nant\bin\NAnt.exe -buildfile:Debug-Steag-Security.build build.test > build-test.log

@echo **** done.  check build.-test.log for errors ****
pause
start notepad.exe build-test.log