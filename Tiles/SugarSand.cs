using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CookieMod.Tiles
{
    public class SugarSand : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileLighted[Type] = true;
            drop = mod.ItemType("SugarSand");   //put your CustomBlock name
            AddMapEntry(new Color(172, 119, 14));
//			SetModTree(new CookieTreeTile());
        }
 /*       public override int SaplingGrowthType(ref int style)
        {
            style = 0;
            return mod.TileType("CookieTreeSaplingTile");        //this make the spaling spawn the custom tree/sapling on this block/tile.    change CustomSaplingTile with u'r sapling name
        }*/
    }
}