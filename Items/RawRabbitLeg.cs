
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace CookieMod.Items
{
    public class RawRabbitLeg : GlobalItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Raw Rabbit Leg");
			Tooltip.SetDefault("How could anyone do this to a poor bunny?");
		}
        public override void SafeSetDefaults()
        {
            item.width = 18;
            item.height = 22;
            item.value = 75;
            item.rare = 1;
            item.maxStack = 999;
        }
    }
}
