using Merthsoft.ExpandoZone.Zone;
using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace Merthsoft.ExpandoZone.Designator {
    public class AddExpandoZone : Designator_ZoneAddStockpile {
        public AddExpandoZone() {
            preset = StorageSettingsPreset.DefaultStockpile;
            defaultLabel = "Expando Zone";
            hotKey = null;
        }

        protected override Verse.Zone MakeNewZone() {
            return new ExpandoStockPile(preset, Find.CurrentMap.zoneManager);
        }
    }
}
