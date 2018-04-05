using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons
{  
    public class GingerStaff : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ginger Staff");
			Tooltip.SetDefault("Summons a round ginger cookie");
		}
        public override void SetDefaults()
        {
            item.damage = 12;
            item.summon = true;
            item.mana = 10;
            item.width = 26;
            item.height = 28;
            item.useTime = 34;
            item.useAnimation = 26;
            item.useStyle = 1;
            item.noMelee = true;
            item.knockBack = 3;
            item.value = 1000;
            item.rare = 3;
            item.UseSound = SoundID.Item44;
            item.shoot = mod.ProjectileType("GingerMinion");
            item.shootSpeed = 10f;
            item.buffTime = 3600;
	    item.buffType = mod.BuffType("GingerMinion");
        }
		public override bool AltFunctionUse(Player player)
		{
			return true;
		}
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			return player.altFunctionUse != 2;
		}
		
		public override bool UseItem(Player player)
		{
			if(player.altFunctionUse == 2)
			{
				player.MinionNPCTargetAim();
			}
			return base.UseItem(player);
		}		
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "GingerCookie", 10);
            recipe.SetResult(this);
	    recipe.AddTile(null, "CookieWorkbench"); 
            recipe.AddRecipe();
        }
    }
}
