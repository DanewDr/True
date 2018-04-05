using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
    public class GingerThrow : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ginger Throw");
			Tooltip.SetDefault("");
		}
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.WoodYoyo);
			item.value = 1200;
            item.useStyle = 5;
            item.width = 30;
            item.height = 26;
            item.noUseGraphic = true;
            item.UseSound = SoundID.Item1;
            item.melee = true;
            item.channel = true;
            item.noMelee = true;
            item.shoot = 541;
            item.useAnimation = 25;
			item.damage = 22;
			item.rare = 3;
            item.useTime = 24;
            item.shootSpeed = 16f;
            item.shoot = mod.ProjectileType("GingerThrowP");         
        }

        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "GingerCookie", 12);
			recipe.AddTile(null, "CookieWorkbench");	//exeample of how to craft with a modded item
            recipe.SetResult(this);
            recipe.AddRecipe();            
			
		}
    }
}
