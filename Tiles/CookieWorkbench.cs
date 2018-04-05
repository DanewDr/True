using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace CookieMod.Tiles
{
	public class CookieWorkbench : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolidTop[Type] = false;
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileTable[Type] = true;
			Main.tileLavaDeath[Type] = false;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3);
			TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 16 };
			TileObjectData.addTile(Type);
			AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTable);
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Cookie Factory");
			AddMapEntry(new Color(250, 250, 250), name);
			disableSmartCursor = true;
			animationFrameHeight = 56;
		}

		public override void NumDust(int i, int j, bool fail, ref int num)
		{
			num = fail ? 1 : 3;
		}

		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			Item.NewItem(i * 16, j * 16, 32, 16, mod.ItemType("CookieWorkbench"));
		}
		
 		public override void AnimateTile(ref int frame, ref int frameCounter)
        {
        	frameCounter++;
        	if (frameCounter > 5)  //this is the frames speed, the bigger is the value the slower are the frames
        	{
          		frameCounter = 0;
           		frame++;
           		if (frame > 2)   //this is where you add how may frames your spritesheet has but -1, so if it has 4 frames you put 3 etc.
           		{
           			frame = 0;
           		}
        	}
        }		
	}
}
