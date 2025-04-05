using BepInEx;
using BepInEx.Unity.IL2CPP;
using BepInEx.Logging;
using UnityEngine;
using Il2CppInterop.Runtime.Injection;

namespace Schedule1Mod;

[BepInPlugin("com.njm25.schedule1mod", "Schedule 1 Mod", "1.0.0")]
public class Schedule1Mod : BasePlugin
{
    public static ManualLogSource StaticLog;

    public override void Load()
    {
        StaticLog = base.Log;
        StaticLog.LogInfo("Registering ModBehaviour...");
        ClassInjector.RegisterTypeInIl2Cpp<ModBehaviour>();

        StaticLog.LogInfo("Creating hook GameObject...");
        GameObject hook = new GameObject("ModMain");
        var behaviour = hook.AddComponent<ModBehaviour>();
        StaticLog.LogInfo("Added ModBehaviour: " + behaviour);

        UnityEngine.Object.DontDestroyOnLoad(hook);
        StaticLog.LogInfo("Schedule 1 Mod is loaded!");
    }
}

