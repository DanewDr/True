using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace CookieMod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class HoneyHorn : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Honey Horn");
			Tooltip.SetDefault("5% increased summon damage");
		}
		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 22;
			item.value = 2500;
			item.rare = 2;
			item.defense = 5;
		}
		public override void UpdateEquip(Player player)
		{
			player.minionDamage *= 1.05f;		
		}
		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("HoneyBreastplate") && legs.type == mod.ItemType("HoneyLeggings");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Increased Summon Damage + max number of minions";
			player.minionDamage *= 1.1f;
			player.maxMinions++;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "HoneyCookie", 25);
			recipe.AddTile(null, "CookieWorkbench");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}