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
    public class HoneyCookie : CookClass
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Honey Cookie");
			Tooltip.SetDefault("Positively ravishing!");
		}
        public override void SafeSetDefaults()
        {
            item.damage = 18;
	    item.consumable = true;
	    item.shoot = mod.ProjectileType ("ThrowingCookieHoney");
	    item.ammo = mod.ItemType("Cookie");
	    item.width = 20;
            item.height = 20;
            item.value = 100;
            item.rare = 1;
            item.maxStack = 999;
            ItemID.Sets.ItemNoGravity[item.type] = false;  //this make that the item will float in air
        }
 
       
 
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
 
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Cookie", 1);
	    recipe.needHoney = true;
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
