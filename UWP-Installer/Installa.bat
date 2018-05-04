@echo off
@setlocal enableextensions
@cd /d "%~dp0
echo ====================================================
echo         Chat Spammer Universal Windows App
echo ====================================================
echo                 Versione 0.7 UWP
echo.

    echo Permessu di amministratore richiesti. Controllo permessi...

    net session >nul 2>&1
    if %errorLevel% == 0 (
		color 0a
		echo.
        echo Fatto: Permessi di amministratore confermati
		goto menu
    ) else (
		color 0c
		echo.
        echo Fallito: Permessi correnti inadeguati
		pause
		exit
    )
	
:menu
echo 1) Installa il certificato e l'app
echo 2) Installa o aggiorna l'app
set /p sel=Digita la tua scelta: 
if %sel% equ 1 goto cert
if %sel% equ 2 goto app

:cert
		echo.
		echo.
		echo Installo il certificato per far funzionare l'app...
		echo.
		Certutil -addStore TrustedPeople Pierre02_Palpatraz02.cer
		start ChatSpammerUWP.appx
		exit
:app
		start ChatSpammerUWP.appx
