using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.NPCs
{
    public class TheInfected : ModNPC
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Infected");
			Main.npcFrameCount[npc.type] = 2;
		}
        public override void SetDefaults()
        {
            npc.width = 42;
            npc.height = 80;
            npc.damage = 20;
            npc.defense = 10;
            npc.lifeMax = 100;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 60f;
            npc.knockBackResist = 0.5f;
            npc.aiStyle = 5;
            aiType = NPCID.Crimera;
            animationType = NPCID.Crimera;
			npc.noGravity = true;
        }
		public override void HitEffect(int hitDirection, double damage)
        {
            if (npc.life <= 0)
            {
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Infected1"), 1f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Infected2"), 1f);
            }
        }
        public override void FindFrame(int frameHeight)
        {
            npc.frameCounter -= 0.5F;
            npc.frameCounter %= Main.npcFrameCount[npc.type];
            int frame = (int)npc.frameCounter;
            npc.frame.Y = frame * frameHeight;

            npc.spriteDirection = npc.direction;
        }
        public override void NPCLoot()  //Npc drop
        {
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Rot"), Main.rand.Next (5, 8)); //Item spawn
            }
        }
		 public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {		
			return spawnInfo.player.ZoneCrimson ? 0.3f : 0f;
		}			
    }
}