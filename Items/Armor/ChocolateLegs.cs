using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace CookieMod.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class ChocolateLegs : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chocolate Leggings");
			Tooltip.SetDefault("5% increased melee damage");
		}
		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 18;
			item.value = 35;
			item.rare = 2;
			item.defense = 9;
		}

		public override void UpdateEquip(Player player)
		{
			player.meleeDamage *= 1.05f;		
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ChocolateCookie", 30);
			recipe.AddTile(null, "CookieWorkbench");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}