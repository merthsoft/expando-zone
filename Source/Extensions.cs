using System;
using System.Linq;
using System.Reflection;
using Verse;

namespace Merthsoft.ExpandoZone
{
    public static class Extensions {
        private static BindingFlags BINDING_FLAGS = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;

        public static void SetBaseField<T>(this object obj, string fieldName, T value) {
            var fi = obj.GetType().BaseType.GetField(fieldName, BINDING_FLAGS);
            fi.SetValue(obj, value);
        }

        public static T GetFieldValue<T>(this object obj, string fieldName) 
            => (T)obj.GetType().GetFieldValue(fieldName, obj);

        public static object GetFieldValue(this Type t, string fieldName, object instance) {
            try {
                return t?.GetField(fieldName, BINDING_FLAGS)?.GetValue(instance);
            } catch {
                return null;
            }
        }

        public static bool CanAddZone(this Map map, IntVec3 cell)
            => map.zoneManager.ZoneAt(cell) != null
                || !cell.InBounds(map)
                || cell.Fogged(map)
                || cell.InNoZoneEdgeArea(map) 
                || map.thingGrid.ThingsAt(cell).Select(t => t.def).Any(d => !d.CanOverlapZones)
            ? false : true;
    }
}
