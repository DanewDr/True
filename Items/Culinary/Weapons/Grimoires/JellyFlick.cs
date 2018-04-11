using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CookieMod.Items.Culinary.Weapons
{
	public class JellyFlick : CookClass 
	{
		public override void SetStaticDefaults()  
		{
			DisplayName.SetDefault("Chef's Grimoire - Jelly Flick");
			Tooltip.SetDefault("Grants the knowledge to flick jelly beans at astonishing speeds!");
		}
		public override void SafeSetDefaults()  
		{
			item.ranged = false;
			item.noMelee = true;
			item.width = 34;
			item.height = 24;
			item.rare = 0;
			item.useTime = 40;
			item.useAnimation = 40;
			item.UseSound = SoundID.Item10;
			item.useStyle = 5;
			item.noMelee = true;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType ("JellyBean");
			item.shootSpeed = 30f;
			item.useAmmo = mod.ItemType("JellyBean");
      item.value = 200;
      item.noUseGraphic = true;
		}
	}
}
