using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons
{
    public class GumSlasher : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gum Slasher");
			Tooltip.SetDefault("Don't chew on it!");
		}
        public override void SetDefaults()
        {          
            item.damage = 24;                        
            item.melee = true;                     
            item.width = 38;
            item.height = 38;
            item.useTime = 19;
            item.useAnimation = 19;
            item.useStyle = 1;        
            item.knockBack = 1f;        
            item.rare = 3;            
            item.autoReuse = true;
            item.UseSound = SoundID.Item1;						
        }      
        	public override void AddRecipes()
	        {
	        	ModRecipe recipe = new ModRecipe(mod);
	        	recipe.AddIngredient(null, "HardSugarDust", 20);
	        	recipe.AddTile(null, "CookieWorkbench");
	        	recipe.SetResult(this);
	        	recipe.AddRecipe();
	        }
        }
    }
