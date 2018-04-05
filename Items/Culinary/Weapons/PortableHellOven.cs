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
	public class PortableHellOven : CookClass 
	{
		public override void SetStaticDefaults()  
		{
			DisplayName.SetDefault("Mini Hellstone Furnace");
			Tooltip.SetDefault("Don't judge something by it's size...");
		}
		public override void SafeSetDefaults()  
		{
			item.damage = 16;
			item.crit = 4;
			item.ranged = false;
			item.noMelee = true;
			item.width = 34;
			item.height = 24;
			item.rare = 0;
			item.useTime = 17;
			item.useAnimation = 17;
			item.UseSound = SoundID.Item10;
			item.useStyle = 5;
			item.noMelee = true;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType ("ThrowingCookie");
			item.shootSpeed = 6f;
			item.useAmmo = mod.ItemType("Cookie");
      item.value = 800;
		}
		public override void AddRecipes()         
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Hellforge);
			recipe.AddIngredient(ItemID.HellstoneBar, 2);
			recipe.SetResult(this);
			recipe.AddTile(TileID.WorkBenches);
			recipe.AddRecipe();
		}
	}
}
