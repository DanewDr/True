using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.NPCs
{
    public class NPCShop : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            switch (type)
            {
                case NPCID.Merchant:  
                {
                    shop.item[nextSlot].SetDefaults(mod.ItemType("Milk"));
                    nextSlot++;
					shop.item[nextSlot].SetDefaults(mod.ItemType("CookBook"));
					nextSlot++;
                }    
                break;
            }
        }
    }
}
