using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using Terraria.ModLoader;

namespace CookieMod.Projectiles
{
	public class RottenJavelin : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rotten Javelin");     //The English name of the projectile
		}
		public override void SetDefaults()
		{
			projectile.width = 22;
			projectile.height = 70;
			projectile.aiStyle = -1;
			projectile.friendly = true;
			projectile.melee = true;
			projectile.penetrate = 3;
		}
		public override bool TileCollideStyle(ref int width, ref int height, ref bool fallThrough)
		{

			width = 10;
			height = 10;
			return true;
		}

		public override bool? Colliding(Rectangle projHitbox, Rectangle targetHitbox)
		{
			if (targetHitbox.Width > 8 && targetHitbox.Height > 8)
			{
				targetHitbox.Inflate(-targetHitbox.Width / 8, -targetHitbox.Height / 8);
			}
			return projHitbox.Intersects(targetHitbox);
		}

		public override void Kill(int timeLeft)
		{
			Main.PlaySound(0, (int)projectile.position.X, (int)projectile.position.Y, 1, 1f, 0f);
			Vector2 usePos = projectile.position;
			Vector2 rotVector = (projectile.rotation - MathHelper.ToRadians(90f)).ToRotationVector2();
			usePos += rotVector * 16f;

			for (int k = 0; k < 5; k++)
			{
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, mod.DustType("RottenCrumbs"), projectile.oldVelocity.X * 0f, projectile.oldVelocity.Y * 0f);
			}

			int item = 0;
			if (Main.rand.NextFloat() < 0.18f)
			{
				item = Item.NewItem((int)projectile.position.X, (int)projectile.position.Y, projectile.width, projectile.height, mod.ItemType<Items.Weapons.RottenJavelin>(), 1, false, 0, false, false);
			}
		}
		public float isStickingToTarget
		{
			get { return projectile.ai[0]; }
			set { projectile.ai[0] = value; }
		}
		public float targetWhoAmI
		{
			get { return projectile.ai[1]; }
			set { projectile.ai[1] = value; }
		}

		public override void ModifyHitNPC(NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
		{
			projectile.ai[0] = 1f;
			projectile.ai[1] = (float)target.whoAmI;
			projectile.velocity = (target.Center - projectile.Center) * 0.75f;
			projectile.netUpdate = true;
			target.AddBuff(169, 900, false);

			projectile.damage = 0;

			int maxStickingJavelins = 6;
			Point[] stickingJavelins = new Point[maxStickingJavelins];
			int javelinIndex = 0;
			for (int i = 0; i < Main.maxProjectiles; i++)
			{
				Projectile currentProjectile = Main.projectile[i];
				if (i != projectile.whoAmI
					&& currentProjectile.active
					&& currentProjectile.owner == Main.myPlayer
					&& currentProjectile.type == projectile.type
					&& currentProjectile.ai[0] == 1f
					&& currentProjectile.ai[1] == (float)target.whoAmI)
				{
					stickingJavelins[javelinIndex++] = new Point(i, currentProjectile.timeLeft);
					if (javelinIndex >= stickingJavelins.Length)
					{
						break;
					}
				}
			}
			if (javelinIndex >= stickingJavelins.Length)
			{
				int oldJavelinIndex = 0;
				for (int i = 1; i < stickingJavelins.Length; i++)
				{
					if (stickingJavelins[i].Y < stickingJavelins[oldJavelinIndex].Y)
					{
						oldJavelinIndex = i;
					}
				}
				Main.projectile[stickingJavelins[oldJavelinIndex].X].Kill();
			}
		}
		private const float maxTicks = 45f;
		private const int alphaReduction = 25;

		public override void AI()
		{
			if (Main.rand.Next(2) == 0)
			{
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, mod.DustType("RottenCrumbs"), projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
			}				
			if (projectile.alpha > 0)
			{
				projectile.alpha -= alphaReduction;
			}
			if (projectile.alpha < 0)
			{
				projectile.alpha = 0;
			}
			if (projectile.ai[0] == 0f)
			{
				projectile.ai[1] += 1f;
				if (projectile.ai[1] >= maxTicks)
				{
					float velXmult = 0.98f;
					float velYmult = 0.35f;
					projectile.ai[1] = maxTicks;
					projectile.velocity.X = projectile.velocity.X * velXmult;
					projectile.velocity.Y = projectile.velocity.Y + velYmult;
				}
				projectile.rotation = projectile.velocity.ToRotation() + MathHelper.ToRadians(90f);
				if (Main.rand.Next(3) == 0)
				{
					int dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, mod.DustType<Dusts.Sparkle>(), projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.2f, 200, default(Color), 1.2f);
					Main.dust[dustIndex].velocity += projectile.velocity * 0.3f;
					Main.dust[dustIndex].velocity *= 0.2f;
				}
				if (Main.rand.Next(4) == 0)
				{
					int dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, mod.DustType<Dusts.Smoke>(), 0f, 0f, 254, default(Color), 0.3f);
					Main.dust[dustIndex].velocity += projectile.velocity * 0.5f;
					Main.dust[dustIndex].velocity *= 0.5f;
					return;
				}
			}
			if (projectile.ai[0] == 1f)
			{
				// These 2 could probably be moved to the ModifyNPCHit hook, but in vanilla they are present in the AI
				projectile.ignoreWater = true; // Make sure the projectile ignores water
				projectile.tileCollide = false; // Make sure the projectile doesn't collide with tiles anymore
				int aiFactor = 15; // Change this factor to change the 'lifetime' of this sticking javelin
				bool killProj = false; // if true, kill projectile at the end
				bool hitEffect = false; // if true, perform a hit effect
				projectile.localAI[0] += 1f; 
				// Every 30 ticks, the javelin will perform a hit effect
				hitEffect = projectile.localAI[0] % 30f == 0f;
				int projTargetIndex = (int)projectile.ai[1];
				if (projectile.localAI[0] >= (float)(60 * aiFactor)) // If it's time for this javelin to die, kill it
				{
					killProj = true;
				}
				else if (projTargetIndex < 0 || projTargetIndex >= 200) // If the index is past its limits, kill the javelin
				{
					killProj = true;
				}
				else if (Main.npc[projTargetIndex].active && !Main.npc[projTargetIndex].dontTakeDamage) // If the target is active and can take damage
				{
					// Set the projectile's position relative to the target's center
					projectile.Center = Main.npc[projTargetIndex].Center - projectile.velocity * 2f;
					projectile.gfxOffY = Main.npc[projTargetIndex].gfxOffY;
					if (hitEffect) // Perform a hit effect here
					{
						Main.npc[projTargetIndex].HitEffect(0, 1.0);
					}
				}
				else // Otherwise, kill the projectile
				{
					killProj = true;
				}

				if (killProj) // Kill the projectile
				{
					projectile.Kill();
				}
			}
		}
	}
}