using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Projectiles.Minions
{
    public class GingerMinion : GingerInfo
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ginger Cookie");     //The English name of the projectile
			ProjectileID.Sets.MinionTargettingFeature[projectile.type] = true;			
		}      	
        public override void SetDefaults()
        {
			projectile.CloneDefaults(ProjectileID.DeadlySphere);
			aiType = ProjectileID.DeadlySphere;
            Main.projFrames[projectile.type] = 21;
            projectile.width = 24;
            projectile.height = 24;			
        }
        public override void CheckActive()
        {
            Player player = Main.player[projectile.owner];
            MyPlayer modPlayer = (MyPlayer)player.GetModPlayer(mod, "MyPlayer");
            if (player.dead)
            {
                modPlayer.GingerMinion = false;
            }
            if (modPlayer.GingerMinion)
            {
                projectile.timeLeft = 2;
            }
        }        
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            if (projectile.penetrate == 0)
            {
                projectile.Kill();
            }
            return false;
        }
    }
}
