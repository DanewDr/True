using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Placeable
{
	public class CrunchWoodSofa : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crunch Sofa");
			Tooltip.SetDefault("Don't think it will be comfortable to sit on");
		}
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 30;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
			item.createTile = mod.TileType("CrunchWoodSofa");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 2);
			recipe.AddIngredient(null, "CrunchWood", 5);
			recipe.AddTile(TileID.WorkBenches);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
