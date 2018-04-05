using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using Terraria.ModLoader;

namespace CookieMod
{
	// This class stores necessary player info for our custom damage class, such as damage multipliers and additions to knockback and crit.
	public class CookDamagePlayer : ModPlayer
	{
		public static CookDamagePlayer ModPlayer(Player player)
		{
			return player.GetModPlayer<CookDamagePlayer>();
		}

		// Vanilla only really has damage multipliers in code
		// And crit and knockback is usually just added to
		// As a modder, you could make separate variables for multipliers and simple addition bonuses
		public float cookDamage = 1f;
		public float cookKnockback = 0f;
		public int cookCrit = 0;

		public override void ResetEffects()
		{
			ResetVariables();
		}

		public override void UpdateDead()
		{
			ResetVariables();
		}

		private void ResetVariables()
		{
			cookDamage = 1f;
			cookKnockback = 0f;
			cookCrit = 0;
		}
	}
}