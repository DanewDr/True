
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
    public class BlueMuffin : CookClass
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blueberry Muffin");
			Tooltip.SetDefault("Can be fried with a frying pan");
		}
        public override void SafeSetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.damage = 3;
            item.crit = 4;
            item.value = 75;
            item.rare = 1;
            item.maxStack = 999;
			      item.consumable = true;
			      item.ammo = mod.ItemType("Cookie");
            item.shoot = mod.ProjectileType ("BlueMuffin");
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "DoughBall", 4);
            recipe.AddIngredient(ItemID.BlueBerries);
			      recipe.AddTile(TileID.CookingPots);
            recipe.SetResult(this, 2);
            recipe.AddRecipe();
        }
    }
}
