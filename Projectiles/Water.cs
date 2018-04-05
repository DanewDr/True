using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Projectiles
{
    public class Water : ModProjectile
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Water");     //The English name of the projectile
		}		
        public override void SetDefaults()
        {
            projectile.width = 12;
            projectile.height = 12;
            projectile.friendly = true;
            projectile.ignoreWater = true;
            projectile.penetrate = -1;
            projectile.timeLeft = 125;
            projectile.extraUpdates = 3;
			projectile.alpha = 255;
        }
 
        public override void AI()
        {
            if (projectile.timeLeft > 125)
            {
                projectile.timeLeft = 125;
            }
            if (projectile.ai[0] > 12f)
            {
			if (Main.rand.Next(1) == 0)
			{
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, mod.DustType("Water"), projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
			}
            }
            else
            {
                projectile.ai[0] += 1f;
            }
            return;
        }
 
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
			target.AddBuff(BuffID.Wet,1600);
        }
 
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            projectile.Kill();
            return false;
        }
    }
}