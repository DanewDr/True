using Terraria;
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
    public class Smore : CookClass
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("S'more");
			Tooltip.SetDefault("An American classic");
		}
        public override void SafeSetDefaults()
        {
            item.width = 34;
            item.height = 24;
            item.damage = 20;
            item.crit = 6;
            item.value = 500;
            item.rare = 1;
            item.maxStack = 30;
	        item.consumable = true;
            item.useAnimation = 17;
        	item.useTime = 17;
			item.useStyle = 2;
	        item.shoot = mod.ProjectileType ("Smore");
	        item.ammo = item.type;
            item.buffType = mod.BuffType("WarmCozy");
			item.buffTime = 7200;
              
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Wafer", 2);
            recipe.AddIngredient(ItemID.CookedMarshmallow);
            recipe.AddIngredient(null, "Chocolate", 4);
	         recipe.AddTile(TileID.Campfire);
            recipe.SetResult(this, 2);
            recipe.AddRecipe();
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int 		    type, ref int damage, ref float knockBack)
		{
			return false;
		}
    }
}
