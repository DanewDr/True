using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;
using Terraria.ID;

namespace CookieMod.Items.Weapons
{
    public class HoneyBow : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Honey Bow");
			Tooltip.SetDefault("");
		}
        public override void SetDefaults()
        {
            item.damage = 14;
            item.noMelee = true;
            item.ranged = true;
            item.width = 20;
            item.height = 40;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 5;
            item.shoot = 3;
            item.useAmmo = AmmoID.Arrow;
            item.knockBack = 1;
            item.value = 800;
            item.rare = 2;
            item.UseSound = SoundID.Item5;
            item.autoReuse = true;
            item.shootSpeed = 6.7f;

        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "HoneyCookie", 8);
			recipe.AddTile(null, "CookieWorkbench");   
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
