using System;
using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace IPL;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Ipl : BaseUnityPlugin
{
    public const string PluginGuid = "com.theblackvoid.increasedparticlelimit";
    private readonly Harmony _harmony = new(PluginGuid);
    internal new static ManualLogSource Logger;

    private void Awake()
    {
        Logger = base.Logger;
        try
        {
            _harmony.PatchAll(Assembly.GetExecutingAssembly());
            Logger.LogInfo("Successfully loaded!");
        }
        catch (Exception e)
        {
            Logger.LogError($"Failed to load: {e}");
        }
    }
}
