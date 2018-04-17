using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.NPCs
{
    public class ChefDrops : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
     	{		
 
            if (npc.type == NPCID.Bird)   //this is where you choose the npc you want
            {
                if (Main.rand.Next(3) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
                {
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType(“Egg”), Main.rand.Next(1, 3));
                    }
                }
            }
            if (npc.type == NPCID.BirdBlue)   //this is where you choose the npc you want
            {
                if (Main.rand.Next(2) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
                {
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType(“Egg”), Main.rand.Next(2, 4));
                    }
                }
            }
            if (npc.type == NPCID.BirdRed)   //this is where you choose the npc you want
            {
                if (Main.rand.Next(2) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
                {
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType(“Egg”), Main.rand.Next(2, 4));
                    }
                }
            }
            if (npc.type == NPCID.GoldBird)   //this is where you choose the npc you want
            {
                if (Main.rand.Next(1) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
                {
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType(“Egg”), Main.rand.Next(3, 6));
                    }
                }
            }
        }
    }
}
