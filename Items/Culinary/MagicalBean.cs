
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Culinary
{
	public class MagicalBean : CookClass
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Magical Bean");
			Tooltip.SetDefault("It shines with magic.");
		}
		public override void SafeSetDefaults()
		{
			item.width = 16;
			item.height = 20;
      		item.damage = 16;
      		item.crit = 4;
      		item.UseSound = SoundID.Item2;
			item.maxStack = 30;
			item.rare = 1;
			item.consumable = true;
      		item.value = 500;
			item.shoot = mod.ProjectileType ("MagicalBean");
			item.ammo = mod.ItemType("JellyBean");
		}
		public override bool CanRightClick()
		{
			return true;
		}

		public override void RightClick(Player player)
		{
			player.AddBuff(BuffID.Shine, 600);
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PixieDust, 9);
			recipe.AddTile(TileID.CookingPots);			
			recipe.SetResult(this, 3);
			recipe.AddRecipe();
		}
	}
}
