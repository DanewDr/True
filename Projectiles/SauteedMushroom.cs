using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Projectiles
{
    public class SauteedMushroom : ModProjectile
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sauteed Mushroom");     //The English name of the projectile
		}
		public override void SetDefaults()
		{
			aiType = ProjectileID.MiniSharkron;
			projectile.width = 10;
			projectile.height = 12;
		}
		public override void AI()
		{
            if (projectile.localAI[0] == 0f)
            {
				Main.PlaySound(SoundID.Item1, projectile.position);
                projectile.localAI[0] = 1f;
            }	
		}			
	}		
}