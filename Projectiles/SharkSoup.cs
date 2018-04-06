using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Projectiles
{
    public class SharkSoup : ModProjectile
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shark Soup");     //The English name of the projectile
		}		
        public override void SetDefaults()
        {
            projectile.width = 12;
            projectile.height = 12;
            projectile.friendly = true;
            projectile.ignoreWater = false;
            projectile.penetrate = -1;
            projectile.timeLeft = 125;
            projectile.extraUpdates = 3;
        }
 
        public override void AI()
        {
            if (projectile.timeLeft > 125)
            {
                projectile.timeLeft = 125;
            }
            if (projectile.ai[0] > 12f)
            {
			if (Main.rand.Next(2) == 0)
			{
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, mod.DustType("SharkSoup"), projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
			}
            }
            else
            {
                projectile.ai[0] += 1f;
            }
            return;
        }
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            projectile.Kill();
            return false;
        }
    }
}
