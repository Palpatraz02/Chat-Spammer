@echo off
@setlocal enableextensions
@cd /d "%~dp0

    net session >nul 2>&1
    if %errorLevel% == 0 (
		set admin=true
		goto menu
    ) else (
		set admin=false
		goto menulite
    )
	
	
:menu
color 0a
echo ====================================================
echo         Chat Spammer Universal Windows App
echo ====================================================
echo                 Versione 0.8 UWP
echo.
echo.
echo Fatto: Permessi di amministratore confermati
echo.
echo 1) Installa o aggiorna l'app
echo 2) Installa o aggiorna il certificato
echo.
set /p sel=Digita la tua scelta: 
if %sel% equ 1 goto app
if %sel% equ 2 goto cert

:menulite
color 0c
echo ====================================================
echo         Chat Spammer Universal Windows App
echo ====================================================
echo                 Versione 0.8 UWP
echo.
echo.
echo Fallito: Permessi correnti inadeguati
echo Per installare o aggiornare il certificato, esegui l'installer come amministratore
echo.
echo 1) Installa o aggiorna l'app
echo.
set /p sel=Digita la tua scelta: 
if %sel% equ 1 goto app


:cert
		echo.
		echo.
		echo Installo il certificato per far funzionare l'app...
		echo.
		Certutil -addStore TrustedPeople Pierre02_Palpatraz02.cer
		cls
		if %admin% equ true goto menu
		if %admin% equ false goto menulite
:app
		start ChatSpammerUWP_0.8.appx
		cls
		if %admin% equ true goto menu
		if %admin% equ false goto menulite