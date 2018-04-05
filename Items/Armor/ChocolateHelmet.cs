using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace CookieMod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class ChocolateHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chocolate Helmet");
			Tooltip.SetDefault("5% increased melee damage");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 24;
			item.value = 2500;
			item.rare = 2;
			item.defense = 9;
		}
		public override void UpdateEquip(Player player)
		{
			player.meleeDamage *= 1.1f;		
		}
		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("ChocolateBreastplate") && legs.type == mod.ItemType("ChocolateLegs");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Increased Melee Damage\n+5% critical strike chance\n+15% melee speed";
			player.meleeDamage *= 1.1f;
			player.meleeCrit += 5;
			player.meleeSpeed += 0.15f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ChocolateCookie", 25);
			recipe.AddTile(null, "CookieWorkbench");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}