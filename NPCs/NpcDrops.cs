using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.NPCs
{
    public class NpcDrops : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
     	{		
                if (Main.hardMode)     //this make the item drop only in hardmode
                {
				    if (Main.player[Main.myPlayer].ZoneDungeon)          //this is where you choose what biome you whant the item to drop. ZoneCorrupt is in Corruption
					    {
						    if (Main.rand.Next(9) == 0)      //this is the item rarity, so 9 = 1 in 10 chance that the npc will drop the item.
						    {
							    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GingerRoot"), Main.rand.Next(5, 10));//this is where you set what item to drop ,ItemID.VileMushroom is an example of how to add vanila items , Main.rand.Next(5, 10) it's the quantity,so it will chose a number from 5 to 10
						    }
					    }
				    }
			    else    //else if it's not hardmode this will happen
                {
                    if (Main.player[Main.myPlayer].ZoneDungeon)  //so again if the player is in corruption
                    {
                        if (Main.rand.Next(2) == 0)    //   the item has a 1 in 3 chance to drop
                        {
                            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GingerRoot"), Main.rand.Next(1, 5));
                        }
                    }
 
            }
            if (Main.player[Main.myPlayer].ZoneSnow)   
            {
                if (Main.rand.Next(1) == 0) 
                {
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SugarDust"), Main.rand.Next(1, 3));
                    }
                }
            }
			if (Main.hardMode)     
            {
				if (Main.player[Main.myPlayer].ZoneUnderworldHeight)          
					{
						if (Main.rand.Next(9) == 0)      
						{
							Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Chocolate"), Main.rand.Next(1, 5));
						}
					}
				}
			else    
            {
                if (Main.player[Main.myPlayer].ZoneUnderworldHeight)  
                {
                    if (Main.rand.Next(2) == 0)    
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Chocolate"), Main.rand.Next(1, 2));
                    }
                }
 
            }
            if (npc.type == NPCID.Bunny)   //this is where you choose the npc you want
            {
                if (Main.rand.Next(1) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
                {
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BunnyFur"), Main.rand.Next(1, 5));
                    }
                }
            }
           if (npc.type == NPCID.BunnySlimed)   //this is where you choose the npc you want
            {
                if (Main.rand.Next(1) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
                {
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BunnyFur"), Main.rand.Next(1, 5));
                    }
                }
            }
            if (npc.type == NPCID.BunnyXmas)   //this is where you choose the npc you want
            {
                if (Main.rand.Next(1) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
                {
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BunnyFur"), Main.rand.Next(1, 5));
                    }
                }
            }
            if (npc.type == NPCID.GoldBunny)   //this is where you choose the npc you want
            {
                if (Main.rand.Next(1) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
                {
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BunnyFur"), Main.rand.Next(10, 50));
                    }
                }
            }
            if (npc.type == NPCID.CrimsonBunny)   //this is where you choose the npc you want
            {
                if (Main.rand.Next(1) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
                {
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BunnyFur"), Main.rand.Next(1, 5));
                    }
                }
            }
            if (npc.type == NPCID.PartyBunny)   //this is where you choose the npc you want
            {
                if (Main.rand.Next(1) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
                {
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BunnyFur"), Main.rand.Next(5, 10));
                    }
                }
            }
            if (npc.type == NPCID.CorruptBunny)   //this is where you choose the npc you want
            {
                if (Main.rand.Next(1) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
                {
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BunnyFur"), Main.rand.Next(5, 10));
                    }
                }
            }
            if (Main.player[Main.myPlayer].ZoneCorrupt)   
            {
                if (Main.rand.Next(5) == 0) 
                {
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Rot"), Main.rand.Next(3, 5));
                    }
                }
            }			
        }
    }
}
