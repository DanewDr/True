using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items
{
	public class CookieDust : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cookie Dust");
			Tooltip.SetDefault("");
		}
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 99;
			item.rare = 3;
		}
	}
}
