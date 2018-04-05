using Terraria;
using Terraria.ModLoader;

namespace CookieMod.Buffs
{
	public class Bunny : ModBuff
	{
		public override void SetDefaults()
		{
 			DisplayName.SetDefault("Bunny Warrior");
			Description.SetDefault("Tries to act threatening, but it's too cute");
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = true;
		}
		
		public override void Update(Player player, ref int buffIndex)
		{
			MyPlayer modPlayer = player.GetModPlayer<MyPlayer>(mod);
			if (player.ownedProjectileCounts[mod.ProjectileType("Bunny")] > 0)
			{
				modPlayer.BunMin = true;
			}
			if (!modPlayer.BunMin)
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