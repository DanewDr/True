using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons
{
    public class DoughTome : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dough Blow");
			Tooltip.SetDefault("Unleashes a giant ball of dough");
		}
        public override void SetDefaults()
        {         
            item.damage = 15;                        
            item.magic = true;                     //this make the item do magic 
            item.width = 24;
            item.height = 28;
            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = 5;        //this is how the item is holded
            item.noMelee = true;
            item.knockBack = 0;        
            item.rare = 2;
            item.mana = 10;             //mana use
            item.UseSound = SoundID.Item20;            //this is the 
            item.autoReuse = true;
            item.shoot = mod.ProjectileType ("GiantDough");  //this make the item shoot 
            item.shootSpeed = 7f;    //projectile speed when shoot
        }      
        public override void AddRecipes()
  		  {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(null, "DoughBall", 10);
        recipe.AddIngredient(ItemID.Book);
        recipe.SetResult(this);
        recipe.AddRecipe();
        }
    }
}
