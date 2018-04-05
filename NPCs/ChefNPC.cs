using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace CookieMod.NPCs
{
	[AutoloadHead]
	public class ChefNPC : ModNPC
	{
		public override string Texture
		{
			get
			{
				return "CookieMod/NPCs/ChefNPC";
			}
		}
		public override bool Autoload(ref string name)
		{
			name = "Chef";
			return mod.Properties.Autoload;
		}

		public override void SetStaticDefaults()
		{
			Main.npcFrameCount[npc.type] = 21;
			NPCID.Sets.ExtraFramesCount[npc.type] = 5;
//			NPCID.Sets.AttackFrameCount[npc.type] = 0;
			NPCID.Sets.DangerDetectRange[npc.type] = 700;
//			NPCID.Sets.AttackType[npc.type] = 0;
//			NPCID.Sets.AttackTime[npc.type] = 90;
//			NPCID.Sets.AttackAverageChance[npc.type] = 30;
			NPCID.Sets.HatOffsetY[npc.type] = 4;
		}

		public override void SetDefaults()
		{
			npc.townNPC = true;
			npc.friendly = true;
			npc.width = 18;
			npc.height = 40;
			npc.aiStyle = 7;
			npc.damage = 10;
			npc.defense = 15;
			npc.lifeMax = 250;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.knockBackResist = 0.5f;
			animationType = NPCID.GoblinTinkerer;
		}
        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {
            if (NPC.downedBoss1)  //so after the EoC is killed
            {
                return true;
            }
            return false;
        }
        public override bool CheckConditions(int left, int right, int top, int bottom)    //Allows you to define special conditions required for this town NPC's house
        {
            return true;  //so when a house is available the npc will  spawn
        }
		public override string TownNPCName()
		{
			switch (WorldGen.genRand.Next(4))
			{
				case 0:
					return "Zeff";
				case 1:
					return "Ramsay";
				case 2:
					return "HappyDays";
				default:
					return "Warren";
			}
		}

		public override void FindFrame(int frameHeight)
		{
			/*npc.frame.Width = 40;
			if (((int)Main.time / 10) % 2 == 0)
			{
				npc.frame.X = 40;
			}
			else
			{
				npc.frame.X = 0;
			}*/
		}

		public override string GetChat()
		{
			int dyeTrader = NPC.FindFirstNPC(NPCID.DyeTrader);
			int partyGirl = NPC.FindFirstNPC(NPCID.PartyGirl);
			int nurse = NPC.FindFirstNPC(NPCID.Nurse);
			if (dyeTrader >= 0 && Main.rand.Next(4) == 0)
			{
				return "Please don't tell " + Main.npc[dyeTrader].GivenName + " I sell dye ingredient foods.";
			}
			if (partyGirl >= 0 && Main.rand.Next(4) == 0)
			{
				return "How is a guy supposed to cook with " + Main.npc[partyGirl].GivenName + " getting confetti all over my food!";
			}
			if (nurse >= 0 && Main.rand.Next(6) == 0)
			{
				return "Don't look at me! I'm not " + Main.npc[nurse].GivenName + ", go crying to her!";
			}
			switch (Main.rand.Next(5))
			{
				case 0:
					return "I am the greatest chef in all the lands!";
				case 1:
					return "What is this 'Thorium Cook' you speak of?";
				case 2:
					return "Want to try my new cake recipe?";
				case 3:
					return "If you don't want to eat, that's fine with me. You'll scarecely get better than mud around here!";
				default:
					return "I don't have time to defend myself, I have food to cook!";
			}
		}
		public override void SetChatButtons(ref string button, ref string button2)
		{
			button = Language.GetTextValue("LegacyInterface.28");
		}

		public override void OnChatButtonClicked(bool firstButton, ref bool shop)
		{
			if (firstButton)
			{
				shop = true;
			}
		}

		public override void SetupShop(Chest shop, ref int nextSlot)
		{
			shop.item[nextSlot].SetDefaults(mod.ItemType("DoughBall"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("Cheese"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("Bread"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("Milk"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("Batter"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("Wafer"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.GreenMushroom);
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.TealMushroom);
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.BlueBerries);
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.PinkPricklyPear);
			nextSlot++;					
			if (NPC.downedBoss2) //Eater\Brain
			{				
				shop.item[nextSlot].SetDefaults(mod.ItemType("Cookie"));
				nextSlot++;
				shop.item[nextSlot].SetDefaults(mod.ItemType("CactusSoup"));
				nextSlot++;
				shop.item[nextSlot].SetDefaults(mod.ItemType("SauteedMushroom"));			
				nextSlot++;
			}
			if (CookieModWorld.downedCookieBoss)
			{				
				shop.item[nextSlot].SetDefaults(mod.ItemType("SugarDust"));
				nextSlot++;
				shop.item[nextSlot].SetDefaults(mod.ItemType("SugarCookie"));
				nextSlot++;
			}
			if (NPC.downedQueenBee)
			{
				shop.item[nextSlot].SetDefaults(mod.ItemType("Rot"));
				nextSlot++;
				shop.item[nextSlot].SetDefaults(mod.ItemType("RottenCookie"));
				nextSlot++;				
				shop.item[nextSlot].SetDefaults(mod.ItemType("SharkSoup"));
				nextSlot++;
			}
			if (NPC.downedBoss3) //Skeletron
			{				
				shop.item[nextSlot].SetDefaults(mod.ItemType("HoneyCookie"));
				nextSlot++;
			}
			if (CookieModWorld.downedBunny)
			{				
				shop.item[nextSlot].SetDefaults(mod.ItemType("GingerRoot"));
				nextSlot++;
				shop.item[nextSlot].SetDefaults(mod.ItemType("GingerCookie"));
				nextSlot++;
			}	
			if (Main.hardMode)
			{
				shop.item[nextSlot].SetDefaults(mod.ItemType("Chocolate"));
				nextSlot++;
				shop.item[nextSlot].SetDefaults(mod.ItemType("ChocolateCookie"));
				nextSlot++;			
			}
		}
/*		public override void TownNPCAttackStrength(ref int damage, ref float knockback)
		{
			damage = 20;
			knockback = 4f;
		}
		public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
		{
			cooldown = 30;
			randExtraCooldown = 30;
		}
		public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
		{
			projType = mod.ProjectileType("SparklingBall");
			attackDelay = 1;
		}

		public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
		{
			multiplier = 12f;
			randomOffset = 2f;
		}*/
	}
}	
