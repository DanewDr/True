using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Buffs
{
    public class WarmCozy : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffNoTimeDisplay[Type] = false;
 			DisplayName.SetDefault("Warm and Cozy");
			Description.SetDefault("Decreased melee abilities, increased defense");
			Main.debuff[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {                                             //
            player.statDefense += 15;  //
      	    player.meleeDamage -= .25f;
	    player.meleeSpeed -= .1f;
        }
    }
}
