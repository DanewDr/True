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
	public class DemonitePot : CookClass 
	{
		public override void SetStaticDefaults()  
		{
			DisplayName.SetDefault("Demonite Pot");
			Tooltip.SetDefault("");
		}
		public override void SafeSetDefaults()  
		{
			item.damage = 14;
			item.crit = 5;
			item.knockBack = 1f;
			item.ranged = false;
			item.noMelee = true;
			item.width = 48;
			item.height = 30;
			item.rare = 2;
			item.useTime = 20;
			item.useAnimation = 20;
			item.UseSound = SoundID.Item34;
			item.useStyle = 5;
			item.noMelee = true;
			item.autoReuse = false;
			item.shoot = mod.ProjectileType ("BloodySoup");
			item.shootSpeed = 6f;
			item.useAmmo = mod.ItemType("BloodySoup");
		}
		public override void AddRecipes()         
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DemoniteBar, 9);
			recipe.SetResult(this);
			recipe.AddTile(TileID.Anvils);
			recipe.AddRecipe();
		}
	}
}