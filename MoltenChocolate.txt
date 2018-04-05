using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items
{
    public class MoltenChocolate : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Molten Chocolate");
			Tooltip.SetDefault("It burns with the heat of Hell");
		}
        public override void SetDefaults()
        {
			item.maxStack = 999;
			item.rare = 3;
        }
    }
}
