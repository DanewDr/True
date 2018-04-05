
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
    public class Cheese : CookClass
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cheese");
			Tooltip.SetDefault("-Culinary Ingredient-");
		}
        public override void SafeSetDefaults()
        {
            item.width = 22;
            item.height = 20;
            item.value = 10;
            item.rare = 2;
            item.maxStack = 999;
			      item.consumable = true;
            item.value = 200;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Milk");
			      recipe.AddTile(TileID.CookingPots);
            recipe.SetResult(this, 3);
            recipe.AddRecipe();
        }
    }
}
