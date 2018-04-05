using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace CookieMod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class SugarHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sugar Helmet");
			Tooltip.SetDefault("5% increased magic damage");
		}
		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 22;
			item.value = 2500;
			item.rare = 2;
			item.defense = 6;
		}
		public override void UpdateEquip(Player player)
		{
			player.magicDamage *= 1.05f;		
		}
		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("SugarChainmail") && legs.type == mod.ItemType("SugarGreaves");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Increased Magic Damage\n+15% critical strike chance\n-15% mana cost";
			player.magicDamage *= 1.1f;
			player.magicCrit += 15;
			player.manaCost -= 0.15f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SugarCookie", 25);
			recipe.AddTile(null, "CookieWorkbench");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}