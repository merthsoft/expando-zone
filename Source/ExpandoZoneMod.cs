using RimWorld;
using System.Collections.Generic;
using UnityEngine;
using Verse;

namespace Merthsoft.ExpandoZone
{
    [StaticConstructorOnStartup]
    public class ExpandoZoneMod : Mod {
        public static Texture2D Icon_Expand { get; private set; }

        static ExpandoZoneMod() {
            LongEventHandler.ExecuteWhenFinished(() => {
                Icon_Expand = ContentFinder<Texture2D>.Get("UI/Commands/Expand", true);
            });
        }

        public ExpandoZoneMod(ModContentPack content) : base(content) {

        }
    }
}
