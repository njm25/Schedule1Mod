# Schedule 1 Hello World Mod

## Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Schedule 1 game
- [BepInEx IL2CPP](https://github.com/BepInEx/BepInEx)

---

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

---

## Building and Deploying

Run the deployment script to build the mod and copy it to your game's BepInEx plugins folder:

```
.\deploy.bat
```

---

## Running the Mod

1. Launch Schedule 1
2. The mod will automatically load in the BepInEx console
3. Check the BepInEx console logs to confirm the mod has loaded successfully

---

## Development

- `Main.cs` contains the BepInEx plugin code
- Edit the plugin to add more functionality
- Use the deployment script to quickly test your changes

---

## Reverse Engineering

To develop on top of the game, you'll need to understand the game's internal structure:

1. Dump the game's IL2CPP code using Il2CppDumper
2. Analyze the game's classes and methods with dnSpy
3. Use the discovered class structures to interact with the game

See [REVERSING.md](REVERSING.md) for a detailed guide on how to dump and analyze the game code.
