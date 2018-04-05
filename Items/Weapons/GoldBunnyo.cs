using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
    public class GoldBunnyo : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Golden BunnYo");
			Tooltip.SetDefault("Actually the silkiest yoyo in all the lands");
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
			item.damage = 33;
			item.rare = 2;
            item.useTime = 25;
            item.shootSpeed = 16f;
            item.shoot = mod.ProjectileType("GoldBunnyo");         
        }

        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "GoldBunnyFur", 12);
			recipe.AddIngredient(null, "Bunnyo");
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();            
			
		}
    }
}