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
    public class FriedEgg : CookClass
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fried Egg");
			Tooltip.SetDefault("Egg whites are everywhere!");
		}

        public override void SafeSetDefaults()
        {
            item.damage = 8;
            item.consumable = true;
            item.shoot = mod.ProjectileType ("EggYolk");
            item.ammo = mod.ItemType("Batter");
            item.width = 16;
            item.height = 16;
            item.value = 50;
            item.rare = 0;
            item.maxStack = 30;
	}   
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Egg", 5);
	        recipe.SetResult(this, 5);
            recipe.AddRecipe();
        }
    }
}
