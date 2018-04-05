using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons   //where is located
{
    public class GoldBunnyBlade : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Golden Bunny Blade");
			Tooltip.SetDefault("Reinforced by the Bunny King's Remains");
		}
        public override void SetDefaults()
        {
            item.damage = 36;
            item.melee = true;
            item.width = 30;
            item.height = 30;
            item.useTime = 24;
            item.useAnimation = 24;     
            item.useStyle = 1;
            item.knockBack = 0;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType ("GoldBunnyBolt");
			item.shootSpeed = 9f;			
        }
        public override void AddRecipes()  //How to craft this sword
        {
            ModRecipe recipe = new ModRecipe(mod);      
            recipe.AddIngredient(null, "GoldBunnyFur", 10);
			recipe.AddIngredient(null, "BunnyBlade");
	    recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }	
    }
}