using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
 
namespace CookieMod.Items
{
    public class CarrotJuice : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Carrot Juice");
			Tooltip.SetDefault("Increases eyesight");
		}
        public override void SetDefaults()
        {
        item.UseSound = SoundID.Item3;
        item.useStyle = 2;
        item.useTurn = true;
        item.useAnimation = 17;
        item.useTime = 17;
        item.maxStack = 30;
        item.width = 10;
        item.height = 10;
        item.buffType = mod.BuffType("CarrotJuice");
        item.buffTime = 1800;
	item.consumable = true;
        item.value = 50;
        item.holdStyle = 1;
        }
	public override void HoldStyle(Player player)
	{
	  player.itemLocation.X = player.Center.X + (float) (8 * player.direction);
          player.itemLocation.Y = player.MountedCenter.Y + 11f;
	}

    }
}
