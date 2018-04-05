using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace CookieMod.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class HoneyLeggings : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Honey Leggings");
			Tooltip.SetDefault("5% increased summon damage");
		}
		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 18;
			item.value = 35;
			item.rare = 2;
			item.defense = 5;
		}
		public override void UpdateEquip(Player player)
		{
			player.minionDamage *= 1.05f;		
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "HoneyCookie", 30);
			recipe.AddTile(null, "CookieWorkbench");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}