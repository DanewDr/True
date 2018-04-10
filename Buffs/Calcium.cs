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
			Description.SetDefault("Your bones are stronger!");
        }
        public override void Update(Player player, ref int buffIndex)
        {                                             //
            player.statDefense += 2;  //
        }
    }
}
