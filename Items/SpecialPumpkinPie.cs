using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items
{
    public class SpecialPumpkinPie : ModItem
    {	
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Special Pumpkin Pie");
			Tooltip.SetDefault("Why does this look familiar");
		}
        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item3;                 //this is the sound that plays when you use the item
            item.useStyle = 2;                 //this is how the item is holded when used
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 30;                 //this is where you set the max stack of item
            item.consumable = true;           //this make that the item is consumable when used
            item.width = 38;
            item.height = 30;
            item.value = 100;                
            item.rare = 1;
            item.buffType = BuffID.WellFed;    //this is where you put your Buff
            item.buffTime = 50000;    //this is the buff duration        20000 = 6 min
            return;
        }
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PumpkinPie, 10);
			recipe.AddIngredient(ItemID.LunarBar, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
    }
}
