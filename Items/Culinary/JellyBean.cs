
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
			item.useAnimation = 17;
        	item.useTime = 17;
			item.useStyle = 2;
			item.shoot = mod.ProjectileType ("JellyBean");
			item.ammo = item.type;
			item.buffType = BuffID.Slimed;
			item.buffTime = 600;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel);
			recipe.AddTile(TileID.CookingPots);			
			recipe.SetResult(this, 3);
			recipe.AddRecipe();
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int 		    type, ref int damage, ref float knockBack)
		{
			return false;
		}
	}
}
