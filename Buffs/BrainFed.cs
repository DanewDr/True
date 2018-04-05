using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Buffs
{
    public class BrainFed : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffNoTimeDisplay[Type] = false;
 			DisplayName.SetDefault("Brain Fed");
			Description.SetDefault("Increased culinary damage and crit chance!");
			Main.debuff[Type] = false;
        }
        public override void Update(Player player, ref int buffIndex)
        {                                             //
            CookDamagePlayer modPlayer = CookDamagePlayer.ModPlayer(player);
			      modPlayer.cookDamage += 0.03f;
            modPlayer.cookCrit += 3;
        }
    }
}
