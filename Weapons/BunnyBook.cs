using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons
{
    public class BunnyBook : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tome of the Bunny");
			Tooltip.SetDefault("Shoots a bit of fur at your enemies");
		}
        public override void SetDefaults()
        {
            item.damage = 11;                        
            item.magic = true;                     //this make the item do magic 
            item.width = 24;
            item.height = 28;
            item.useTime = 22;
            item.useAnimation = 22;
            item.useStyle = 5;        //this is how the item is holded
            item.noMelee = true;
            item.knockBack = 10;        
            item.value = 1000;
            item.rare = 1;
            item.mana = 27;             //mana use
            item.UseSound = SoundID.Item20;            //this is the 
            item.autoReuse = true;
            item.shoot = mod.ProjectileType ("BunnyBolt");  //this make the item shoot 
            item.shootSpeed = 8f;    //projectile speed when shoot
        }      
	public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(null, "BunnyFur", 11);
		recipe.AddIngredient(ItemID.Book);
		recipe.AddTile(TileID.Bookcases);
		recipe.SetResult(this);
		recipe.AddRecipe();
	}
    }
}