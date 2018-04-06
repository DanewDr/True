using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace CookieMod.Items.Culinary
{
    public class Bread : CookClass
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bread");
			Tooltip.SetDefault("-Culinary Ingredient-");
		}
        public override void SafeSetDefaults()
        {
            item.width = 26;
            item.height = 24;
            item.value = 2;
            item.rare = 0;
            item.maxStack = 999;
	    item.consumable = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "DoughBall", 3);
	    recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this, 6);
            recipe.AddRecipe();
        }
    }
}
