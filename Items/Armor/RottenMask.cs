using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace CookieMod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class RottenMask : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rotten Mask");
			Tooltip.SetDefault("5% increased throwing damage");
		}
		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 28;
			item.value = 2500;
			item.rare = 2;
			item.defense = 4;
		}
		public override void UpdateEquip(Player player)
		{
			player.thrownDamage *= 1.05f;		
		}
		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("RottenChestplate") && legs.type == mod.ItemType("RottenLeggings");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Increased Throwing Damage\n+5% critical strike chance";
			player.thrownDamage *= 1.1f;
			player.thrownCrit += 5;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "RottenCookie", 25);
			recipe.AddTile(null, "CookieWorkbench");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}