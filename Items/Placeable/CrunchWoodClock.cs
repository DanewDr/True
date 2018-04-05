using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Placeable
{
	public class CrunchWoodClock: ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crunch Clock");
			Tooltip.SetDefault("Tells the time");
		}
		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 28;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 500;
			item.createTile = mod.TileType("CrunchClockTile");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Glass, 6);
			recipe.AddRecipeGroup("IronBar", 3);
			recipe.AddIngredient(null, "CrunchWood", 10);
			recipe.AddTile(TileID.WorkBenches);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
