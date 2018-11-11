using Harmony;
using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;
using static Merthsoft.ExpandoZone.ExpandoZoneMod;

namespace Merthsoft.ExpandoZone.Patches {
    [HarmonyPatch(typeof(Zone_Stockpile), "GetGizmos")]
    public class Zone_Stockpile_GetGizmos {
        static void Postfix(IEnumerable<Gizmo> __result, Zone_Stockpile __instance) {
            __result.Add(new Command_Toggle() {
                icon = Icon_Expand,
                defaultLabel = "Auto-Expand",
                defaultDesc = "Automatically expand to fill a room",
                isActive = () => ContainsZone(__instance),
                toggleAction = () => {
                    if (ContainsZone(__instance)) {
                        RemoveZone(__instance);
                    } else {
                        AddZone(__instance);
                    }
                } 
            });
        }
    }
}
