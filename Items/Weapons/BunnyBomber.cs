using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
    public class BunnyBomber : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bunny Bomber");
			Tooltip.SetDefault("Somehow the bullets aren't tearing it apart from the inside");
		}
        public override void SetDefaults()
        {
            item.damage = 12;  //gun damage
            item.ranged = true;   //its a gun so set this to true
            item.width = 40;     //gun image width
            item.height = 16;   //gun image  height
            item.useTime = 40;  //how fast 
            item.useAnimation = 40;
            item.useStyle = 5;    //
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 2;
            item.value = 1200;
            item.rare = 1;
            item.UseSound = SoundID.Item11;
            item.autoReuse = false;
            item.shoot = 10; //idk why but all the guns in the vanilla source have this
            item.shootSpeed = 13f;
            item.useAmmo = AmmoID.Bullet;
        }
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
			int numberProjectiles = 4 + Main.rand.Next(2); //This defines how many projectiles to shot. 4 + Main.rand.Next(2)= 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30)); // This defines the projectiles random spread . 30 degree spread.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        } 
        public override void AddRecipes()  //How to craft this gun
        {
           ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "BunnyFur", 12);   //you need 1 DirtBlock
	    recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}