using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Projectiles
{
    public class GingerThrowP : ModProjectile
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ginger Throw");     //The English name of the projectile
		}
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.WoodYoyo);
            projectile.penetrate = 5;  
            projectile.width = 16;
            projectile.height = 16;
			ProjectileID.Sets.YoyosLifeTimeMultiplier[projectile.type] = 5.5f;			
			ProjectileID.Sets.YoyosMaximumRange[projectile.type] = 300f;           
        }
        
		public override void AI()
		{
			if (Main.rand.Next(2) == 0)
			{
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, mod.DustType("GingerCrumbs"), projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
			}				
            Player player = Main.player[projectile.owner];
           
            if (projectile.ai[0] > 30)
            {
                projectile.timeLeft = 50;
            }
            

        }

    }
}
