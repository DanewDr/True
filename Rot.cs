using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items
{
    public class Rot : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rot");
			Tooltip.SetDefault("A chunk of a horrid creature");
		}
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.value = 100;
            item.rare = 3;
            item.maxStack = 999;
        }
    }
}