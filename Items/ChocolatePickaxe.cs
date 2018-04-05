using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items 
{
	public class ChocolatePickaxe : ModItem
	{	
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chocolate Pickaxe");
		}
		public override void SetDefaults()
		{
			item.damage = 9;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 25;
			item.useAnimation = 25;
			item.pick = 65;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 1200;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(10) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("ChocolateCrumbs"));
			}
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ChocolateCookie", 12);
			recipe.AddTile(null, "CookieWorkbench");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}
