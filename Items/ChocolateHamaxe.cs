using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items
{
	public class ChocolateHamaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chocolate Hamaxe");
			Tooltip.SetDefault("Chocolate cookie one side, pure chocolate the other");
		}

		public override void SetDefaults()
		{
			item.damage = 25;
			item.melee = true;
			item.width = 68;
			item.height = 52;
			item.useTime = 25;
			item.useAnimation = 25;
			item.axe = 15;
			item.hammer = 55;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 2000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

//		public override void AddRecipes()
//		{
//			ModRecipe recipe = new ModRecipe(mod);
//			recipe.AddIngredient(null, "Cookie", 20);
//			recipe.AddTile(null, "CookieWorkbench");
//			recipe.SetResult(this);
//			recipe.AddRecipe();
//			recipe = new ModRecipe(mod);
//			recipe.AddIngredient(null, "CookieAxe", 1);
//			recipe.AddIngredient(null, "CookieHammer", 1);
//			recipe.AddTile(null, "CookieWorkbench");
//			recipe.SetResult(this);
//			recipe.AddRecipe();
//		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(10) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("ChocolateCrumbs"));
			}
		}
	}
}
