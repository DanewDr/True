using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items
{
    public class MortarAndPestle : CookClass
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mortar And Pestle");
			Tooltip.SetDefault("Allows for the grinding of foods");
		}
        public override void SafeSetDefaults()
        {
            item.useStyle = 1;                 //this is how the item is holded when used
		item.damage = 12;
		item.crit = 4;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.width = 22;
            item.height = 18;
            item.value = 50;                
            item.rare = 0;
	    item.autoReuse = true;
		item.shoot = mod.ProjectileType ("PearJam");
		item.useAmmo = mod.ItemType("PearJam");
		item.noMelee = true;

        }
    }
}
