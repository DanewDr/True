using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.NPCs
{
    public class BadCookie : ModNPC
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bad Cookie");
			Main.npcFrameCount[npc.type] = 2; // make sure to set this for your modnpcs.
		}
        public override void SetDefaults()
        {
            npc.width = 40;
            npc.height = 32;
            npc.damage = 10;
            npc.defense = 10;
            npc.lifeMax = 200;
            npc.HitSound = SoundID.Item2;
            npc.DeathSound = SoundID.NPCDeath13;
            npc.value = 60f;
            npc.knockBackResist = 0.5f;
            npc.aiStyle = 5;
            aiType = NPCID.DemonEye;  //npc behavior
            animationType = NPCID.DemonEye;
			npc.noGravity = true;
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
