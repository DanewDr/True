using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items
{
    public class SlingshotAmmo : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Stone Pebble");
			Tooltip.SetDefault("That's gotta hurt!");
		}
        public override void SetDefaults()
        {
            item.damage = 4;
	          item.consumable = true;
	          item.shoot = mod.ProjectileType ("StonePebble");
	          item.ammo = item.type;
	          item.width = 20;
            item.height = 20;
            item.value = 100;
            item.rare = 1;
            item.maxStack = 999;
            ItemID.Sets.ItemNoGravity[item.type] = false;  //this make that the item will float in air
        }
 
       
 
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
 
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock);
            recipe.SetResult(this, 4);
            recipe.AddRecipe();
        }
    }
}
