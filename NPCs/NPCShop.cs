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
		    shop.item[nextSlot].SetDefaults(mod.ItemType("CookBook"));
		    shop.item[nextSlot].value = 50000;		
		    nextSlot++;
                }    
                break;
            }
        }
    }
}
