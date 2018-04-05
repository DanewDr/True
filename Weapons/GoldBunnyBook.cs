using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons
{
    public class GoldBunnyBook : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Golden Bunny Book");
			Tooltip.SetDefault("Shoots a bit more fur at your enemies");
		}
        public override void SetDefaults()
        {
            item.damage = 31;                        
            item.magic = true;
            item.width = 24;
            item.height = 28;
            item.useTime = 22;
            item.useAnimation = 22;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 10;        
            item.value = 1000;
            item.rare = 2;
            item.mana = 27;
            item.UseSound = SoundID.Item20;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType ("GoldBunnyBolt");
            item.shootSpeed = 10f;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			float numberProjectiles = 2;
            float rotation = MathHelper.ToRadians(5);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
            for (int i = 0; i < numberProjectiles; i++)
            {
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * 1f;
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }  		
	public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(null, "GoldBunnyFur", 11);
		recipe.AddIngredient(null, "BunnyBook");
		recipe.AddIngredient(ItemID.Book);
		recipe.AddTile(TileID.Bookcases);
		recipe.SetResult(this);
		recipe.AddRecipe();
	}
    }
}