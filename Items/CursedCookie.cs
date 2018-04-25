using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items
{
	
    public class CursedCookie : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Edible Cookie");
			Tooltip.SetDefault("Summons the Corrupt Cookie");
		}
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.value = 1300;
            item.rare = 1;
            item.maxStack = 20;
			item.useStyle = 4;
			item.useAnimation = 30;
            item.useTime = 30;
            item.consumable = true;
        }
        public override bool CanUseItem(Player player)
        {
            return !Main.dayTime && !NPC.AnyNPCs(mod.NPCType("CorruptCookie1"));
        }		
		
 		public override bool UseItem(Player player)
		{
			Main.PlaySound(15, (int)player.position.X, (int)player.position.Y, 0);
			Main.NewText("<Corrupt Cookie> How dare you eat my cookie, prepare to die!", (byte)146, (byte)101, (byte)15, false);
			NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("CorruptCookie1"));
			return true;
		}
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Cookie", 12);
			recipe.AddIngredient(ItemID.DemoniteBar, 2);
			recipe.AddIngredient(ItemID.RottenChunk, 2);
			recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
