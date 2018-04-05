using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
	public class GoldBunnyFoot : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Golden Bunny's Foot");
			Tooltip.SetDefault("Summons a golden bunny warrior to fight for you");
		}
		public override void SetDefaults()
		{
			item.damage = 26;
			item.summon = true;
			item.mana = 10;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.noMelee = true;
			item.knockBack = 3f;
			item.rare = 2;
			item.UseSound = SoundID.Item20;
			item.shoot = mod.ProjectileType("GoldBunny");
			item.shootSpeed = 6f;
            item.buffTime = 3600;
			item.buffType = mod.BuffType("GoldBunny");	
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
			recipe.AddIngredient(null, "GoldBunnyFur", 6);
			recipe.AddIngredient(null, "BunnyFoot");
		    recipe.AddTile(TileID.Anvils);   
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}