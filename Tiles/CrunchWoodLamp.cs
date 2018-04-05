using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
 
namespace CookieMod.Tiles
{
    public class CrunchWoodLamp : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolidTop[Type] = false;
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
			Main.tileLighted[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
    //        AddMapEntry(new Color(255, 191, 0), "Crunch Lamp");
			TileObjectData.newTile.Origin = new Point16(1, 0);
            disableSmartCursor = true;
			TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 18 };
			AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTorch);
            TileObjectData.addTile(Type);
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 32, 16, mod.ItemType("CrunchWoodLamp"));
        }
		
		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)   //light colors
        {
			r = 1.72f;
			g = 1.19f;
			b = 1.4f;
        }
    }
}