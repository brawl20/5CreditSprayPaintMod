using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace _5CreditSprayPaintMod.Patches
{
    [HarmonyPatch(typeof(Terminal))]
    internal class CostFixForSprayPaint
    {
        [HarmonyPatch("Update")]
        [HarmonyPrefix]
        static void sprayPaintCostFixPatch(ref Item[] ___buyableItemsList, ref int[] ___itemSalesPercentages) 
        {
            for (int i = 0; i < ___buyableItemsList.Length; i++) 
            {
                if (___buyableItemsList[i].itemName == "Spray paint") 
                {
                    ___buyableItemsList[i].creditsWorth = 5 * (___itemSalesPercentages[i] / 100);
                }
            }
        }

    }
}
