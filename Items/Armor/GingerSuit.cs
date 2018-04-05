using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class GingerSuit : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ginger Suit");
			Tooltip.SetDefault("5% increased ranged damage");
		}
		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 18;
			item.value = 4500;
			item.rare = 2;
			item.defense = 7;
		}
		public override void UpdateEquip(Player player)
		{
			player.rangedDamage *= 1.05f;		
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "GingerCookie", 35);
			recipe.AddTile(null, "CookieWorkbench");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}