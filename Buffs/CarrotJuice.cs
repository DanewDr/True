using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Buffs
{
    public class CarrotJuice : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffNoTimeDisplay[Type] = false;
 			DisplayName.SetDefault("Far Seeing Eyes");
			Description.SetDefault("You can see farther!");
			Main.debuff[Type] = false;
        }
        public override void Update(Player player, ref int buffIndex)
        {                                             //
            player.scope = true;
        }
    }
}
