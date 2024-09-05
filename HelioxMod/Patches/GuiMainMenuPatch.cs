using HarmonyLib;

namespace Heliox.HelioxMod.Patches
{
    /**
     * Send a message in the UI when the game starts with the mod version number as a test
     */
    [HarmonyPatch(typeof(uGUI_MainMenu))]
    internal class GuiMainMenuPatch
    {
        [HarmonyPatch(nameof(uGUI_MainMenu.Awake))]
        [HarmonyPostfix]
        public static void Awake_Postfix(uGUI_MainMenu __instance)
        {
            ErrorMessage.AddMessage("Using Heliox v" + HelioxPlugin.PluginVersion);
        }
    }
}