using Terraria;
using Terraria.ModLoader;

namespace LadPet.Lad {
	public class LadBuff : ModBuff {
		public override void SetDefaults() {
			DisplayName.SetDefault("Shark Lad");
			Description.SetDefault("\"My son! He is here!\"");
			Main.buffNoTimeDisplay[Type] = true;
			Main.vanityPet[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex) {
			player.buffTime[buffIndex] = 18000;
			player.GetModPlayer<LadPetPlayer>().ladPet = true;
			bool petProjectileNotSpawned = player.ownedProjectileCounts[mod.ProjectileType("LadPet")] <= 0;
			if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer) {
				Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, mod.ProjectileType("LadPet"), 0, 0f, player.whoAmI, 0f, 0f);
			}
		}
	}
}