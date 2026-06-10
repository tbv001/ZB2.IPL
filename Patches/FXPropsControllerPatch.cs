using HarmonyLib;

namespace IPL.Patches;

[HarmonyPatch(typeof(FXPropsController))]
public class FXPropsControllerPatch
{
    [HarmonyPostfix]
    [HarmonyPatch(nameof(FXPropsController.Init))]
    private static void Init_Postfix(FXPropsController __instance)
    {
        __instance.maxProps = 256;
    }
}
