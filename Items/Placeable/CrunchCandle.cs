using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Placeable
{
	public class CrunchCandle : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crunch Candle");
			Tooltip.SetDefault("");
		}
		public override void SetDefaults()
		{
			item.width = 60;
			item.height = 40;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 1000;
			item.createTile = mod.TileType("CrunchCandle");
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CrunchWood", 4);
			recipe.AddIngredient(null, "CookieTorch");
			recipe.AddTile(TileID.WorkBenches);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}	
	}
}