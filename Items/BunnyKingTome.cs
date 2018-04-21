using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items
{
	public class BunnyKingTome : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bunny King's Tome");
			Tooltip.SetDefault("Summons a ridable Bunny King Chariot");
		}

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 32;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.value = 30000;
			item.rare = 2;
			item.UseSound = SoundID.Item79;
			item.noMelee = true;
			item.mountType = mod.MountType("Bunny");
			item.expert = true;			
		}
	}
}