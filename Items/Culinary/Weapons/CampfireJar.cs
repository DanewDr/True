using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CookieMod.Items.Culinary.Weapons
{
	public class CampfireJar : CookClass 
	{
		public override void SetStaticDefaults()  
		{
			DisplayName.SetDefault("Campfire in a Jar");
			Tooltip.SetDefault("It's packed with smoke!");
		}
		public override void SafeSetDefaults()  
		{
			item.damage = 20;
			item.crit = 6;
			item.ranged = false;
			item.noMelee = true;
			item.width = 26;
			item.height = 20;
			item.rare = 0;
			item.useTime = 20;
			item.useAnimation = 20;
			item.UseSound = SoundID.Item10;
			item.useStyle = 5;
			item.noMelee = true;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType ("Smore");
			item.shootSpeed = 6f;
			item.useAmmo = mod.ItemType("Smore");
      item.value = 860;
		}
		public override void AddRecipes()         
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bottle);
			recipe.AddIngredient(ItemID.HellstoneBar, 6);
			recipe.SetResult(this);
			recipe.AddTile(TileID.Hellforge);
			recipe.AddRecipe();
		}
	}
}
