
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Projectiles
{
    public class BlueMuffin : ModProjectile
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blueberry Muffin");     //The English name of the projectile
		}
		public override void SetDefaults()
		{
			aiType = ProjectileID.WoodenArrowFriendly;
			projectile.CloneDefaults(ProjectileID.WoodenArrowFriendly);
			projectile.friendly = true;
			projectile.tileCollide = true;
			projectile.ignoreWater = false;
			projectile.penetrate = 1;
			projectile.width = 40;
			projectile.height = 26;
			projectile.extraUpdates = 1;
		}
        public override void AI()
        {            
			if (Main.rand.Next(8) == 0)
			{
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, mod.DustType("Dough"), projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
			}
		}
		public override void Kill(int timeLeft)
		{
			for (int k = 0; k < 5; k++)
			{
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, mod.DustType("Dough"), projectile.oldVelocity.X * 0f, projectile.oldVelocity.Y * 0f);
			}
		}		
	}
}
