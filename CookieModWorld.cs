using System.IO;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World.Generation;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Generation;
using System.Linq;
using Terraria.ModLoader.IO; 
 
namespace CookieMod
{
    public class CookieModWorld : ModWorld
    {
		public static bool downedCookieBoss = false;	
		public static bool downedBunny = false;
		
		public static int customBiome = 0;
		public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int genIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
            if (genIndex == -1)
            {
                return;
            }
            tasks.Insert(genIndex + 1, new PassLegacy("Cookie Biome", delegate (GenerationProgress progress)
            {
                progress.Message = "Adding some cookie-fied dirt";
                for (int i = 0; i < Main.maxTilesX / 2600; i++)       //900 is how many biomes. the bigger is the number = less biomes
                {
                    int X = WorldGen.genRand.Next(Main.maxTilesX);
                    int Y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceHigh + 125);//this make the biome spawn on surface.
                    int TileType = mod.TileType("CookieDirtTile");     //this is the tile u want to use for the biome , if u want to use a vanilla tile then its int TileType = 56; 56 is obsidian block
 
                    WorldGen.TileRunner(X, Y, 1100, WorldGen.genRand.Next(100, 300), TileType, false, 0f, 0f, true, true);  //350 is how big is the biome     100, 200 this changes how random it looks.
                }
 
            }));
        }
		public override void TileCountsAvailable(int[] tileCounts)
        {
            customBiome = tileCounts[mod.TileType("CookieDirtTile")];       //this make the public static int customBiome counts as customtileblock
        }
        public static bool spawnSugar = false;
        public static bool spawnCookie = false;
		public override TagCompound Save()
        {
            var downed = new List<string>();
            if (downedBunny) downed.Add("downedBunny");
			if (downedCookieBoss) downed.Add("downedCookieBoss");
            return new TagCompound	{
                {"downed", downed},
			};				
        }
		public override void Load(TagCompound tag)
        {
            var downed = tag.GetList<string>("downed");
            downedBunny = downed.Contains("downedBunny");
			downedCookieBoss = downed.Contains("downedCookieBoss");
        }
		public override void NetSend(BinaryWriter writer)
		{
			BitsByte flags = new BitsByte();
			flags[0] = downedBunny; //+1 flag number for each new boss
			flags[1] = downedCookieBoss;
		}
		public override void NetReceive(BinaryReader reader)
		{
			BitsByte flags = reader.ReadByte();
			downedBunny = flags[0];
			downedCookieBoss = flags[1];
		}
		public override void LoadLegacy(BinaryReader reader)
        {
            int loadVersion = reader.ReadInt32();
            if(loadVersion == 1)
            {         
                byte flags=reader.ReadByte();
                CookieModWorld.downedBunny=((flags&1)!=0);
				CookieModWorld.downedCookieBoss=((flags&2)!=0); //double flag numbers with each new boss
            }
            else if(loadVersion == 2)
            {  
                byte flags=reader.ReadByte();
				byte flags2=reader.ReadByte();		
                CookieModWorld.downedBunny=((flags&1)!=0);
				CookieModWorld.downedCookieBoss=((flags&2)!=0);
            }
            
            
        }		
    }
}