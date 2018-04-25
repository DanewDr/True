using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class BunnyMask : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bunny Mask");
			Tooltip.SetDefault("Looks familiar somehow...");
		}
		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 26;
			item.value = 2500;
			item.rare = 2;
			item.defense = 2;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("BunnyBreastplate") && legs.type == mod.ItemType("BunnyGreeves");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Increased Mobility";
			player.moveSpeed *= 1.5f;
			player.jumpBoost = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "BunnyFur", 15);
	    recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}