@echo OFF

:loop
set /p prgm=Enter name: 
c:\windows\Microsoft.NET\Framework\v4.0.30319\csc.exe /t:exe /out:%prgm%.exe %prgm%.cs Form1.cs Form1.Designer.cs

goto loop