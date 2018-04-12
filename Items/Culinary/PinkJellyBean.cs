
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Culinary
{
	public class PinkJellyBean : CookClass
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pink Jelly Bean");
			Tooltip.SetDefault("It's super sticky!");
		}
		public override void SafeSetDefaults()
		{
			item.width = 16;
			item.height = 20;
      		item.damage = 9;
      		item.crit = 7;
      		item.UseSound = SoundID.Item2;
			item.maxStack = 30;
			item.rare = 1;
			item.consumable = true;
      		item.value = 100;
			item.shoot = mod.ProjectileType ("PinkJellyBean");
			item.ammo = mod.ItemType("JellyBean");
		}
		public override bool CanRightClick()
		{
			return true;
		}

		public override void RightClick(Player player)
		{
			player.AddBuff(BuffID.Lovestruck, 600);
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PinkGel);
			recipe.AddTile(TileID.CookingPots);			
			recipe.SetResult(this, 9);
			recipe.AddRecipe();
		}
	}
}
