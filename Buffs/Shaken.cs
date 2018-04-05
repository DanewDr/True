
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Buffs
{
    public class Shaken : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffNoTimeDisplay[Type] = false;
 			      DisplayName.SetDefault("Shaken");
			      Description.SetDefault("Increased melee abilities, slightly lowered defense");
			      Main.debuff[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {                                             //
            player.statDefense -= 2;  //
      	    player.meleeDamage += .10f;
	          player.meleeSpeed += .10f;
        }
    }
}
