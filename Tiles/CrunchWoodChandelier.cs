using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
 
namespace CookieMod.Tiles
{
    public class CrunchWoodChandelier : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolidTop[Type] = false;
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
			Main.tileLighted[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2Top);
			TileObjectData.newTile.Width = 2;
			TileObjectData.newTile.Origin = new Point16(1, 0);
			AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTorch);
//			name.SetDefault("Crunch Chandelier");			
//            AddMapEntry(new Color(172, 119, 14), name);
            disableSmartCursor = true;
			TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16 };
            TileObjectData.addTile(Type);
        } 
        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 32, 16, mod.ItemType("CrunchWoodChandelier"));
        }
		
		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)   //light colors
        {
			r = 1.72f;
			g = 1.19f;
			b = 1.4f;
        }
    }
}