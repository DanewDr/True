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
    public class Wafer : CookClass
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wafer");
			Tooltip.SetDefault("-Culinary Ingredient-");
		}
        public override void SafeSetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.value = 5;
            item.rare = 0;
            item.maxStack = 999;
			      item.consumable = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "DoughBall");
			      recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this, 3);
            recipe.AddRecipe();
        }
    }
}
