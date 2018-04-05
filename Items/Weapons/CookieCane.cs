using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
	public class CookieCane : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cookie Cane");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.DD2ExplosiveTrapT1Popper);
			item.damage = 31;
			item.shoot = mod.ProjectileType("CookieSentry"); 
		}

/*		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DefenderMedal, 5);
			recipe.AddIngredient(null, "Cookie", 15);
			recipe.AddTile(null, "CookieWorkbench");
			recipe.SetResult(this);
			recipe.AddRecipe(); 
		} */
	}
}