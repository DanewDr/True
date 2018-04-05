
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Buffs
{
    public class Merry : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffNoTimeDisplay[Type] = false;
 			      DisplayName.SetDefault("Merry");
			      Description.SetDefault("Increased melee abilities, lowered defense");
			      Main.debuff[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {                                             //
            player.AddBuff(mod.BuffType("Merry"), 1); //this is an example of how to add your own buff
	    player.AddBuff(BuffID.Confused, 1);
            player.statDefense -= 8;  //
      	    player.meleeDamage += .20f;
	    player.meleeSpeed += .20f;
        }
    }
}
