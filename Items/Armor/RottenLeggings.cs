using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace CookieMod.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class RottenLeggings : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rotten Leggings");
			Tooltip.SetDefault("5% increased throwing damage");
		}
		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 28;
			item.value = 35;
			item.rare = 2;
			item.defense = 5;
		}
		public override void UpdateEquip(Player player)
		{
			player.thrownDamage *= 1.05f;		
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "RottenCookie", 30);
			recipe.AddTile(null, "CookieWorkbench");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}