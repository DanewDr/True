using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons
{
    public class CookieCrumbs : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cookie Crumbs");
			Tooltip.SetDefault("");
		}
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.value = 10;
            item.rare = 2;
            item.maxStack = 999;       //this is the max stack of this item
        }
        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Cookie", 1);
            recipe.AddTile(null, "CookieWorkbench");
            recipe.SetResult(this, 10);
            recipe.AddRecipe();
        }
    }
}
