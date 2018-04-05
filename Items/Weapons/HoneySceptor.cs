using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons           //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{
    public class HoneySceptor : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Honey Sceptor");
			Tooltip.SetDefault("Shoots a stream of honey to slow your foes");
		}		
        public override void SetDefaults()
        {
            item.damage = 12;
            item.magic = true;
            item.width = 48;
            item.height = 18;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 3.25f;
            item.UseSound = SoundID.Item34;
            item.value = 1000;
            item.rare = 2;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("HoneyStream");
            item.shootSpeed = 4.5f;
            item.mana = 5;			
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "HoneyCookie", 13);
            recipe.SetResult(this);
			recipe.AddTile(null, "CookieWorkbench"); 
            recipe.AddRecipe();
        }		
    }
}