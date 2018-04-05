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
    public class Bread : CookClass
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bread");
			Tooltip.SetDefault("Not for the ducks!");
		}
        public override void SafeSetDefaults()
        {
            item.width = 26;
            item.height = 24;
            item.damage = 12;
            item.value = 2;
            item.rare = 1;
            item.maxStack = 999;
	    item.consumable = true;
	    item.shoot = mod.ProjectileType ("BreadLoaf");
	    item.ammo = mod.ItemType("Cookie");
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "DoughBall", 3);
	    recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this, 6);
            recipe.AddRecipe();
        }
    }
}
