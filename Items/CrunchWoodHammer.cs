using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items
{
    public class CrunchWoodHammer : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crunch Hammer");
			Tooltip.SetDefault("");
		}
        public override void SetDefaults()
        {
            item.damage = 5;
            item.melee = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 30;
            item.useAnimation = 25;
            item.hammer = 40;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 15;
            item.rare = 0;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "CrunchWood", 8);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }	
    }
}