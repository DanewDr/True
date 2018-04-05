using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Placeable
{
	public class CookieWorkbench : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cookie Factory");
			Tooltip.SetDefault("Used to craft cookie items");
		}
		public override void SetDefaults()
		{
			item.width = 44;
			item.height = 44;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 1000;
			item.createTile = mod.TileType("CookieWorkbench");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("IronBar", 4);
			recipe.AddRecipeGroup("CorruptBar", 6);
			recipe.AddIngredient(null, "DoughBall", 3);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}	
	}
}
