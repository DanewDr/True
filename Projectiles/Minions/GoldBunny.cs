using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;

namespace CookieMod.Projectiles.Minions
{
    public class GoldBunny : GoldBunnyInfo
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Golden Bunny");     //The English name of the projectile
			ProjectileID.Sets.MinionTargettingFeature[projectile.type] = true;
		}    	
        public override void SetDefaults()
        {
            projectile.width = 48;
            projectile.height = 38;
            projectile.netImportant = true;
            projectile.friendly = true;
            projectile.minionSlots = 1;
            projectile.alpha = 0;
            projectile.aiStyle = 26;
            projectile.timeLeft = 18000;
            Main.projFrames[projectile.type] = 7;
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
                modPlayer.GBunMin = false;
            }
            if (modPlayer.GBunMin)
            {
                projectile.timeLeft = 2;
            }
        }

        public override void AI()
        {
        	bool flag64 = projectile.type == mod.ProjectileType("GoldBunny");
			Player player = Main.player[projectile.owner];
			MyPlayer modPlayer = player.GetModPlayer<MyPlayer>(mod);
			if (flag64)
			{
				if (player.dead)
				{
					modPlayer.GBunMin = false;
				}
				if (modPlayer.GBunMin)
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