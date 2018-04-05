using Terraria.ID;
using Terraria.ModLoader;

namespace 	CookieMod.Items.Weapons
{
    public class HoneyArrow : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Honey Arrow");
			Tooltip.SetDefault("Don't even need wooden arrows!");
		}
        public override void SetDefaults()
        { 
            item.damage = 13;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 8f;
            item.value = 5;
            item.rare = 2;
            item.shoot = mod.ProjectileType("HoneyArrow");
            item.shootSpeed = 6.5f;
            item.ammo = AmmoID.Arrow;
        }
        public override void AddRecipes()  //How to craft this gun
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "HoneyCookie", 1);   //you need 1 DirtBlock
            recipe.AddTile(null, "CookieWorkbench");   //at work bench
            recipe.SetResult(this, 20);  //20 means how many bullets you craft from 1 dirt block
            recipe.AddRecipe();

        }
    }
}
