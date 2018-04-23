using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Buffs
{
    public class RabbitFoot : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffNoTimeDisplay[Type] = false;
 			DisplayName.SetDefault("Rabbit Instincts");
			Description.SetDefault("You have rabbit instincts!");
			Main.debuff[Type] = false;
        }
        public override void Update(Player player, ref int buffIndex)
        {                                             //
	    player.autoJump = true;
            player.jumpSpeedBoost = player.jumpSpeedBoost + 2.4f;
        }
    }
}
