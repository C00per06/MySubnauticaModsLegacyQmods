using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace HardenedBladeReAddedReduxBepInEx
{
    [BepInPlugin(myGUID, pluginName, versionString)]
    public class KnifeDamagePlugin_SN : BaseUnityPlugin
    {
        private const string myGUID = "com.cooper06.hardenedbladereaddedredux";
        private const string pluginName = "Hardened Blade Re-Added Redux";
        private const string versionString = "1.0.0";

        private static readonly Harmony harmony = new Harmony(myGUID);

        public static ManualLogSource logger;

        private void Awake()
        {
            harmony.PatchAll();
            Logger.LogInfo(pluginName + " " + versionString + " " + "loaded.");
            logger = Logger;
        }
    }
}
