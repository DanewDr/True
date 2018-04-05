using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
	public class RolledDough : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rolled Dough");
			Tooltip.SetDefault("Perfectly round, like a snowball!");
		}
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.Snowball);
			item.damage = 6;
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.rare = 3;
			item.consumable = true;
			item.knockBack = 8f;
			item.ammo = AmmoID.Snowball;
			item.shoot = mod.ProjectileType ("RolledDough");
		}
		public override void AddRecipes()
        	{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "DoughBall", 1);
			recipe.SetResult(this, 15);
			recipe.AddTile(null, "CookieWorkbench");
			recipe.AddRecipe();
       		}
	}
}
