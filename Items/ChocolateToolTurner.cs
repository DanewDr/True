using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace CookieMod.Items
{
	public class ChocolateToolTurner : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chocolate Tool Turner");
			Tooltip.SetDefault("Increases melee and pick speed");			
		}
		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = 10000;
			item.rare = 3;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.meleeSpeed += 0.2f;
			player.pickSpeed -= 0.2f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ChocolateCookie", 16);
			recipe.AddTile(null, "CookieWorkbench");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
