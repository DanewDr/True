using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons
{
    public class PopRocker : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pop Rocker");
			Tooltip.SetDefault("Fires a rock candy pellet");
		}
        public override void SetDefaults()
        {          
            item.damage = 30;                        
            item.magic = true;                     //this make the item do magic 
            item.width = 24;
            item.height = 28;
            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = 5;        //this is how the item is holded
            item.noMelee = true;        
            item.rare = 3;
            item.mana = 15;             //mana use
            item.UseSound = SoundID.Item20;            //this is the 
            item.autoReuse = true;
            item.shoot = mod.ProjectileType ("PopRockBeam");  //this make the item shoot 
            item.shootSpeed = 5f;    //projectile speed when shoot
        }      
	public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(null, "HardSugarDust", 25);
		recipe.AddIngredient(ItemID.Book);
		recipe.AddTile(TileID.Bookcases);
		recipe.SetResult(this);
		recipe.AddRecipe();
	}
    }
}
