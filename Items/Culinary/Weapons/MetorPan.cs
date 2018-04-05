using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Culinary.Weapons
{
    public class MetorPan : CookClass
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Meteoric Frying Pan");
			Tooltip.SetDefault("Fries food instantly");
		}
        public override void SafeSetDefaults()
        {
            item.damage = 29;
            item.melee = true;
            item.width = 30;
            item.height = 30;
            item.useTime = 30;
            item.useAnimation = 30;     
            item.useStyle = 1;
            item.knockBack = 1;
			item.crit = 3;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType ("Pancake");
			item.shootSpeed = 9f;
			item.useAmmo = mod.ItemType("Batter");			
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);      
	   		recipe.AddIngredient(ItemID.MeteoriteBar, 8);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }	
    }
}