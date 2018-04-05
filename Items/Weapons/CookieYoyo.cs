using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
    public class CookieYoyo : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cookie Yoyo");
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
			item.damage = 16;
			item.rare = 2;
            item.useTime = 25;
            item.shootSpeed = 16f;
            item.shoot = mod.ProjectileType("CookieYoyoP");         
        }

        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Cookie", 12);
			recipe.AddTile(null, "CookieWorkbench");	//exeample of how to craft with a modded item
            recipe.SetResult(this);
            recipe.AddRecipe();            
			
		}
        public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(10) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("Sparkle"));
			}
		}
    }
}
