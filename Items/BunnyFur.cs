using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items
{
    public class BunnyFur : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bunny Fur");
			Tooltip.SetDefault("Why you kill bunny?");
		}

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.value = 10;
            item.rare = 1;
            item.maxStack = 999;
       }
    }
}
