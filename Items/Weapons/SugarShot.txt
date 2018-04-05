using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons
{
    public class SugarShot : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sugar Shot");
			Tooltip.SetDefault("Rapidly fires sugar shots");
		}
        public override void SetDefaults()
        {         
            item.damage = 26;                        
            item.magic = true;                     //this make the item do magic 
            item.width = 24;
            item.height = 28;
            item.useTime = 7;
            item.useAnimation = 7;
            item.useStyle = 5;        //this is how the item is holded
            item.noMelee = true;        
            item.rare = 4;
            item.mana = 5;             //mana use
            item.UseSound = SoundID.Item21;            //this is the 
            item.autoReuse = true;
            item.shoot = mod.ProjectileType ("SugarShot");  //this make the item shoot 
            item.shootSpeed = 8f;    //projectile speed when shoot
        }      
	public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(null, "SugarDust", 25);
		recipe.AddIngredient(ItemID.SpellTome);
		recipe.AddIngredient(null, "CookieDust", 15);
		recipe.AddTile(TileID.Bookcases);
		recipe.SetResult(this);
		recipe.AddRecipe();
	}
    }
}
