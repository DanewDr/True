using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Placeable
{
    public class CrunchWoodChandelier : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crunch Chandelier");
			Tooltip.SetDefault("");
		}	
        public override void SetDefaults()
        {
            item.width = 36;
            item.height = 36;
            item.maxStack = 999;
            item.value = Item.sellPrice(0, 0, 0, 0);
            item.rare = 0;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("CrunchWoodChandelier");
        }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CookieTorch", 4);
			recipe.AddIngredient(null, "CrunchWood", 4);
			recipe.AddIngredient(ItemID.Chain);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}