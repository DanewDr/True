using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items
{
    public class HallowedToolRod : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wallowed Tool Rod");
			Tooltip.SetDefault("Used to upgrade cookie swords");
		}

        public override void SetDefaults()
        {
	          item.width = 30;
            item.height = 30;
            item.value = 120;
            item.rare = 2;
            item.maxStack = 999;
	}   
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedBar, 8);
	    recipe.AddTile(TileID.MythrilAnvils);
	    recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
