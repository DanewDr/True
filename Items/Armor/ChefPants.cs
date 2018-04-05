using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class ChefPants : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chef's Pants");
			Tooltip.SetDefault("3% increased culinary damage");
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
			CookDamagePlayer modPlayer = CookDamagePlayer.ModPlayer(player);						
			modPlayer.cookDamage *= 1.03f;		
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 20);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}