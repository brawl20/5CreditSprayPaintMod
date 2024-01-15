using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using _5CreditSprayPaintMod.Patches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5CreditSprayPaintMod
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class _5CreditSprayPaintBaseMod : BaseUnityPlugin
    {
        private const string modGUID = "YellowGameDev.5CreditSprayPaintMod";
        private const string modName = "5CreditSprayPaintMod";
        private const string modVersion = "2.0.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);
        
        private static _5CreditSprayPaintBaseMod Instance;


        internal ManualLogSource mls;

        void Awake() 
        {
            if (Instance == null) 
            {
                Instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);

            mls.LogInfo("Micheal'sFirstMod has awaken");

            harmony.PatchAll(typeof(_5CreditSprayPaintBaseMod));
            harmony.PatchAll(typeof(CostFixForSprayPaint));
        }

    }
}
