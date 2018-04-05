using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
	public class HoneyCrumbs : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Honey Crumbs");
			Tooltip.SetDefault("");
		}
		public override void SetDefaults()
		{
			// Alter any of these values as you see fit, but you should probably keep useStyle on 1, as well as the noUseGraphic and noMelee bools
			item.shoot = mod.ProjectileType<Projectiles.HoneyCrumbsProjectile>(); // Notice a newer way to get projectile types, much cleaner than using strings!
			item.shootSpeed = 10f;
			item.damage = 45;
			item.knockBack = 5f;
			item.thrown = true;
			item.useStyle = 1;
			item.UseSound = SoundID.Item1;
			item.useAnimation = 25;
			item.useTime = 25;
			item.width = 30;
			item.height = 30;
			item.maxStack = 999;
			item.consumable = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.autoReuse = true;
			item.value = Item.sellPrice(0, 0, 5, 0);
			item.rare = 2;
		}
		public override void AddRecipes()
        	{
            	ModRecipe recipe = new ModRecipe(mod);
            	recipe.AddIngredient(null, "HoneyCookie", 1);
				recipe.AddTile(null, "CookieWorkbench");   
            	recipe.SetResult(this, 20);
            	recipe.AddRecipe();
        	}
	}
}
