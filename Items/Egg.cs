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
    public class Egg : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Egg");
			Tooltip.SetDefault("Best used for making breakfast");
		}

        public override void SafeSetDefaults()
        {
            item.damage = 6;
            item.thrown = true;
	          item.consumable = true;
	          item.shoot = mod.ProjectileType ("EggYolk");
	          item.ammo = mod.ItemType("Batter");
	          item.width = 20;
            item.height = 26;
            item.value = 50;
            item.rare = 0;
            item.maxStack = 999;
	}   
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Egg", 5);
	    recipe.AddIngredient(null, "Rot", 1);
	    recipe.SetResult(ItemID.RottenEgg, 5);
            recipe.AddRecipe();
        }
    }
}
