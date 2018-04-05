using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items
{
		[AutoloadEquip(EquipType.Wings)]
		public class CookieWings : ModItem
		{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cookie Wings");
			Tooltip.SetDefault("");
		}		
		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = 1200;
			item.rare = 2;
			item.accessory = true;
		}
		//these wings use the same values as the solar wings
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wingTimeMax = 70;
		}

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.85f;
			ascentWhenRising = 0.15f;
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 3f;
			constantAscend = 0.135f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 9f;
			acceleration *= 2.5f;
		}

        public override void AddRecipes()  //How to craft this gun
        {
           ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Cookie", 12);   //you need 1 DirtBlock
            recipe.AddIngredient(ItemID.SoulofFlight, 20); 
			recipe.AddTile(null, "CookieWorkbench");
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
		
	}
}
