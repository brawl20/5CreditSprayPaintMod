using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace _5CreditSprayPaintMod.Patches
{
    [HarmonyPatch(typeof(SprayPaintItem))]
    internal class InfiniteSprayPatch
    {
        [HarmonyPatch(nameof(SprayPaintItem.LateUpdate))]
        [HarmonyPostfix]
        static void infiniteSprayPaintPatch(ref float ___sprayCanTank) 
        {
            ___sprayCanTank = .1f;
        }
    }
}
