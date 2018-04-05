using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Placeable
{
	public class CrunchWoodChair : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crunch Chair");
			Tooltip.SetDefault("Probably not to comfortable");
		}
		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 34;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
			item.createTile = mod.TileType("CrunchWoodChair");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CrunchWood", 4);
			recipe.AddTile(TileID.WorkBenches);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
