using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items
{
    public class DoughBall : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dough Ball");
			Tooltip.SetDefault("Used to craft cookies");
		}
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.value = 100;
            item.rare = 1;
            item.maxStack = 999;
			item.ammo = item.type;
			item.consumable = true;			
        }
    public override void AddRecipes()
  		{
       ModRecipe recipe = new ModRecipe(mod);
       recipe.AddIngredient(null, "CookieDirt", 1);
       recipe.SetResult(this, 2);
       recipe.AddRecipe();
    }
    }
}
