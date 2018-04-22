using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CookieMod.Tiles
{
    public class Creamstone : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileLighted[Type] = true;
            drop = mod.ItemType("Creamstone");
            AddMapEntry(new Color(172, 119, 14));
        }
    }
}