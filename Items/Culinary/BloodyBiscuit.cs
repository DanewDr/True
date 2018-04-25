
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Culinary
{
	public class BloodyBiscuit : CookClass
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blood Biscuit");
			Tooltip.SetDefault("Gives food poisoning, <right> to eat!");
		}
		public override void SafeSetDefaults()
		{
			item.width = 16;
			item.height = 16;
  			item.damage = 13;
      			item.crit = 6;
      			item.UseSound = SoundID.Item2;
			item.maxStack = 30;
			item.rare = 1;
			item.consumable = true;
      			item.value = 900;
			item.useAnimation = 17;
        		item.useTime = 17;
			item.useStyle = 2;
			item.shoot = mod.ProjectileType ("BloodyBiscuit");
			item.ammo = mod.ItemType("Cookie");
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "DoughBall", 2);
			recipe.AddIngredient(ItemID.TissueSample, 3);
			recipe.AddTile(TileID.Furnaces);			
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
		}
		public override bool AltFunctionUse(Player player)
		{
			return true;
		}
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int 		    type, ref int damage, ref float knockBack)
		{
			return player.altFunctionUse == 2;
		}
		public override bool CanUseItem(Player player)
		{
			if(player.altFunctionUse != 2)
			{
				player.AddBuff(mod.BuffType("FoodPoisoning"), 5400);
			}
			return player.altFunctionUse != 2;
		}
	}
}
