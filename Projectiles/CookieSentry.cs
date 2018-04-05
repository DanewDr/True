using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Projectiles       
{
    public class CookieSentry : ModProjectile
    {
 		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cookie Sentry");
		}  
        public override void SetDefaults()
        {
            projectile.width = 40; 
            projectile.height = 40;   
            projectile.hostile = false;   
            projectile.friendly = true;   
            projectile.ignoreWater = true;
            Main.projFrames[projectile.type] = 1;
            projectile.timeLeft = 900;
            projectile.penetrate = -1;
            projectile.tileCollide = true;
            projectile.sentry = true;
        }
 
        public override void Kill(int timeLeft)
        { 
            Main.PlaySound(2, projectile.Center, 62);
        }
    }
}