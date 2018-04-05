using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons   //where is located
{
    public class DoughSword : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dough Blade");
			Tooltip.SetDefault("Dough rolled onto a wooden sword.");
		}
        public override void SetDefaults()
        {
            item.damage = 9;            //Sword damage
            item.melee = true;            //if it's melee
            item.width = 30;              //Sword width
            item.height = 30;             //Sword height
            item.useTime = 24;          //how fast 
            item.useAnimation = 24;     
            item.useStyle = 1;        //Style is how this item is used, 1 is the style of the sword
            item.knockBack = 0;      //Sword knockback       
            item.rare = 1;
            item.UseSound = SoundID.Item1;       //1 is the sound of the sword
            item.autoReuse = false;   //if it's capable of autoswing.  			
        }
		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(10) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("Dough"));
			}
		}		
        public override void AddRecipes()  //How to craft this sword
        {
            ModRecipe recipe = new ModRecipe(mod);      
            recipe.AddIngredient(null, "DoughBall", 10);
            recipe.AddIngredient(ItemID.WoodenSword);//you need 1 DirtBlock
            recipe.SetResult(this);
            recipe.AddRecipe();
        }	
    }
}
