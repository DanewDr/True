using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
	public class HardSugarball : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hardened Sugarball");
			Tooltip.SetDefault("This packs quite a punch");
		}
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.Snowball);
			item.damage = 25;
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.rare = 3;
			item.consumable = true;
			item.knockBack = 8f;
			item.ammo = AmmoID.Snowball;
			item.shoot = mod.ProjectileType ("HardSugarball");
		}
		public override void AddRecipes()
        	{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "HardSugarDust", 10);
			recipe.AddIngredient(null, "SoftSugarball", 15);
			recipe.SetResult(this, 15);
			recipe.AddTile(null, "CookieWorkbench");
			recipe.AddRecipe();
       		}
	}
}
