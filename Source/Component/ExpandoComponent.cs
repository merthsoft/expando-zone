using Merthsoft.ExpandoZone.Zone;
using System.Linq;
using Verse;

namespace Merthsoft.ExpandoZone.Component
{
    public class ExpandoComponent : GameComponent {
        public static int TickRate = 350;
        private int tickNumber = TickRate;

        public ExpandoComponent(Game g) {
        }

        public override void GameComponentTick() {
            if (tickNumber != 0)
            {
                tickNumber--;
                return;
            }
            tickNumber = TickRate;

            Map map = Find.CurrentMap;
            if (map?.zoneManager?.AllZones == null) { return; }

            var expandoZones = map.zoneManager.AllZones?.OfType<ExpandoStockPile>()?.Where(z => z.ExpandoEnabled);
            if (expandoZones == null) { return; }

            foreach (var zone in expandoZones) {
                var room = zone.Cells.First().GetRoom(map);
                if (room == null || room.IsHuge) { continue; }

                foreach (var cell in room.Cells.Where(c => map.CanAddZone(c))) {
                    zone.AddCell(cell);
                }
            }
        }
    }
}
