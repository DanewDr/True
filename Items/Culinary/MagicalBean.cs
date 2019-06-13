
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
			item.useAnimation = 17;
        	item.useTime = 17;
			item.useStyle = 2;
			item.shoot = mod.ProjectileType ("MagicalBean");
			item.ammo = mod.ItemType("JellyBean");
			item.buffType = BuffID.Shine;
			item.buffTime = 600;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PixieDust, 9);
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
