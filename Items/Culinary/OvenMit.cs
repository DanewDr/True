using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Culinary
{
	public class OvenMit : CookClass
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Oven Mit");
			Tooltip.SetDefault("Heats up your hands" + "\n10% increased culinary damage");
		}
		public override void SafeSetDefaults()
		{
			item.rare = 2;
			item.accessory = true;
			item.value = 10000;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			CookDamagePlayer modPlayer = CookDamagePlayer.ModPlayer(player);
			modPlayer.cookDamage += 0.1f;
			player.buffImmune[46] = true;
		    	player.buffImmune[47] = true;
			player.magmaStone = true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HandWarmer);
			recipe.AddIngredient(ItemID.MagmaStone);
			recipe.AddTile(TileID.TinkerersWorkbench);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}		
	}
}
