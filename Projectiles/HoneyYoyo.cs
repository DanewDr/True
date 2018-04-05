using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Projectiles
{
    public class HoneyYoyo : ModProjectile
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Honey Yoyo");     //The English name of the projectile
		}
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.WoodYoyo);
            projectile.penetrate = 5;  
            projectile.width = 16;
            projectile.height = 16;
			ProjectileID.Sets.YoyosLifeTimeMultiplier[projectile.type] = 4.5f;
			ProjectileID.Sets.YoyosMaximumRange[projectile.type] = 250f;			
        }
        
		public override void AI()
		{
			if (Main.rand.Next(2) == 0)
			{
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, mod.DustType("HoneyCrumbs"), projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
			}				
            Player player = Main.player[projectile.owner];
           
            if (projectile.ai[0] > 30)
            {
                projectile.timeLeft = 50;
            }
		}	
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
			target.AddBuff(mod.BuffType("Honeyed"),800);
        }
    }
}
