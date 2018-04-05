using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items
{
    public class LivingFlower : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Living Flower");
			Tooltip.SetDefault("It seems friendly");
		}
        public override void SetDefaults()
        {
            item.width = 42;
            item.height = 42;
            item.value = 100;
            item.rare = 1;
            item.maxStack = 1;
        } 
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SoulofNight, 1);
			recipe.AddIngredient(ItemID.SoulofLight, 1);
			recipe.AddIngredient(ItemID.SoulofMight, 1);
			recipe.AddIngredient(ItemID.SoulofSight, 1);
			recipe.AddIngredient(ItemID.SoulofFright, 1);
			recipe.AddIngredient(ItemID.Sunflower, 1);
			recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
