using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class GoldHat : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gilded Chef's Hat");
			Tooltip.SetDefault("5% increased culinary damage");
		}
		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 28;
			item.value = 2500;
			item.rare = 2;
			item.defense = 5;
		}
		public override void UpdateEquip(Player player)
		{
			CookDamagePlayer modPlayer = CookDamagePlayer.ModPlayer(player);			
			modPlayer.cookDamage *= 1.05f;		
		}
		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("GoldApron") && legs.type == mod.ItemType("GoldPants");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Increased Culinary Damage\n+10% critical strike chance";
			CookDamagePlayer modPlayer = CookDamagePlayer.ModPlayer(player);						
			modPlayer.cookDamage *= 1.15f;
			modPlayer.cookCrit += 10;
			modPlayer.cookKnockback += 5;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "GoldBunnyFur", 10);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}