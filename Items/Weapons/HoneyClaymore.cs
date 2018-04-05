using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons
{
    public class HoneyClaymore : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Honey Claymore");
			Tooltip.SetDefault("");
		}
        public override void SetDefaults()
        {         
            item.damage = 35;                        
            item.melee = true;                     //this make the item do magic 
            item.width = 28;
            item.height = 28;
            item.useTime = 24;
            item.useAnimation = 24;
            item.useStyle = 1;        //this is how the item is holded
            item.knockBack = 6f;        
            item.rare = 2;            //mana use
            item.autoReuse = true;
            item.UseSound = SoundID.Item1;						
        }
		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(10) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("HoneyCrumbs"));
			}
		}
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
			target.AddBuff(mod.BuffType("Honeyed"),1000);
        }			
	public override void AddRecipes()
	{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "BoneToolRod");
            recipe.AddIngredient(null, "HoneySword");
            recipe.AddTile(null, "CookieWorkbench");   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();
         }
    }
}
