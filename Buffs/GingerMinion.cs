using System;
using Terraria;
using Terraria.ModLoader;
 
namespace CookieMod.Buffs
{
    public class GingerMinion : ModBuff
    {
        public override void SetDefaults()
        {
 			DisplayName.SetDefault("Ginger Cookie");    
			Description.SetDefault("A sentient cookie that charges at your foes");
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
 
        }
 
        public override void Update(Player player, ref int buffIndex)
        {
            MyPlayer modPlayer = (MyPlayer)player.GetModPlayer(mod, "MyPlayer");
            if (player.ownedProjectileCounts[mod.ProjectileType("GingerMinion")] > 0)
            {
                modPlayer.GingerMinion = true;
            }
            if (!modPlayer.GingerMinion)
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