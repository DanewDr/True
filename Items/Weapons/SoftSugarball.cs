using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
	public class SoftSugarball : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sugarball");
			Tooltip.SetDefault("Hurts quite a bit actually");
		}
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.Snowball);
			item.damage = 11;
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.rare = 2;
			item.consumable = true;
			item.knockBack = 1f;
			item.ammo = AmmoID.Snowball;
			item.shoot = mod.ProjectileType ("SoftSugarball");
		}
		public override void AddRecipes()
        	{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SugarDust", 20);
			recipe.SetResult(this, 15);
			recipe.AddTile(null, "CookieWorkbench");
			recipe.AddRecipe();
       		}
	}
}
