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
    public class Batter : CookClass
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Batter");
			Tooltip.SetDefault("Can be fried with a frying pan");
		}
        public override void SafeSetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.value = 15;
            item.rare = 1;
            item.maxStack = 999;
			item.consumable = true;
			item.ammo = item.type;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "DoughBall", 3);
			recipe.AddTile(TileID.CookingPots);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
