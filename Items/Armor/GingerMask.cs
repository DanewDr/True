using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace CookieMod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class GingerMask : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ginger Mask");
			Tooltip.SetDefault("5% increased ranged damage");
		}
		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 20;
			item.value = 2500;
			item.rare = 2;
			item.defense = 6;
		}
		public override void UpdateEquip(Player player)
		{
			player.rangedDamage *= 1.05f;		
		}
		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("GingerSuit") && legs.type == mod.ItemType("GingerGreaves");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Increased Ranged Damage\n+20% increased critical strike chance";
			player.rangedDamage *= 1.1f;
			player.rangedCrit += 20;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "GingerCookie", 25);
			recipe.AddTile(null, "CookieWorkbench");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}