
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Projectiles
{
    public class HardboiledEgg : ModProjectile
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hardboiled Egg");     //The English name of the projectile
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
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, mod.DustType("Cheese"), projectile.oldVelocity.X * 0f, projectile.oldVelocity.Y * 0f);
			}
		}		
	}
}
