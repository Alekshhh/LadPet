using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LadPet.Lad {
	public class LadPet : ModProjectile {
		public override void SetStaticDefaults() {
			Main.projFrames[projectile.type] = 1;
			Main.projPet[projectile.type] = true;
		}

		public override void SetDefaults() {
			projectile.CloneDefaults(ProjectileID.BabySkeletronHead);
			aiType = ProjectileID.BabySkeletronHead;
			projectile.width = 40;
			projectile.height = 34;
		}

		public override bool PreAI() {
			Player player = Main.player[projectile.owner];
			player.skeletron = false;
			return true;
		}

		public override void AI() {
			Player player = Main.player[projectile.owner];
			LadPetPlayer modPlayer = player.GetModPlayer<LadPetPlayer>();
			if (player.dead) {
				modPlayer.ladPet = false;
			}
			if (modPlayer.ladPet) {
				projectile.timeLeft = 2;
			}
		}
	}
}