using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.NPCs
{
    public class GoldenBunnyWarrior : ModNPC
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Golden Bunny Warrior");
			Main.npcFrameCount[npc.type] = 7; // make sure to set this for your modnpcs.
		}
        public override void SetDefaults()
        {
            npc.width = 64;
            npc.height = 60;
            npc.damage = 40;
            npc.defense = 20;
            npc.lifeMax = 200;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 60f;
            npc.knockBackResist = 0.5f;
            npc.aiStyle = 26; 
            aiType = NPCID.Unicorn;  //npc behavior
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
