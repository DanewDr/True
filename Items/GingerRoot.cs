using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items
{
	public class GingerRoot : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ginger Root");
			Tooltip.SetDefault("Mmmh");
		}
		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 16;
			item.maxStack = 999;
			item.rare = 3;
		}
	}
}
