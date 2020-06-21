rem
rem Copyright (c) 2001-2017 by TIBCO Software Inc.
rem ALL RIGHTS RESERVED
rem
rem $Id: unregister.bat 94086 2017-06-16 21:54:24Z $
rem
rem Batch file for unregistering the TIBCO EMS C# client and UFO libraries from GAC
rem

rem the name of the TIBCO EMS C# client and UFO libraries
set CSLIBNAME=TIBCO.EMS
set CSLIBUFONAME=TIBCO.EMS.UFO

rem the path where gacutil.exe is located (to be adjusted to your specific environment)
set GACPATH="C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.6.1 Tools\x64"

%GACPATH%\gacutil.exe /u %CSLIBNAME% 
%GACPATH%\gacutil.exe /u %CSLIBUFONAME% 

set CSLIBNAME=
set CSLIBUFONAME=
set GACPATH=
