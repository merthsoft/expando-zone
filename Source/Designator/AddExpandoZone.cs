using Merthsoft.ExpandoZone.Zone;
using RimWorld;
using Verse;

namespace Merthsoft.ExpandoZone.Designator
{
    public class AddExpandoZone : Designator_ZoneAddStockpile {
        public AddExpandoZone() {
            preset = StorageSettingsPreset.DefaultStockpile;
            defaultLabel = "Expando Zone";
            hotKey = null;
            icon = ExpandoZoneMod.Icon_Expand;
        }

        protected override Verse.Zone MakeNewZone() {
            return new ExpandoStockPile(preset, Find.CurrentMap.zoneManager);
        }
    }
}
