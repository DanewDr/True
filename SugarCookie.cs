using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace CookieMod.Items
{
    public class SugarCookie : CookClass
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sugar Cookie");
			Tooltip.SetDefault("Warm and toasty");
		}

        public override void SafeSetDefaults()
        {
            item.damage = 14;
	    item.consumable = true;
	    item.shoot = mod.ProjectileType ("ThrowingCookieSugar");
	    item.ammo = mod.ItemType("Cookie");
	    item.width = 20;
            item.height = 20;
            item.value = 100;
            item.rare = 2;
            item.maxStack = 999;
	}   
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Cookie", 5);
	    recipe.AddIngredient(null, "SugarDust", 1);
	    recipe.AddTile(null, "CookieWorkbench");
	    recipe.SetResult(this, 5);
            recipe.AddRecipe();
        }
    }
}
