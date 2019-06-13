using Microsoft.Xna.Framework;
using Terraria;
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
			Tooltip.SetDefault("Crunchy and cheesy…");
		}
        public override void SafeSetDefaults()
        {
            item.width = 22;
            item.height = 24;
            item.damage = 17;
            item.value = 50;
            item.rare = 2;
            item.maxStack = 999;
            item.consumable = true;
            item.useAnimation = 17;
        	item.useTime = 17;
			item.useStyle = 2;
            item.shoot = mod.ProjectileType ("GrilledCheese");
            item.ammo = mod.ItemType("Batter");
            item.buffType = BuffID.WellFed;
			item.buffTime = 108000;
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
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int 		    type, ref int damage, ref float knockBack)
		{
			return false;
		}
    }
}
