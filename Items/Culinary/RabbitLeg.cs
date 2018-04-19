
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
    public class RawRabbitLeg : GlobalItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cooked Rabbit Leg");
			Tooltip.SetDefault("Who could even think of cooking this?!");
		}
        public override void SafeSetDefaults()
        {
            item.width = 18;
            item.height = 22;
            item.value = 75;
            item.rare = 0;
	    item.maxStack = 999;
	    item.damage = 2;
	    item.crit = 2;
	    item.consumable = true;
	    item.ammo = mod.ItemType("Cookie");
            item.shoot = mod.ProjectileType ("RabbitLeg");
	    
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "RawRabbitLeg", 3);
	    recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this, 3);
            recipe.AddRecipe();
        }
    }
}
