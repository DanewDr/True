using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons
{
    public class SugarStaff : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sugar Staff");
			Tooltip.SetDefault("Fires a blast of pure sugar energy!");
		}
        public override void SetDefaults()
        {         
            item.damage = 29;                        
            item.magic = true;                     //this make the item do magic 
            item.width = 24;
            item.height = 28;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5;        //this is how the item is holded
	    Item.staff[item.type] = true;
            item.noMelee = true;
            item.knockBack = 2f;        
            item.rare = 2;
            item.mana = 7;             //mana use
            item.UseSound = SoundID.Item20;            //this is the 
            item.autoReuse = true;
            item.shoot = mod.ProjectileType ("SugarBeam");  //this make the item shoot 
            item.shootSpeed = 8f;    //projectile speed when shoot
        }      
	public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(null, "SugarWand");
		recipe.AddIngredient(null, "BoneStaffRod");
		recipe.AddTile(null, "CookieWorkbench");
		recipe.SetResult(this);
		recipe.AddRecipe();
	}
    }
}
