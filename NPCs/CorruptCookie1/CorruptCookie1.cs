using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.NPCs.CorruptCookie1
{
	[AutoloadBossHead]
    public class CorruptCookie1 : ModNPC
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Corrupt Cookie");
			Main.npcFrameCount[npc.type] = 2; // make sure to set this for your modnpcs.
		}
        public override void SetDefaults()
        {
            npc.aiStyle = 5;  //5 is the flying AI
            npc.lifeMax = 3900;   //boss life
            npc.damage = 20;  //boss damage
            npc.defense = 16;    //boss defense
            npc.knockBackResist = 0f;
            npc.width = 158;
            npc.height = 72;
            animationType = NPCID.DemonEye;   //this boss will behavior like the DemonEye
            Main.npcFrameCount[npc.type] = 2;    //boss frame/animation 
            npc.value = Item.buyPrice(0, 5, 0, 0);
            npc.npcSlots = 1f;
            npc.boss = true;
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
            npc.HitSound = SoundID.Item2;
            npc.DeathSound = SoundID.NPCDeath13;			
            npc.buffImmune[24] = true;
            music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/CorruptCookie");
            npc.netAlways = true;
			bossBag = mod.ItemType("CorruptCookieTreasurebag");
        }
        


	
		public override void NPCLoot()
		{
			if (Main.expertMode)
			{
				npc.DropBossBags();
			}
			else
			{
				if (Main.rand.Next(7) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CorruptCookieMask"));
				}
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Cookie"), Main.rand.Next(15, 25));
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Milk"), Main.rand.Next(6, 10));
			}
			if (!CookieModWorld.downedCookieBoss)
			{				
				CookieModWorld.downedCookieBoss = true;			
			}
		}		
		public override void BossLoot(ref string name, ref int potionType)
		{
			name = "Corrupt Cookie";
			potionType = ItemID.LesserHealingPotion;
			if (Main.rand.Next(10) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CorruptCookie1Trophy"));
			}	
		}
		
        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.579f * bossLifeScale);  //boss life scale in expertmode
            npc.damage = (int)(npc.damage * 0.6f);  //boss damage increase in expermode
        }
        public override void AI()
        {
            npc.ai[0]++;
            Player P = Main.player[npc.target];
            if (npc.target < 0 || npc.target == 255 || Main.player[npc.target].dead || !Main.player[npc.target].active)
            {
                npc.TargetClosest(true);
            }
            npc.netUpdate = true;
			
			npc.ai[1]++;
            if (npc.ai[1] >= 230)  // 230 is projectile fire rate
            {
                float Speed = 20f;  //projectile speed
                Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
                int damage = 15;  //projectile damage
                int type = mod.ProjectileType("ProBoss");  //put your projectile
                Main.PlaySound(23, (int)npc.position.X, (int)npc.position.Y, 17);
                float rotation = (float)Math.Atan2(vector8.Y - (P.position.Y + (P.height * 0.5f)), vector8.X - (P.position.X + (P.width * 0.5f)));
                int num54 = Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), type, damage, 0f, 0);
                npc.ai[1] = 0;
			}	
			
			if (npc.ai[0] % 600 ==3)
			{
				NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, mod.NPCType("CookieWormHead"));
			}
			npc.ai[1] += 0;
		}
    }
}
