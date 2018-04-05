using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
	public class BunnyFoot : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bunny's Foot");
			Tooltip.SetDefault("Summons a bunny warrior to fight for you");
		}
		public override void SetDefaults()
		{
			item.damage = 16;
			item.summon = true;
			item.mana = 10;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.noMelee = true;
			item.knockBack = 3f;
			item.rare = 1;
			item.UseSound = SoundID.Item44;
			item.shoot = mod.ProjectileType("Bunny");
			item.shootSpeed = 6f;
            item.buffTime = 3600;
			item.buffType = mod.BuffType("Bunny");			
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
			recipe.AddIngredient(null, "BunnyFur", 6);
		    recipe.AddTile(TileID.Anvils);   
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}