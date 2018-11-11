using Merthsoft.ExpandoZone.Zone;
using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace Merthsoft.ExpandoZone.Component {
    public class ExpandoComponent : GameComponent {
        public static int TickRate = 250;
        private int tickNumber = TickRate;
        public ExpandoComponent(Game g) {
        }

        public override void GameComponentTick() {
            if (tickNumber != 0) {
                tickNumber--;
                return;
            }
            tickNumber = TickRate;

            foreach (var zone in Find.CurrentMap.zoneManager.AllZones.OfType<ExpandoStockPile>().Where(z => z.ExpandoEnabled)) {
                var room = zone.Cells.First().GetRoom(zone.Map);
                if (room == null || room.IsHuge) { continue; }

                foreach (var cell in room.Cells.Where(c => !zone.ContainsCell(c))) {
                    zone.AddCell(cell);
                }
            }
        }
    }
}
