using System;
using Terraria;
using Terraria.ModLoader;
 
namespace CookieMod.Buffs
{
    public class MinionBuff : ModBuff
    {
        public override void SetDefaults()
        {
 			DisplayName.SetDefault("That Thing's Buff");    
			Description.SetDefault("That Thing is Shooting at Your enemies!");
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
 
        }
 
        public override void Update(Player player, ref int buffIndex)
        {
            MyPlayer modPlayer = (MyPlayer)player.GetModPlayer(mod, "MyPlayer");
            if (player.ownedProjectileCounts[mod.ProjectileType("CookieMinion")] > 0)
            {
                modPlayer.CookieMinion = true;
            }
            if (!modPlayer.CookieMinion)
            {
                player.DelBuff(buffIndex);
                buffIndex--;
            }
            else
            {
                player.buffTime[buffIndex] = 18000;
            }
        }
    }
}
