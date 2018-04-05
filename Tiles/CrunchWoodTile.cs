using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
 
namespace CookieMod.Tiles
{
    public class CrunchWoodTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileBlockLight[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = false;      
            Main.tileLighted[Type] = true;
            drop = mod.ItemType("CrunchWood");   //this is what will drop when this block is destroyed.
            AddMapEntry(new Color(0, 0, 200));      
			minPick = 30;
        }
    }
}