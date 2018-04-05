using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class GoldBunnyGreeves : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Golden Bunny Greaves");
			Tooltip.SetDefault("Jump even higher");
		}
		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 18;
			item.value = 35;
			item.rare = 2;
			item.defense = 9;
		}
		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.2f;
			player.jumpBoost = true;			
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "GoldBunnyFur", 15);
			recipe.AddIngredient(null, "BunnyGreeves");
	    recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}