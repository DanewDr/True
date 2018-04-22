
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Projectiles
{
    public class Egg : ModProjectile
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Egg");     //The English name of the projectile
		}
		public override void SetDefaults()
		{
			aiType = ProjectileID.RottenEgg;
			projectile.CloneDefaults(ProjectileID.RottenEgg);
			projectile.friendly = true;
			projectile.tileCollide = true;
			projectile.ignoreWater = false;
			projectile.penetrate = 1;
			projectile.extraUpdates = 1;
		}
		public override void Kill(int timeLeft)
		{
			for (int k = 0; k < 5; k++)
			{
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, mod.DustType("EggWhites"), projectile.oldVelocity.X * 0f, projectile.oldVelocity.Y * 0f);
			}
		}		
	}
}
