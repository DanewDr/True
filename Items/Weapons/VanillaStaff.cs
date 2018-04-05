using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons
{
    public class VanillaStaff : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Vanilla Staff");
			Tooltip.SetDefault("Two worlds collide");
		}
        public override void SetDefaults()
        {         
            item.damage = 37;                        
            item.magic = true;                     //this make the item do magic 
            item.width = 24;
            item.height = 28;
            item.useTime = 22;
            item.useAnimation = 22;
            item.useStyle = 5;        //this is how the item is holded
	    Item.staff[item.type] = true;
            item.noMelee = true;
            item.knockBack = 2f;        
            item.value = 1000;
            item.rare = 2;
            item.mana = 4;             //mana use
            item.UseSound = SoundID.Item20;            //this is the 
            item.autoReuse = true;
            item.shoot = mod.ProjectileType ("MixedChocolate");  //this make the item shoot 
            item.shootSpeed = 9f;    //projectile speed when shoot
        }      
	public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(null, "ChocolateStave");
		recipe.AddIngredient(null, "SugarStaff");
    		recipe.AddIngredient(ItemID.SoulofSight, 15);
		recipe.AddTile(null, "CookieWorkbench");
		recipe.SetResult(this);
		recipe.AddRecipe();
	}
    }
}
