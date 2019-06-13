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
	public class InsulatedPlasticGlove : CookClass
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Insulated Plastic Glove");
			Tooltip.SetDefault("Does a placeholder thing");
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
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "BarOfSoap");
			recipe.AddIngredient(null, "OvenMit");
			recipe.AddTile(TileID.TinkerersWorkbench);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}		
	}
}
