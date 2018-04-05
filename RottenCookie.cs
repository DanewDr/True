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
    public class RottenCookie : CookClass
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rotten Cookie");
			Tooltip.SetDefault("It's all gross!");
		}
        public override void SafeSetDefaults()
        {
            item.damage = 12;
	    item.consumable = true;
	    item.shoot = mod.ProjectileType ("ThrowingCookieRotten");
	    item.ammo = mod.ItemType("Cookie");
            item.width = 20;
            item.height = 20;
            item.value = 100;
            item.rare = 3;
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
            recipe.AddIngredient(null, "Cookie", 5);
			recipe.AddIngredient(null, "Rot", 3);
			recipe.AddTile(null, "CookieWorkbench");
            recipe.SetResult(this, 5);
            recipe.AddRecipe();
        }
    }
}
