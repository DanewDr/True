using Terraria;
using Terraria.ModLoader;

namespace CookieMod.Buffs
{
	public class ChocolateMinion : ModBuff
	{
		public override void SetDefaults()
		{
 			DisplayName.SetDefault("Chocolate Minion");
			Description.SetDefault("Is it just me, or does it look like a slime?");
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = true;
		}
		
		public override void Update(Player player, ref int buffIndex)
		{
			MyPlayer modPlayer = player.GetModPlayer<MyPlayer>(mod);
			if (player.ownedProjectileCounts[mod.ProjectileType("ChocolateMinion")] > 0)
			{
				modPlayer.ChocMin = true;
			}
			if (!modPlayer.ChocMin)
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
