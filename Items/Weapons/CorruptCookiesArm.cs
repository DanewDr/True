using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons   //where is located
{
    public class CorruptCookiesArm : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Corrupt Cookie's Arm");
			Tooltip.SetDefault("Big, but not that heavy!");
		}
        public override void SetDefaults()
        {
            item.damage = 30;            //Sword damage
            item.melee = true;            //if it's melee
            item.width = 18;              //Sword width
            item.height = 50;             //Sword height
            item.useTime = 25;          //how fast 
            item.useAnimation = 25;     
            item.useStyle = 1;        //Style is how this item is used, 1 is the style of the sword
            item.knockBack = 5;      //Sword knockback
            item.value = 4000;        
            item.rare = 11;
            item.UseSound = SoundID.Item1;       //1 is the sound of the sword
            item.autoReuse = true;   //if it's capable of autoswing.
            item.useTurn = true;
			item.expert = true;
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
