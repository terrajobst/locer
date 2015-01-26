@ECHO OFF

SETLOCAL

SET CACHED_NUGET=%LocalAppData%\NuGet\NuGet.exe
SET SOLUTION_PATH=%~dp0src\locer.sln
SET BUILD_TOOLS_PATH="%ProgramFiles(x86)%\MSBuild\12.0\bin\MSBuild.exe"

IF NOT EXIST %BUILD_TOOLS_PATH% (
  echo In order to build or run this tool you need either Visual Studio 2013 or
  echo Microsoft Build Tools 2013 Preview tools installed.
  echo.
  echo Visit http://www.visualstudio.com/en-us/downloads to download either.
  goto :eof
)

IF EXIST %CACHED_NUGET% goto restore
echo Downloading latest version of NuGet.exe...
IF NOT EXIST %LocalAppData%\NuGet md %LocalAppData%\NuGet
@powershell -NoProfile -ExecutionPolicy unrestricted -Command "$ProgressPreference = 'SilentlyContinue'; Invoke-WebRequest 'https://www.nuget.org/nuget.exe' -OutFile '%CACHED_NUGET%'"

:restore
IF EXIST "%~dp0src\packages" goto build
%CACHED_NUGET% restore %SOLUTION_PATH%

:build

%BUILD_TOOLS_PATH% %SOLUTION_PATH% /p:OutDir="%~dp0bin " /nologo /m /v:m /flp:verbosity=normal %*
