@echo off
setlocal enabledelayedexpansion

REM where sources are (current folder) and where to put classes
set SRCROOT=.
set OUTDIR=out\production\Fundamentals

echo Cleaning old classes...
rmdir /s /q "%OUTDIR%" 2>nul

echo Compiling Java files...
set sources=
for /R "%SRCROOT%" %%f in (*.java) do (
    set sources=!sources! "%%f"
)

if "%sources%"=="" (
    echo No .java sources found under %SRCROOT%
    exit /b 1
)

javac -d "%OUTDIR%" %sources% || exit /b %errorlevel%

echo Running Main...
java -cp "%OUTDIR%" Main
