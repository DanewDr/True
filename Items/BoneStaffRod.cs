
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items
{
    public class BoneStaffRod : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bone Staff Rod");
			Tooltip.SetDefault("Used to upgrade cookie staffs");
		}

        public override void SetDefaults()
        {
	          item.width = 30;
            item.height = 30;
            item.value = 120;
            item.rare = 2;
            item.maxStack = 999;
	}   
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Bone, 8);
	    recipe.AddTile(TileID.Anvils);
	    recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
