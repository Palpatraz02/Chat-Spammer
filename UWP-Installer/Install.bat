@echo off
@setlocal enableextensions
@cd /d "%~dp0
echo ====================================================
echo         Chat Spammer Universal Windows App
echo ====================================================

    echo Administrative permissions required. Detecting permissions...

    net session >nul 2>&1
    if %errorLevel% == 0 (
		color 0a
		echo.
        echo Success: Administrative permissions confirmed.
		echo.
		echo Installing the certificate to run app...
		echo.
		Certutil -addStore TrustedPeople ChatSpammerUWP.cer
		start ChatSpammerUWP.appx
		exit
    ) else (
		color 0c
		echo.
        echo Failure: Current permissions inadeguate.
		pause
		exit
    )
