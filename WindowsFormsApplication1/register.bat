rem
rem Copyright (c) 2001-2017 by TIBCO Software Inc.
rem ALL RIGHTS RESERVED
rem
rem $Id: register.bat 94086 2017-06-16 21:54:24Z $
rem
rem Batch file for registering the TIBCO EMS C# client and UFO libraries into GAC
rem

rem the TIBCO EMS C# client and UFO libraries
rem set CSLIB=..\..\bin\TIBCO.EMS.dll
rem set CSUFOLIB=..\..\bin\TIBCO.EMS.UFO.dll

set CSLIB=TIBCO.EMS.dll
set CSUFOLIB=TIBCO.EMS.UFO.dll

rem the path where gacutil.exe is located (to be adjusted to your specific environment)
rem set GACPATH="C:\Program Files\Microsoft Visual Studio .NET\FrameworkSDK\bin"
set GACPATH="C:\Program Files (x86)\Microsoft SDKs\Windows\v8.1A\bin\NETFX 4.5.1 Tools\x64"
%GACPATH%\gacutil.exe /i %CSLIB% 
%GACPATH%\gacutil.exe /i %CSUFOLIB%

set CSLIB=
set CSUFOLIB=
set GACPATH=
