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
    public class GrilledCheese : CookClass
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Grilled Cheese");
			Tooltip.SetDefault("Crunchy and cheesy...");
		}
        public override void SafeSetDefaults()
        {
            item.width = 22;
            item.height = 24;
            item.damage = 17;
            item.value = 100;
            item.rare = 2;
            item.maxStack = 999;
	          item.consumable = true;
	          item.shoot = mod.ProjectileType ("GrilledCheese");
	          item.ammo = mod.ItemType("Batter");
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Bread", 2);
            recipe.AddIngredient(null, "Cheese", 1);
	          recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this, 6);
            recipe.AddRecipe();
        }
    }
}
