using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace Heliox.HelioxMod
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    [BepInDependency("com.snmodding.nautilus")]
    public class HelioxPlugin : BaseUnityPlugin
    {
        private const string PluginGuid = "heliox.helioxmod";
        private const string PluginName = "Heliox";
        private const string PluginVersion = "0.0.0.1";

        private static readonly Harmony Harmony = new Harmony(PluginGuid);

        public static ManualLogSource Log;

        private void Awake()
        {
            Harmony.PatchAll();
            Logger.LogInfo(PluginName + " " + PluginVersion + " loaded");
            Log = Logger;
        }
    }
}