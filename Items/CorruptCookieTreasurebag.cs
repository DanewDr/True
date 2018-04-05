using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items
{
    public class CorruptCookieTreasurebag : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Treasure Bag");
			Tooltip.SetDefault("Right click to open");
		}
        public override void SetDefaults()
        {
            item.maxStack = 999;
            item.consumable = true;
            item.width = 24;
            item.height = 24;
            item.rare = 11;
            bossBagNPC = mod.NPCType("CorruptCookie1");  //add this if the tresure bag is droped from a boss
            item.expert = true;      //add this if it's expert mode only
        }
        public override bool CanRightClick()
        {
            return true;
        }

        public override void OpenBossBag(Player player)
        {                                         //below it's a choice from 3 items that will drop randomly
            //and this is the items that will 100% drop from the treasure bag
            player.QuickSpawnItem(mod.ItemType("Cookie"), Main.rand.Next(25, 35));
			player.QuickSpawnItem(mod.ItemType("Milk"), Main.rand.Next(10, 20));
            player.QuickSpawnItem(mod.ItemType("CookieOrb"));				
			if (Main.rand.Next(7) == 0)
			{
				player.QuickSpawnItem(mod.ItemType("CorruptCookieMask"));
			}
        }
    }
}
