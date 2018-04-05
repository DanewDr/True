using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Culinary
{
	public class SharkSoup : CookClass
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bowl of Shark Soup");
			Tooltip.SetDefault("Gives gills, <right> to eat!");
		}
		public override void SafeSetDefaults()
		{
			item.width = 22;
			item.height = 14;
      		item.damage = 10;
      		item.crit = 4;
			item.knockBack = 2;
      		item.UseSound = SoundID.Item3;
			item.maxStack = 30;
			item.rare = 1;
			item.consumable = true;
      		item.value = 400;
			item.shoot = mod.ProjectileType ("SharkSoup");
			item.ammo = mod.ItemType("BloodySoup");
		}
		public override bool CanRightClick()
		{
			return true;
		}

		public override void RightClick(Player player)
		{
			player.AddBuff(BuffID.Gills, 2700);
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bowl);
			recipe.AddIngredient(ItemID.SharkFin);
			recipe.AddIngredient(ItemID.Coral);
			recipe.AddTile(TileID.CookingPots);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}