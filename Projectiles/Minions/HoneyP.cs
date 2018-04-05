using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Projectiles.Minions
{
    public class HoneyP : ModProjectile
    {
 		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Honey Stream");     //The English name of the projectile
		}        
        private int[] dusts = {160, 600, 64, 61, 50, 60, 590};
       
        public override void SetDefaults()
        {
            projectile.width = 6;
            projectile.height = 32;
            projectile.aiStyle = 0;
            projectile.alpha = 255;
            projectile.timeLeft = 150;
            projectile.friendly = true;
            projectile.tileCollide = true;
            projectile.ignoreWater = false;
            projectile.magic = true;          
            projectile.penetrate = 1;
        }
        public override void AI()
        {
            if (projectile.localAI[0] == 0f)
            {
                Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, 20);
                projectile.localAI[0] = 1f;
            }
			if (Main.rand.Next(2) == 0)
			{
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, mod.DustType("HoneyCrumbs"), projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
			}
        }
      public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
	     {
			        target.AddBuff(mod.BuffType("Honeyed"), 500);
		    }
    }
}
