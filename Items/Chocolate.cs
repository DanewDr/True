
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items
{
    public class Chocolate : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chocolate");
			Tooltip.SetDefault("The smell is so delightful");
		}
        public override void SetDefaults()
        {
	    item.maxStack = 99;
	    item.rare = 3;
        }
    }
}
