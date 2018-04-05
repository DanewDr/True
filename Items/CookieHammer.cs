using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items
{
    public class CookieHammer : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cookie Hammer");
			Tooltip.SetDefault("Nothing to say about this item. Except that it is crumbling...");
		}
        public override void SetDefaults()
        {
            item.damage = 17;
            item.melee = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 25;
            item.useAnimation = 25;
            item.hammer = 55;   //hammer power
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 1000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
        }
        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Cookie", 10);   //you need 10 Wood
            recipe.AddTile(null, "CookieWorkbench");   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(10) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("Sparkle"));
			}
		}		
    }
}
