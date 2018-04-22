using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CookieMod.Waters
{
	public class MilkWaterStyle : ModWaterStyle
	{
		public override bool ChooseWaterStyle()
		{
			return Main.bgStyle == mod.GetSurfaceBgStyleSlot("Cookie");
		}

		public override int ChooseWaterfallStyle()
		{
			return mod.GetWaterfallStyleSlot("MilkWaterfallStyle");
		}

		public override int GetSplashDust()
		{
			return mod.DustType("MilkWaterSplash");
		}

		public override int GetDropletGore()
		{
			return mod.GetGoreSlot("Gores/MilkDroplet");
		}

		public override void LightColorMultiplier(ref float r, ref float g, ref float b)
		{
			r = 1f;
			g = 1f;
			b = 1f;
		}

		public override Color BiomeHairColor()
		{
			return Color.White;
		}
	}
}