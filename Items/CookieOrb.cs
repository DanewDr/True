using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CookieMod.Items
{
	public class CookieOrb : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Corrupt Cookie's Heart");
			Tooltip.SetDefault("Allows yout to double jump\nAllows the player to dash\nGives a slight thorns effect");
		}
		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = 10000;
			item.rare = 11;
			item.accessory = true;
			item.expert = true;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
            player.doubleJumpUnicorn = true;
			player.thorns = 0.1f;
			player.dash = 3;
		}
	}
}