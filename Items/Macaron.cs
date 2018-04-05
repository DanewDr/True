using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items
{
    public class Macaron : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Macaron");
			Tooltip.SetDefault("Can be enchanted with souls");
		}
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.value = 100;
            item.rare = 1;
            item.maxStack = 999;
        } 
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "DoughBall", 6);
			recipe.AddIngredient(null, "Milk", 1);
	    recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this, 6);
            recipe.AddRecipe();
        }
    }
}
