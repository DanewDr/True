
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
    public class CookieAddict : ModNPC
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cookie Addict");
			Main.npcFrameCount[npc.type] = 3; // make sure to set this for your modnpcs.
		}
        public override void SetDefaults()
        {
            npc.width = 40;
            npc.height = 48;
            npc.damage = 10;
            npc.defense = 10;
            npc.lifeMax = 200;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath13;
            npc.value = 60f;
            npc.knockBackResist = 0.5f;
            npc.aiStyle = 3;
            aiType = NPCID.Zombie;  //npc behavior
            animationType = NPCID.Zombie;
        }
		 public override void HitEffect(int hitDirection, double damage)
        {
            if (npc.life <= 0)          //this make so when the npc has 0 life(dead) he will spawn this
            {
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Addict1"), 1f);   //make sure you put the right folder name where your gores is located and the right name of gores
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Addict2"), 1f);     // 1f is the gore sprite size, you can change it but i suggest to keep it to 1f
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Addict3"), 1f);
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Addict4"), 1f);
            }
        }
		public override float SpawnChance (NPCSpawnInfo spawnInfo)		
		{
			if (spawnInfo.player.GetModPlayer<MyPlayer>(mod).ZoneCookieBiome);
			{			
				return !Main.dayTime && Main.tile[(spawnInfo.spawnTileX), (spawnInfo.spawnTileY)].type == mod.TileType("CookieDirtTile") ? 0.5f : 0f;
			}	
		}
        public override void NPCLoot()  //Npc drop
        {
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DoughBall"), 8); //Item spawn
            }

        }
    }
}
