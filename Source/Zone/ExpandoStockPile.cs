using RimWorld;
using System.Collections.Generic;
using Verse;

namespace Merthsoft.ExpandoZone.Zone
{
    public class ExpandoStockPile : Zone_Stockpile {
        public bool ExpandoEnabled = true;

        public ExpandoStockPile() : base() { }

        public ExpandoStockPile(StorageSettingsPreset preset, ZoneManager zoneManager)
            : base(preset, zoneManager) { }

        public override IEnumerable<Gizmo> GetGizmos() {
            foreach (var g in base.GetGizmos()) {
                yield return g;
            }

            yield return new Command_Toggle() {
                icon = ExpandoZoneMod.Icon_Expand,
                defaultLabel = "Auto-Expand",
                defaultDesc = "Automatically expand to fill a room",
                isActive = () => ExpandoEnabled,
                toggleAction = () => ExpandoEnabled = !ExpandoEnabled
            };

        }

        public override void ExposeData() {
            base.ExposeData();

            Scribe_Values.Look(ref ExpandoEnabled, nameof(ExpandoEnabled), true);
        }


    }
}
