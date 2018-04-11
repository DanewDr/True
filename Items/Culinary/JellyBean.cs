
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Culinary
{
	public class JellyBean : CookClass
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Jelly Bean");
			Tooltip.SetDefault("It's sticky!");
		}
		public override void SafeSetDefaults()
		{
			item.width = 16;
			item.height = 20;
      		item.damage = 4;
      		item.crit = 12;
      		item.UseSound = SoundID.Item2;
			item.maxStack = 30;
			item.rare = 0;
			item.consumable = true;
      		item.value = 20;
			item.shoot = mod.ProjectileType ("JellyBean");
			item.ammo = item.type;
		}
		public override bool CanRightClick()
		{
			return true;
		}

		public override void RightClick(Player player)
		{
			player.AddBuff(BuffID.Slimed, 600);
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel);
			recipe.AddTile(TileID.CookingPots);			
			recipe.SetResult(this, 3);
			recipe.AddRecipe();
		}
	}
}
