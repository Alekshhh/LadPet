using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LadPet {
	public class LadPetPlayer : ModPlayer {
		public bool ladPet;
		
		public override void ResetEffects() {
			ladPet = false;
		}
		
		//public override void SetupStartInventory(IList<Item> items) { does not work, need testing
			//if (player.name == "Aleksh") {
				//Item item = new Item();
				//item.SetDefaults(mod.ItemType("LadItem"));
				//item.stack = 1;
				//items.Add(item);
			//}
		//}
    }
}