
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
 
namespace CookieMod.Items.Culinary
{
    public class BlueMuffin : CookClass
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blueberry Muffin");
			Tooltip.SetDefault("Minor improvements to all stats /n`Just like grandma used to make.`");
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
	    item.useAnimation = 17;
            item.useTime = 17;
	    item.useStyle = 2;
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
	public override bool AltFunctionUse(Player player)
	{
		return true;
	}
	public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int 		    type, ref int damage, ref float knockBack)
	{
		return player.altFunctionUse == 2;
	}
	public override bool CanUseItem(Player player)
	{
		if(player.altFunctionUse != 2)
		{
			player.AddBuff(BuffID.WellFed, 54000);
		}
		return player.altFunctionUse != 2;
	}
    }
}
