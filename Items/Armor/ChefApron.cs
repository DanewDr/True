using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class ChefApron : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chef's Apron");
			Tooltip.SetDefault("4% increased culinary damage");
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
			CookDamagePlayer modPlayer = CookDamagePlayer.ModPlayer(player);						
			modPlayer.cookDamage *= 1.05f;		
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 25);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}