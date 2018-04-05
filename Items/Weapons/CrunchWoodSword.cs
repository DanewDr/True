using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
    public class CrunchWoodSword : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crunch Sword");
			Tooltip.SetDefault("");
		}
        public override void SetDefaults()
        {
            item.damage = 8;
            item.melee = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 24;
            item.useAnimation = 24;     
            item.useStyle = 1;
            item.knockBack = 5.5f;      
            item.rare = 0;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;		
		}		
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "CrunchWood", 7);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }	
    }
}
