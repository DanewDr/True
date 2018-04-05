using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.NPCs.BloodCookie
{
	[AutoloadBossHead]
    public class BloodCookie : ModNPC
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blood Cookie");
			Main.npcFrameCount[npc.type] = 4; // make sure to set this for your modnpcs.
		}
        public override void SetDefaults()
        {
            npc.aiStyle = 4;  //5 is the flying AI
            npc.lifeMax = 4000;   //boss life
            npc.damage = 40;  //boss damage
            npc.defense = 20;    //boss defense
            npc.knockBackResist = 0f;
            npc.width = 338;
            npc.height = 170;
            animationType = NPCID.Harpy;   //this boss will behavior like the DemonEye
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
			bossBag = mod.ItemType("BloodCookieTreasurebag");
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
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BloodCookieMask"));
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
			name = "Blood Cookie";
			potionType = ItemID.LesserHealingPotion;
			if (Main.rand.Next(10) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BloodCookieTrophey"));
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
				
			if (npc.ai[0] % 600 == 3)  //Npc spown rate
			
            {
                NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, mod.NPCType("BadCookie"));  //NPC name
			}	
            npc.ai[1] += 0;
			
		}
    }
}
