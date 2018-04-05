using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Culinary
{
	public class CactusSoup : CookClass
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bowl of Cactus Soup");
			Tooltip.SetDefault("Gives thorns, <right> to eat!");
		}
		public override void SafeSetDefaults()
		{
			item.width = 22;
			item.height = 14;
      		item.damage = 8;
      		item.crit = 10;
      		item.UseSound = SoundID.Item3;
			item.maxStack = 30;
			item.rare = 1;
			item.consumable = true;
      		item.value = 400;
			item.shoot = mod.ProjectileType ("CactusSoup");
			item.ammo = mod.ItemType("BloodySoup");
		}
		public override bool CanRightClick()
		{
			return true;
		}

		public override void RightClick(Player player)
		{
			player.AddBuff(BuffID.Thorns, 2700);
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bowl);
			recipe.AddIngredient(ItemID.Cactus, 2);
			recipe.AddTile(TileID.CookingPots);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}