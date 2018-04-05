using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
	public class RottenShuriken : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rotten Shurkien");
			Tooltip.SetDefault("");
		}
		public override void SetDefaults()
		{
			item.shoot = mod.ProjectileType<Projectiles.RottenShuriken>();
			item.shootSpeed = 15f;
			item.damage = 35;
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
			item.autoReuse = false;
			item.value = Item.sellPrice(0, 0, 5, 0);
			item.rare = 3;
		}
		public override void AddRecipes()
        	{
            	ModRecipe recipe = new ModRecipe(mod);
            	recipe.AddIngredient(null, "RottenCookie", 1);
				recipe.AddTile(null, "CookieWorkbench");   
            	recipe.SetResult(this, 20);
            	recipe.AddRecipe();
        	}
	}
}