using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LadPet.Lad {
	public class LadItem : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Shark Heart");
			Tooltip.SetDefault("Summons a Shark Lad");
		}
		
		public override void SetDefaults() {
			item.CloneDefaults(ItemID.ZephyrFish);
			item.shoot = mod.ProjectileType("LadPet");
			item.buffType = mod.BuffType("LadBuff");
		}
		
		public override void UseStyle(Player player) {
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0) {
				player.AddBuff(item.buffType, 3600, true);
			}
		}
	}
}