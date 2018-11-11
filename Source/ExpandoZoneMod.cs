using Harmony;
using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEngine;
using Verse;

namespace Merthsoft.ExpandoZone {
    public class ExpandoZoneMod : Mod {
        public static HarmonyInstance HarmonyInstance { get; set; }

        public static Texture2D Icon_Expand { get; private set; }

        static HashSet<Zone_Stockpile> expandoStockpileSet { get; set; }

        static ExpandoZoneMod() {
            HarmonyInstance = HarmonyInstance.Create("Merthsoft.ExpandoZone");
            HarmonyInstance.PatchAll(Assembly.GetExecutingAssembly());

            LongEventHandler.ExecuteWhenFinished(() => {
                Icon_Expand = ContentFinder<Texture2D>.Get("UI/Commands/Expand", true);
            });

            expandoStockpileSet = new HashSet<Zone_Stockpile>();
        }

        public ExpandoZoneMod(ModContentPack content) : base(content) {

        }

        public static void AddZone(Zone_Stockpile zone) => expandoStockpileSet.Add(zone);

        public static void RemoveZone(Zone_Stockpile zone) => expandoStockpileSet.Remove(zone);

        public static bool ContainsZone(Zone_Stockpile zone) => expandoStockpileSet.Contains(zone);
    }
}
