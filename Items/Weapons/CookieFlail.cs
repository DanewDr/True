using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
    public class CookieFlail : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cookie Crusher");
			Tooltip.SetDefault("Just a normal flail, like the ball of hurt!");
		}
        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = 2000;
            item.rare = 2;
			item.noMelee = true; // Makes sure that the animation when using the item doesn't hurt NPCs.
            item.useStyle = 5; // Set the correct useStyle.
            item.useAnimation = 40; // Determines how long the animation lasts. 
            item.useTime = 44; // Determines how fast you can use this weapon (a lower value results in a faster use time).
            item.knockBack = 6.5F;
            item.damage = 15;
            item.scale = 2F;
            item.noUseGraphic = true; // Do not use the item graphic when using the item (we just want the ball to spawn).
            item.shoot = mod.ProjectileType("CookieFlailP");
            item.shootSpeed = 12F;
            item.UseSound = SoundID.Item1;
            item.melee = true; // Deals melee damage.
            item.channel = true; // We can keep the left mouse button down when trying to keep using this weapon.
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Cookie", 20);
            recipe.AddTile(null, "CookieWorkbench");
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
