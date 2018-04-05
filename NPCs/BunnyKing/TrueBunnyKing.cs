using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.NPCs.BunnyKing
{
	[AutoloadBossHead]
    public class TrueBunnyKing : ModNPC
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bunny King");
			Main.npcFrameCount[npc.type] = 7; // make sure to set this for your modnpcs.
		}
        public override void SetDefaults()
        {
            npc.aiStyle = 25;  //5 is the flying AI
            npc.lifeMax = 7500;   //boss life
            npc.damage = 40;  //boss damage
            npc.defense = 6;    //boss defense
            npc.knockBackResist = 0f;
            npc.width = 56;
            npc.height = 52;
            animationType = NPCID.Bunny;   //this boss will behavior like the DemonEye 
            npc.value = Item.buyPrice(0, 5, 0, 0);
            npc.npcSlots = 1f;
            npc.boss = true;
            npc.lavaImmune = true;
            npc.noGravity = false;
            npc.noTileCollide = false;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.buffImmune[24] = true;
            music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/TrueBunnyKing");
            npc.netAlways = true;
			bossBag = mod.ItemType("BunnyKingTreasureBag");			
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
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BunnyKingMask"));
				}
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GoldBunnyFur"), Main.rand.Next(15, 25));
			}
			if (!CookieModWorld.downedBunny)
			{	
				CookieModWorld.downedBunny = true;	
			}				
		}		
		public override void BossLoot(ref string name, ref int potionType)
		{
			name = "Bunny King";
			if (Main.rand.Next(10) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BunnyKingTrophy"));
			}			
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
			
			if (npc.ai[0] % 300 ==3)
			{
				NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, mod.NPCType("BunnyWarrior"));
			}
			if (npc.ai[0] % 600 ==3)
			{
				NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, mod.NPCType("GoldenBunnyWarrior"));
			}	
			if (npc.ai[0] % 1200 ==3)
			{
				if (Main.expertMode)
				{	
					NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, mod.NPCType("TheChariot"));					
				}
			}			
			npc.ai[1] += 0;	
		}		
        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.579f * bossLifeScale);  //boss life scale in expertmode
            npc.damage = (int)(npc.damage * 0.6f);  //boss damage increase in expermode
        }
    }
}
