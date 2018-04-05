using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Culinary
{
	public class BrainFood : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Potion of Creativity");
			Tooltip.SetDefault("3% increased culinary damage and crit chance");
		}
		public override void SetDefaults()
		{
			item.rare = 1;
			item.value = 2000;
      item.useTime = 16;
      item.useAnimation = 16;     
      item.useStyle = 2;
      item.UseSound = SoundID.Item3;
      item.noMelee = true;
      item.autoReuse = false;
      item.width = 20;
      item.height = 30;
      item.buffType = mod.BuffType("BrainFed");
      item.buffTime = 7200;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(ItemID.NeonTetra);
      recipe.AddIngredient(ItemID.Moonglow);
			recipe.AddTile(TileID.Bottles);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
