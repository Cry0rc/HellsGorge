using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HellsGorge.Projectiles
{
    public class IronCleaverProj : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.name = "Iron Cleaver";
            projectile.width = 28;
            projectile.height = 30;
            projectile.friendly = true;
            projectile.aiStyle = 1;
            projectile.thrown = true;
            projectile.penetrate = 2;
            projectile.extraUpdates = 1;
            aiType = ProjectileID.ThrowingKnife;
        }
    }
}
        //Finish Crappy AI
        /*public override void AI()
        {
            projectile.ai[0] += 1f;
            if (projectile.ai[0] > 1f)
            {
                projectile.velocity.Y = projectile.velocity.Y + 50f;
                projectile.velocity.X = projectile.velocity.X * 50f;
            }
        }
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            {
                projectile.Kill();

                Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, 10);
            }
            return false;
        }
    }
}*/