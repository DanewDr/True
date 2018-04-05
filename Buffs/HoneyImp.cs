using System;
using Terraria;
using Terraria.ModLoader;

namespace CookieMod.Buffs
{
	public class HoneyImp : ModBuff
	{
		public override void SetDefaults()
		{
 			DisplayName.SetDefault("Honey Imp");
			Description.SetDefault("Here to slow your foes");
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = true;
		}
		
		public override void Update(Player player, ref int buffIndex)
		{
			MyPlayer modPlayer = player.GetModPlayer<MyPlayer>(mod);
			if (player.ownedProjectileCounts[mod.ProjectileType("HoneyImp")] > 0)
			{
				modPlayer.HoneyImp = true;
			}
			if (!modPlayer.HoneyImp)
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
