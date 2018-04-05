using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons
{
    public class ChocolateLongsword : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chocolate Longsword");
			Tooltip.SetDefault("");
		}
        public override void SetDefaults()
        {         
            item.damage = 50;                        
            item.melee = true;                     //this make the item do magic 
            item.width = 28;
            item.height = 28;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;        //this is how the item is holded
            item.knockBack = 3f;        
            item.rare = 5;            //mana use
            item.autoReuse = true;
            item.shootSpeed = 16f;
            item.shoot = mod.ProjectileType("ChocolateCyclone");
            item.UseSound = SoundID.Item1;			   			
        }
		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(10) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("ChocolateCrumbs"));
			}
		}		
	public override void AddRecipes()
	{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "HallowedToolRod");
            recipe.AddIngredient(null, "ChocolateSword");
            recipe.AddTile(null, "CookieWorkbench");   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
