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
    public class Cookie : CookClass
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cookie");
			Tooltip.SetDefault("This makes me feel, Happy!");
		}
        public override void SafeSetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.value = 100;
            item.rare = 1;
            item.maxStack = 999;
	    item.consumable = true;
            ItemID.Sets.ItemNoGravity[item.type] = false;  //this make that the item will float in air
	    item.ammo = item.type;
        }
 
       
 
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
 
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "DoughBall", 6);
	    recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
