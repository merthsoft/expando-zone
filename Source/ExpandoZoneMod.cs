using RimWorld;
using System.Collections.Generic;
using UnityEngine;
using Verse;

namespace Merthsoft.ExpandoZone
{
    [StaticConstructorOnStartup]
    public class ExpandoZoneMod : Mod {
        public static Texture2D Icon_Expand { get; private set; }

        static HashSet<Zone_Stockpile> expandoStockpileSet { get; set; }

        static ExpandoZoneMod() {
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
