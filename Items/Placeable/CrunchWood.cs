using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Placeable
{
	public class CrunchWood : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crunchwood");
			Tooltip.SetDefault("Don't understand why you'd think to eat it");
		}
		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 22;
			item.maxStack = 999;
			item.rare = 0;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("CrunchWoodTile");
		}
	}
}
