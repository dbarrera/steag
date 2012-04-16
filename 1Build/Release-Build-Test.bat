..\Lib\nant\bin\NAnt.exe -buildfile:Release-Steag-Security.build build.test > build-test.log

@echo **** done.  check build.-test.log for errors ****
pause
start notepad.exe build-test.log