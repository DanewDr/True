using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
	public class GingerBullet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ginger Bullet");
			Tooltip.SetDefault("");
		}
		public override void SetDefaults()
		{
			item.damage = 12;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 1.5f;
			item.value = 10;
			item.rare = 3;
			item.shoot = mod.ProjectileType("GingerBullet");   //The projectile shoot when your weapon using this ammo
			item.shootSpeed = 16f;                  //The speed of the projectile
			item.ammo = AmmoID.Bullet;              //The ammo class this ammo belongs to.
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MusketBall, 50);
			recipe.AddIngredient(null, "GingerCookie", 1);
			recipe.AddTile(null, "CookieWorkbench");
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}
