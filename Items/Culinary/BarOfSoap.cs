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
	public class BarOfSoap : CookClass
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bar Of Soap");
			Tooltip.SetDefault("3% increased culinary crit chance");
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
			modPlayer.cookCrit += 6;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bubble, 15);
			recipe.AddTile(TileID.TinkerersWorkbench);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}		
	}
}
