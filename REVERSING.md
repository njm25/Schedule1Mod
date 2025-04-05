# Reversing IL2CPP Unity Games (PC) with Il2CppDumper and dnSpy

## Requirements

- PC Unity game using the IL2CPP backend
- `GameAssembly.dll` (found in the game root directory)
- `global-metadata.dat` (in `GameName_Data/il2cpp_data/Metadata/`)
- [Il2CppDumper](https://github.com/Perfare/Il2CppDumper)
- [dnSpy](https://github.com/dnSpy/dnSpy/releases)

---

## Step 1: Dump the Game Metadata

1. Download and extract Il2CppDumper
2. Run `Il2CppDumper.exe`
3. When prompted:
   - Select `GameAssembly.dll`  
     *(This is located in the root folder of the game, next to the `.exe`)*
   - Then select `global-metadata.dat`  
     *(This is usually found in `GameName_Data/il2cpp_data/Metadata/`)*
4. Choose auto mode when prompted
5. After successful dumping, a `DummyDll/` folder will be created. It contains stub DLLs with reconstructed class and method definitions.

---

## Step 2: Inspect with dnSpy

1. Download and open dnSpy
2. Drag and drop the DLLs from `DummyDll/` into the Assembly Explorer panel
3. Browse the namespaces and classes to find method signatures and structures
4. You can inspect method names, parameters, return types, and class hierarchies

---

## Which DLLs Contain Game Logic?

From the `DummyDll/` output, focus on the following:

- `Assembly-CSharp.dll`  
  This is the main DLL for user scripts. It usually contains core gameplay logic such as player behavior, UI management, game state, and MonoBehaviour classes.

Other useful DLLs:
- `Assembly-CSharp-firstpass.dll` — often used for third-party plugins or early-loaded scripts
- Any DLLs with game-specific names that are not system or Unity-related

Ignore the following:
- `mscorlib.dll`, `System.*.dll`, `UnityEngine.*.dll` — these are engine/system references, not game logic

---

## Finding Relevant Methods

In dnSpy, use `Ctrl+Shift+F` to search globally for:
- Common class or method names like `Player`, `Enemy`, `GameManager`, `Start()`, `Update()`, etc.
- MonoBehaviour-derived classes
- Known strings from the game (e.g., UI text, settings labels) to trace back to logic handlers

If the game is obfuscated, look for useful parameter names or method signatures to infer purpose.
