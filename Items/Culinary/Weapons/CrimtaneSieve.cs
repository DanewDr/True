using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Culinary.Weapons
{
    public class CrimtaneSieve : CookClass
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bloody Sieve");
			Tooltip.SetDefault("Shoots bloody dough at your foes");
		}
        public override void SafeSetDefaults()
        {
            item.damage = 10;
            item.melee = true;
            item.width = 30;
            item.height = 30;
            item.useTime = 15;
            item.useAnimation = 15;     
            item.useStyle = 1;
            item.knockBack = 0;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
            item.shoot = mod.ProjectileType ("CrimtaneDough");
			item.shootSpeed = 9f;
			item.useAmmo = mod.ItemType("DoughBall");			
        }
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
			int numberProjectiles = 12 + Main.rand.Next(8);
            for (int i = 0; i < numberProjectiles; i++)
            {
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(5));
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        } 		
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);      
			recipe.AddRecipeGroup("GildedSieve");
			recipe.AddIngredient(ItemID.CrimtaneBar, 5);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }	
    }
}