using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;

namespace CookieMod.Projectiles.Minions
{
    public class ChocolateMinion : ChocINFO
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chocolate Minion");     //The English name of the projectile
			ProjectileID.Sets.MinionTargettingFeature[projectile.type] = true;			
		}    	
        public override void SetDefaults()
        {
            projectile.width = 36;
            projectile.height = 17;
            projectile.netImportant = true;
            projectile.friendly = true;
            projectile.minionSlots = 1;
            projectile.alpha = 75;
            projectile.aiStyle = 26;
            projectile.timeLeft = 18000;
            Main.projFrames[projectile.type] = 6;
            ProjectileID.Sets.MinionSacrificable[projectile.type] = true;
            projectile.penetrate = -1;
            projectile.timeLeft *= 5;
            projectile.minion = true;
            aiType = 266;
            projectile.tileCollide = false;
        }
        public override void CheckActive()
        {
            Player player = Main.player[projectile.owner];
            MyPlayer modPlayer = (MyPlayer)player.GetModPlayer(mod, "MyPlayer");
            if (player.dead)
            {
                modPlayer.ChocMin = false;
            }
            if (modPlayer.ChocMin)
            {
                projectile.timeLeft = 2;
            }
        }

        public override void AI()
        {
        	bool flag64 = projectile.type == mod.ProjectileType("ChocolateMinion");
			Player player = Main.player[projectile.owner];
			MyPlayer modPlayer = player.GetModPlayer<MyPlayer>(mod);
			if (flag64)
			{
				if (player.dead)
				{
					modPlayer.ChocMin = false;
				}
				if (modPlayer.ChocMin)
				{
					projectile.timeLeft = 2;
				}
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
