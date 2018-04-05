using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace 	CookieMod.Items.Weapons
{
    public class CookieBullet : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cookie Bullet");
			Tooltip.SetDefault("You don't even need an arms dealer!");
		}
        public override void SetDefaults()
        {
            item.damage = 12;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 1.5f;
            item.value = 5;
            item.rare = 2;
            item.shoot = mod.ProjectileType("CookieBullet");
            item.shootSpeed = 15f;
            item.ammo = AmmoID.Bullet;
        }
        public override void AddRecipes()  //How to craft this gun
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Cookie", 1);   //you need 1 DirtBlock
            recipe.AddTile(null, "CookieWorkbench");   //at work bench
            recipe.SetResult(this, 20);  //20 means how many bullets you craft from 1 dirt block
            recipe.AddRecipe();

        }
    }
}
