using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Buffs
{
    public class Calcium : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffNoTimeDisplay[Type] = false;
 			DisplayName.SetDefault("Calcium");
			Description.SetDefault("Your bones defense feels like they have been increased by 10");
        }
        public override void Update(Player player, ref int buffIndex)
        {                                             //
            player.AddBuff(mod.BuffType("Calcium"), 1); //this is an example of how to add your own buff
            player.statDefense += 10;  //
        }
    }
}
