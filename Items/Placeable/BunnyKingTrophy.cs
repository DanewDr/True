using Terraria.ModLoader;

namespace CookieMod.Items.Placeable
{
	public class BunnyKingTrophy : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bunny King Trophy");
			Tooltip.SetDefault("");
		}
		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;			
			item.rare = 1;
			item.createTile = mod.TileType("BunnyKingTrophy");
			item.placeStyle = 0;
		}
	}
}
