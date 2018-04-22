using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.NPCs
{
    public class ZombieMilkman : ModNPC
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Zombie Milkman");
			Main.npcFrameCount[npc.type] = 3; // make sure to set this for your modnpcs.
		}
        public override void SetDefaults()
        {
            npc.width = 40;
            npc.height = 48;
            npc.damage = 10;
            npc.defense = 10;
            npc.lifeMax = 150;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath13;
            npc.value = 60f;
            npc.knockBackResist = 0.5f;
            npc.aiStyle = 3;
            aiType = NPCID.Zombie;  //npc behavior
            animationType = NPCID.Zombie;
        }
/*		public override void HitEffect(int hitDirection, double damage)
        {
            if (npc.life <= 0)
            {
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Addict1"), 1f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Addict2"), 1f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Addict3"), 1f);
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Addict4"), 1f);
            }
        }*/
        public override void NPCLoot()  //Npc drop
        {
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Milk"), Main.rand.Next (1, 4)); //Item spawn
            }
        }
		 public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {		
			return !Main.dayTime ? 0.09f : 0f;
		}			
    }
}