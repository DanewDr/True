using Terraria;
using Terraria.ModLoader;

namespace CookieMod.Buffs
{
	public class BunnyMount : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Bunny King's Chariot");
			Description.SetDefault("It now answers to you");
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.mount.SetMount(mod.MountType<Mounts.Bunny>(), player);
			player.buffTime[buffIndex] = 10;
		}
	}
}
