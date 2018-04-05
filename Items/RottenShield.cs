using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items
{
	[AutoloadEquip(EquipType.Shield)]
	public class RottenShield : ModItem
	{
 		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rotten Shield");
			Tooltip.SetDefault("Grants immunity to knockback\n8% thrown damage increase");
		}
        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 28;
            item.value = Item.buyPrice(0, 2, 0, 0);
            item.rare = 4;      
            item.accessory = true;
            item.defense = 2;
 
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.noKnockback = true;
	      player.thrownDamage += .08f;
        }
 
 
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CobaltShield, 1);
            recipe.AddIngredient(null, "RottenCookie", 4);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
 
    }
}