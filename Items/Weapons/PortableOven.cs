using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CookieMod.Items.Weapons
{
	public class PortableOven : CookClass 
	{
		public override void SetStaticDefaults()  
		{
			DisplayName.SetDefault("Portable Oven");
			Tooltip.SetDefault("");
		}
		public override void SafeSetDefaults()  
		{
			item.damage = 6;
			item.crit = 4;
			item.ranged = false;
			item.noMelee = true;
			item.width = 48;
			item.height = 30;
			item.rare = 2;
			item.useTime = 25;
			item.useAnimation = 25;
			item.UseSound = SoundID.Item10;
			item.useStyle = 5;
			item.noMelee = true;
			item.autoReuse = false;
			item.shoot = mod.ProjectileType ("ThrowingCookie");
			item.shootSpeed = 6f;
			item.useAmmo = mod.ItemType("Cookie");
		}
		public override void AddRecipes()         
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Furnace);
			recipe.AddRecipeGroup("IronBar", 2);
			recipe.SetResult(this);
			recipe.AddTile(TileID.WorkBenches);
			recipe.AddRecipe();
		}
	}
}