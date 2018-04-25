using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class BunnyBreastplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bunny Breastplate");
			Tooltip.SetDefault("Giving you all the warmth of a bunny");
		}
		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 20;
			item.value = 4500;
			item.rare = 2;
			item.defense = 4;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "BunnyFur", 25);
	    recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}