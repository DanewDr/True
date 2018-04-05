using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class ChocolateBreastplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chocolate Breastplate");
			Tooltip.SetDefault("5% increased melee damage");
		}
		public override void SetDefaults()
		{
			item.width = 38;
			item.height = 28;
			item.value = 4500;
			item.rare = 2;
			item.defense = 10;
		}
		public override void UpdateEquip(Player player)
		{
			player.meleeDamage *= 1.05f;		
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ChocolateCookie", 35);
			recipe.AddTile(null, "CookieWorkbench");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}