using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class GoldBunnyBreastplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Golden Bunny Breastplate");
			Tooltip.SetDefault("Strongest garments fur can possibly create");
		}
		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 20;
			item.value = 4500;
			item.rare = 2;
			item.defense = 10;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "GoldBunnyFur", 20);
			recipe.AddIngredient(null, "BunnyBreastplate");
	    recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}