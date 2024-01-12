using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichealsFirstMod
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class MichealsFirstModBase : BaseUnityPlugin
    {
        private const string modGUID = "Micheal.MichealsFirstMod";
        private const string modName = "Micheal's_First_Mod";
        private const string modVersion = "1.0.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);
        
        private static MichealsFirstModBase Instance;


        internal ManualLogSource mls;

        void Awake() 
        {
            if (Instance == null) 
            {
                Instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);

            mls.LogInfo("Micheal'sFirstMod has awaken");

            harmony.PatchAll(typeof(MichealsFirstModBase));
        }

    }
}
