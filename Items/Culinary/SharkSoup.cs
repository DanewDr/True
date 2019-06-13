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
			Tooltip.SetDefault("Gives gills");
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
			item.useAnimation = 17;
        	item.useTime = 17;
			item.useStyle = 2;
			item.shoot = mod.ProjectileType ("SharkSoup");
			item.ammo = mod.ItemType("BloodySoup");
			item.buffType = BuffID.Gills;
			item.buffTime = 2700;
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
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int 		    type, ref int damage, ref float knockBack)
		{
			return false;
		}
	}
}