using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons
{
    public class ChocolateBlast : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chocolate Blast");
			Tooltip.SetDefault("Unleash the power of chocolate cookies");
		}
        public override void SetDefaults()
        {
            item.damage = 32;                        
            item.magic = true;                     //this make the item do magic 
            item.width = 24;
            item.height = 28;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 5;        //this is how the item is holded
            item.noMelee = true;
            item.knockBack = 10;        
            item.value = 1000;
            item.rare = 4;
            item.mana = 6;             //mana use
            item.UseSound = SoundID.Item21;            //this is the 
            item.autoReuse = true;
            item.shoot = mod.ProjectileType ("GiantCookie");  //this make the item shoot 
            item.shootSpeed = 8f;    //projectile speed when shoot
        }      
    }
}
