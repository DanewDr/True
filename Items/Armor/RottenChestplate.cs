using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class RottenChestplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rotten Chestplate");
			Tooltip.SetDefault("5% increased throwing damage");
		}
		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 28;
			item.value = 4500;
			item.rare = 2;
			item.defense = 7;
		}
		public override void UpdateEquip(Player player)
		{
			player.thrownDamage *= 1.05f;		
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "RottenCookie", 35);
			recipe.AddTile(null, "CookieWorkbench");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}