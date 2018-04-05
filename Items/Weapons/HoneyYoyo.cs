using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
    public class HoneyYoyo : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Honey Yoyo");
			Tooltip.SetDefault("");
		}
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.WoodYoyo);
			item.value = 1200;
            item.useStyle = 5;
            item.width = 24;
            item.height = 24;
            item.noUseGraphic = true;
            item.UseSound = SoundID.Item1;
            item.melee = true;
            item.channel = true;
            item.noMelee = true;
            item.shoot = 541;
            item.useAnimation = 25;
			item.damage = 20;
			item.rare = 2;
            item.useTime = 24;
            item.shootSpeed = 16f;
            item.shoot = mod.ProjectileType("HoneyYoyo");     
            item.knockBack = 3.75f;      			
        }

        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "HoneyCookie", 12);
			recipe.AddTile(null, "CookieWorkbench");	//exeample of how to craft with a modded item
            recipe.SetResult(this);
            recipe.AddRecipe();            
			
		}
    }
}
