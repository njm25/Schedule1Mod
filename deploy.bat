@echo off
echo Building and deploying Schedule 1 Mod...

REM Load environment variables from .env file
for /F "tokens=*" %%A in (.env) do set %%A

REM Build the project
dotnet build

REM Create plugins directory if it doesn't exist
if not exist "%GAME_DIR%\BepInEx\plugins" mkdir "%GAME_DIR%\BepInEx\plugins"

REM Copy the DLL to the plugins directory
copy /Y "%PROJ_DIR%\bin\Debug\net8.0\%DLL_NAME%" "%GAME_DIR%\BepInEx\plugins"

echo Deployment complete!
pause 