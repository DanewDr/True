using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons
{
    public class VanillaSwirl : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Milky Swirl");
			Tooltip.SetDefault("");
		}
        public override void SetDefaults()
        {
            item.damage = 22;                        
            item.melee = true;                     //this make the item do magic 
            item.width = 28;
            item.height = 28;
            item.useTime = 17;
            item.useAnimation = 17;
            item.useStyle = 1;        //this is how the item is holded
            item.knockBack = 4f;        
            item.rare = 2;            //mana use
            item.autoReuse = true;
            item.UseSound = SoundID.Item1;				
        }      
	public override void AddRecipes()  //How to craft this gun
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "CookieSword");
	    recipe.AddIngredient(null, "SugarSword");
            recipe.AddTile(null, "CookieWorkbench");   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
