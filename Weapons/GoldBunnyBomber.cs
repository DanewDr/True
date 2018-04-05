using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
    public class GoldBunnyBomber : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Golden Bunny Bomber");
			Tooltip.SetDefault("Shoots twice as many bullets, but takes twice as long to reload");
		}
        public override void SetDefaults()
        {
            item.damage = 30;
            item.ranged = true;
            item.width = 40;
            item.height = 16;
            item.useTime = 80;
            item.useAnimation = 80;
            item.useStyle = 5; 
            item.noMelee = true;
            item.knockBack = 2;
            item.value = 1200;
            item.rare = 2;
            item.UseSound = SoundID.Item11;
            item.autoReuse = false;
            item.shoot = 10;
            item.shootSpeed = 13f;
            item.useAmmo = AmmoID.Bullet;
        }
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
			int numberProjectiles = 8 + Main.rand.Next(4); //This defines how many projectiles to shot. 4 + Main.rand.Next(2)= 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30)); // This defines the projectiles random spread . 30 degree spread.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        } 
        public override void AddRecipes()
        {
           ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "GoldBunnyFur", 12);
			recipe.AddIngredient(null, "BunnyBomber");
	    recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}