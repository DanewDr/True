using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Projectiles
{
    public class RottenKnife : ModProjectile
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ginger Knife");
		}
        public override void SetDefaults()
        {
            projectile.width = 10;
            projectile.height = 24;
            projectile.friendly = true;
            projectile.aiStyle = 1;
            projectile.thrown = true;
            projectile.penetrate = 12;
            projectile.extraUpdates = 1;
            aiType = ProjectileID.ThrowingKnife;
        }
 
		public override void AI()
		{
			if (Main.rand.Next(2) == 0)
			{
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, mod.DustType("RottenCrumbs"), projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
			}	           
                projectile.ai[0] += 1f;
            if (projectile.ai[0] >= 50f)
            {
                projectile.velocity.Y = projectile.velocity.Y + 0.15f;
                projectile.velocity.X = projectile.velocity.X * 0.99f;
            }
        }
        public override bool OnTileCollide(Vector2 oldVelocity)
        {                                                          
            {
                projectile.Kill();
 
                Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, 10);
            }
            return false;
        }
    }
}