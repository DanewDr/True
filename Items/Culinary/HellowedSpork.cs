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
	public class HellowedSpork : CookClass
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hellowed Spork");
			Tooltip.SetDefault("10% Increased culinary damage\n7% increased culinary crit chance\nIncreased culinary knockback");
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
			modPlayer.cookCrit += 7;
			modPlayer.cookKnockback += 5f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "RubberBand");
			recipe.AddIngredient(null, "HellstoneFork");
			recipe.AddIngredient(null, "HallowedSpoon");
			recipe.AddTile(TileID.TinkerersWorkbench);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}		
	}
}