using Terraria.ModLoader;

namespace CookieMod.Items.Placeable
{
	public class CorruptCookie1Trophy : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Corrupt Cookie Trophy");
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
			item.rare = 2;
			item.createTile = mod.TileType("CorruptCookie1Trophey");
			item.placeStyle = 0;
		}
	}
}
