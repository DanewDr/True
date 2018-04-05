using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items
{
    public class BunnyKingTreasureBag : ModItem
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
            bossBagNPC = mod.NPCType("TrueBunnyKing");
            item.expert = true;
        }
        public override bool CanRightClick()
        {
            return true;
        }

        public override void OpenBossBag(Player player)
        {                                        
            player.QuickSpawnItem(mod.ItemType("GoldBunnyFur"), Main.rand.Next(20, 30));
			player.QuickSpawnItem(mod.ItemType("BunnyKingTome"));
//            player.QuickSpawnItem(mod.ItemType("ExpertDrop"));				
			if (Main.rand.Next(7) == 0)
			{
				player.QuickSpawnItem(mod.ItemType("BunnyKingMask"));
			}
        }
    }
}