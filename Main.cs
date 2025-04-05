using BepInEx;
using BepInEx.Unity.IL2CPP;
using BepInEx.Logging;

namespace Schedule1Mod;

[BepInPlugin("com.yourname.schedule1mod", "Schedule 1 Hello World Mod", "1.0.0")]
public class HelloWorldPlugin : BasePlugin
{
    public override void Load()
    {
        // Plugin startup logic
        Log.LogInfo("Hello World Plugin is loaded!");
        Log.LogMessage("========================");
        Log.LogMessage("=     HELLO WORLD     =");
        Log.LogMessage("=  Schedule 1 Plugin  =");
        Log.LogMessage("========================");
        
        // Demonstrate the plugin is working with a successful load message
        Log.LogInfo("Hello World Plugin has been loaded successfully!");
    }
} 