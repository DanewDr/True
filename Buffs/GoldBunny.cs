using Terraria;
using Terraria.ModLoader;

namespace CookieMod.Buffs
{
	public class GoldBunny : ModBuff
	{
		public override void SetDefaults()
		{
 			DisplayName.SetDefault("Gold Bunny Warrior");
			Description.SetDefault("Tries to act even more threatening, but it's even cuter");
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = true;
		}
		
		public override void Update(Player player, ref int buffIndex)
		{
			MyPlayer modPlayer = player.GetModPlayer<MyPlayer>(mod);
			if (player.ownedProjectileCounts[mod.ProjectileType("GoldBunny")] > 0)
			{
				modPlayer.GBunMin = true;
			}
			if (!modPlayer.GBunMin)
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