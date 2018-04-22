using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items
{
	public class BrownSolution : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Brown Solution");
			Tooltip.SetDefault("Used by the Clentaminator"
				+ "\nSpreads the Cookie Plains");
		}

		public override void SetDefaults()
		{
			item.shoot = mod.ProjectileType("BrownSolution") - ProjectileID.PureSpray;
			item.ammo = AmmoID.Solution;
			item.width = 12;
			item.height = 14;
			item.value = Item.buyPrice(0, 0, 25, 0);
			item.rare = 3;
			item.maxStack = 999;
			item.consumable = true;
		}
	}
}