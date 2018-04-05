using Terraria.ID;
using Terraria.ModLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CookieMod.Items.Culinary.Weapons
{
	public class CrimtanePot : CookClass 
	{
		public override void SetStaticDefaults()  
		{
			DisplayName.SetDefault("Crimtane Pot");
			Tooltip.SetDefault("");
		}
		public override void SafeSetDefaults()  
		{
			item.damage = 15;
			item.crit = 4;
			item.knockBack = 1f;
			item.ranged = false;
			item.noMelee = true;
			item.width = 48;
			item.height = 30;
			item.rare = 2;
			item.useTime = 21;
			item.useAnimation = 21;
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
			recipe.AddIngredient(ItemID.CrimtaneBar, 9);
			recipe.SetResult(this);
			recipe.AddTile(TileID.Anvils);
			recipe.AddRecipe();
		}
	}
}