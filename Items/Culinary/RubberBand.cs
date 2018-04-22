using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Culinary
{
	public class RubberBand : CookClass
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rubber Band");
			Tooltip.SetDefault("Increased culinary knockback");
		}
		public override void SafeSetDefaults()
		{
			item.rare = 2;
			item.accessory = true;
			item.value = 10000;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			CookDamagePlayer modPlayer = CookDamagePlayer.ModPlayer(player);
			modPlayer.cookKnockback += 3f;
		}
	}
}