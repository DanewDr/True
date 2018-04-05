using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class HoneyBreastplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Honey Breastplate");
			Tooltip.SetDefault("5% increased summon damage");
		}
		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 22;
			item.value = 4500;
			item.rare = 2;
			item.defense = 6;
		}
		public override void UpdateEquip(Player player)
		{
			player.minionDamage *= 1.05f;		
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "HoneyCookie", 35);
			recipe.AddTile(null, "CookieWorkbench");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}