using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.NPCs.BunnyKing
{
	public class TheChariot : ModNPC
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Chariot");
			Main.npcFrameCount[npc.type] = 7;
		}
        public override void SetDefaults()
        {
            npc.aiStyle = 41;  //5 is the flying AI
            npc.lifeMax = 1000;   //boss life
            npc.damage = 20;  //boss damage
            npc.defense = 12;    //boss defense
            npc.knockBackResist = 0f;
            npc.width = 126;
            npc.height = 118;
            animationType = NPCID.Bunny;
            npc.npcSlots = 1f;
            npc.boss = false;
            npc.lavaImmune = false;
            npc.noGravity = false;
            npc.noTileCollide = false;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.buffImmune[24] = true;
            npc.netAlways = true;
        }		
        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.579f * bossLifeScale);  //boss life scale in expertmode
            npc.damage = (int)(npc.damage * 0.6f);  //boss damage increase in expermode
        }
    }
}