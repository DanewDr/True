using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
	public class RottenJavelin : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rotten Javelin");
			Tooltip.SetDefault("");
		}
		public override void SetDefaults()
		{
			item.shoot = mod.ProjectileType<Projectiles.RottenJavelin>();
			item.shootSpeed = 8f;
			item.damage = 24;
			item.knockBack = 5f;
			item.thrown = true;
			item.useStyle = 1;
			item.UseSound = SoundID.Item1;
			item.useAnimation = 25;
			item.useTime = 25;
			item.width = 42;
			item.height = 42;
			item.maxStack = 999;
			item.consumable = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.autoReuse = true;
			item.value = Item.sellPrice(0, 0, 5, 0);
			item.rare = 3;
		}
		public override void AddRecipes()
        {
           	ModRecipe recipe = new ModRecipe(mod);
           	recipe.AddIngredient(null, "RottenCookie", 1);
			recipe.AddTile(null, "CookieWorkbench");   
           	recipe.SetResult(this, 30);
           	recipe.AddRecipe();
        }
	}
}