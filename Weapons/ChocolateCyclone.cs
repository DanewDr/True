using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons
{
    public class ChocolateCyclone : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chocolate Cyclone");
			Tooltip.SetDefault("Sprays a cyclone of chocolate");
		}
        public override void SetDefaults()
        {
            item.damage = 53;                        
            item.magic = true;                     //this make the item do magic 
            item.width = 24;
            item.height = 28;
            item.useTime = 22;
            item.useAnimation = 22;
            item.useStyle = 5;        //this is how the item is holded
            item.noMelee = true;
            item.knockBack = 10;        
            item.value = 1000;
            item.rare = 4;
            item.mana = 27;             //mana use
            item.UseSound = SoundID.Item20;            //this is the 
            item.autoReuse = true;
            item.shoot = mod.ProjectileType ("ChocolateCyclone");  //this make the item shoot 
            item.shootSpeed = 6f;    //projectile speed when shoot
        }      
	public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(null, "ChocolateCookie", 5);
		recipe.AddIngredient(ItemID.SpellTome);
		recipe.AddIngredient(ItemID.SoulofFright, 5);
		recipe.AddTile(TileID.Bookcases);
		recipe.SetResult(this);
		recipe.AddRecipe();
	}
    }
}
