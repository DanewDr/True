using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Projectiles
{
    public class SuperSwirl : ModProjectile
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sweetnir Swirl");     //The English name of the projectile
		}
		public override void SetDefaults()
		{
			aiType = ProjectileID.NightBeam;
			projectile.melee = true;
			projectile.friendly = true;
		}


        }
 }
