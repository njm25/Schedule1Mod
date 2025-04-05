# Schedule 1 Hello World Mod

A simple BepInEx mod for Schedule 1 that displays a "Hello World" message in the console.

## Prerequisites

1. [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
2. Schedule 1 game
3. [BepInEx IL2CPP](https://github.com/BepInEx/BepInEx)

## Setup

1. Install [BepInEx IL2CPP](https://github.com/BepInEx/BepInEx) into your Schedule 1 game folder
2. Clone this repository
3. Create a `.env` file in the root directory with the following content:
   ```
   GAME_DIR=C:\Path\To\Schedule I
   PROJ_DIR=C:\Path\To\Schedule1Mod
   DLL_NAME=Schedule1Mod.dll
   ```
   Replace the paths with your actual game and project directories.

## Building and Deploying

Run the deployment script to build the mod and copy it to your game's BepInEx plugins folder:

```
.\deploy.bat
```

## Running the Mod

1. Launch Schedule 1
2. The mod will automatically load in the BepInEx console
3. Check the BepInEx console logs to confirm the mod has loaded successfully