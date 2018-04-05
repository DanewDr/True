using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.NPCs
{
    public class BunnyWarrior : ModNPC
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bunny Warrior");
			Main.npcFrameCount[npc.type] = 7; // make sure to set this for your modnpcs.
		}
        public override void SetDefaults()
        {
            npc.width = 64;
            npc.height = 60;
            npc.damage = 20;
            npc.defense = 10;
            npc.lifeMax = 100;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 60f;
            npc.knockBackResist = 0.5f;
            npc.aiStyle = 1;
            aiType = NPCID.GreenSlime;  //npc behavior
            animationType = NPCID.Bunny;
			npc.noGravity = false;
        }

        public override void FindFrame(int frameHeight)
        {
            npc.frameCounter -= 0.5F; // Determines the animation speed. Higher value = faster animation.
            npc.frameCounter %= Main.npcFrameCount[npc.type];
            int frame = (int)npc.frameCounter;
            npc.frame.Y = frame * frameHeight;

            npc.spriteDirection = npc.direction;
        }
    }
}

