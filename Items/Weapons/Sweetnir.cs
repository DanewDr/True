using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons
{
    public class Sweetnir : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sweetnir");
			Tooltip.SetDefault("All the sugar in the world combined into a single sword.");
		}
        public override void SetDefaults()
        {
            item.damage = 52;                        
            item.melee = true;                     
            item.width = 58;
            item.height = 58;
            item.useTime = 24;
            item.useAnimation = 24;
            item.useStyle = 1;        
            item.knockBack = 4f;        
            item.rare = 5;            
            item.autoReuse = true;
            item.UseSound = SoundID.Item1;			
        }      
	public override void AddRecipes()
	{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "VanillaSwirl");
            recipe.AddIngredient(null, "HoneyClaymore");
            recipe.AddTile(null, "CookieWorkbench");   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
