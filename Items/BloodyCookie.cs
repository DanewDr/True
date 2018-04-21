using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items
{
	
    public class BloodyCookie : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bloody Cookie");
			Tooltip.SetDefault("Summons the Blood Cookie");
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
            return !Main.dayTime && !NPC.AnyNPCs(mod.NPCType("BloodCookie"));
        }		
		
 		public override bool UseItem(Player player)
		{
			Main.PlaySound(15, (int)player.position.X, (int)player.position.Y, 0);
			Main.NewText("<Blood Cookie>: I shall consuming your blood, fool!", (byte)146, (byte)101, (byte)15, false);
			NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("BloodCookie"));
			return true;
		}
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Cookie", 12);
			recipe.AddIngredient(ItemID.CrimtaneBar, 2);
			recipe.AddIngredient(ItemID.Vertebrae, 2);
			recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
