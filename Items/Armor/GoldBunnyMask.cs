using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class GoldBunnyMask : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Golden Bunny Mask");
			Tooltip.SetDefault("Looks Slightly less familiar...");
		}
		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 26;
			item.value = 2500;
			item.rare = 2;
			item.defense = 9;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("GoldBunnyBreastplate") && legs.type == mod.ItemType("GoldBunnyGreeves");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Increased Mobility";
			player.moveSpeed *= 2.5f;
			player.noFallDmg = true;
			player.autoJump = true;
			player.bunny = true;
            player.doubleJumpCloud = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "GoldBunnyFur", 10);
			recipe.AddIngredient(null, "BunnyMask");
	    recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}