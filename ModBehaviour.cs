using UnityEngine;
using Il2CppInterop.Runtime.Attributes;
using ScheduleOne.PlayerScripts;

namespace Schedule1Mod;

public sealed class ModBehaviour : MonoBehaviour
{
    private bool playerFound = false;

    void Awake()
    {
        Schedule1Mod.StaticLog.LogInfo("ModBehaviour Awake called!");
    }

    void Update()
    {
        Schedule1Mod.StaticLog.LogInfo("Updating");
        if (!playerFound)
        {
            Player player = UnityEngine.Object.FindObjectOfType<Player>();
            if (player != null)
            {
                playerFound = true;
                Schedule1Mod.StaticLog.LogInfo("Player found: " + player.ToString());
            }
        }
    }
}
