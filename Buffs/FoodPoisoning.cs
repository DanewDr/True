
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Buffs
{
    public class FoodPoisoning : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffNoTimeDisplay[Type] = false;
 	    DisplayName.SetDefault("Food Poisoning");
	    Description.SetDefault("Minor decreases to all stats");
            Main.debuff[Type] = true;
	    longerExpertDebuff = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {                                             //
	    player.statDefense -= 2;
	    player.meleeCrit -= 2;
	    player.rangedCrit -= 2;
	    player.thrownCrit -= 2;
	    player.magicCrit -= 2;
	    player.meleeSpeed -= .05f;
	    player.meleeDamage -= 1f;
    	    player.rangedDamage -= 1f;
            player.thrownDamage -= .05f;
            player.bulletDamage -= .05f;
  	    player.arrowDamage -= .05f;
    	    player.rocketDamage -= .05f;
    	    player.magicDamage -= .05f;
   	    player.minionDamage -= .05f;
	    player.minionKB -= .5f;
	    player.moveSpeed -= .5f;
        }
		public override void Update(NPC npc, ref int buffIndex)
		{
		  	npc.defense -= 2;
		}		
    }
}
