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
    public class HardboiledEgg : CookClass
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hardboiled Egg");
			Tooltip.SetDefault("Best used for making breakfast");
		}

        public override void SafeSetDefaults()
        {
            item.damage = 4;
            item.thrown = true;
            item.consumable = true;
            item.shoot = mod.ProjectileType ("HardboiledEgg");
            item.ammo = mod.ItemType("Batter");
            item.width = 20;
		    item.crit = 12;
            item.height = 26;
            item.value = 50;
            item.rare = 0;
            item.maxStack = 999;
	}   
/*        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Egg", 5);
	    recipe.AddIngredient(null, "Rot", 1);
	    recipe.SetResult(ItemID.RottenHardboiledEgg, 5);
            recipe.AddRecipe();
        }*/
    }
}
