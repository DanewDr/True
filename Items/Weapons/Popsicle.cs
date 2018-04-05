using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CookieMod.Items.Weapons
{
	public class Popsicle : CookClass
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Popsicle");
			Tooltip.SetDefault("");
		}
		public override void SafeSetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.rare = 2;
			item.consumable = true;
			item.ammo = item.type;
			item.shoot = mod.ProjectileType ("Popsicle");
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IceBlock);
			recipe.AddIngredient(ItemID.Wood);
			recipe.SetResult(this, 25);
			recipe.AddRecipe();
		}
	}
}
