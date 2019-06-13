using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Culinary
{
	public class BloodySoup : CookClass
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bowl of Blood Soup");
			Tooltip.SetDefault("Gives food poisoning");
		}
		public override void SafeSetDefaults()
		{
			item.width = 22;
			item.height = 14;
      		item.damage = 8;
      		item.crit = 4;
      		item.UseSound = SoundID.Item3;
			item.maxStack = 30;
			item.rare = 1;
			item.consumable = true;
      		item.value = 400;
			item.useAnimation = 17;
        	item.useTime = 17;
			item.useStyle = 2;
			item.shoot = mod.ProjectileType ("BloodySoup");
			item.ammo = item.type;
			item.buffType = mod.BuffType("FoodPoisoning");
			item.buffTime = 2700;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bowl);
			recipe.AddIngredient(ItemID.ViciousMushroom);
     		recipe.AddIngredient(ItemID.Vertebrae);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int 		    type, ref int damage, ref float knockBack)
		{
			return false;
		}
	}
}