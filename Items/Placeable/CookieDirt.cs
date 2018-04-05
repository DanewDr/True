using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Placeable
{
    public class CookieDirt : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cookie Dirt");
		}
        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("CookieDirtTile"); //put your CustomBlock Tile name
        }
        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1);   //you need 10 Wood
			recipe.AddIngredient(null, "DoughBall", 2);
            recipe.AddTile(TileID.WorkBenches);   //at work bench
            recipe.SetResult(this, 2);
            recipe.AddRecipe();
        }
    }
}
