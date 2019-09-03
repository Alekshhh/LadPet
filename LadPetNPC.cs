using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LadPet {
	public class LadPetNPC : GlobalNPC {
		public override void NPCLoot(NPC npc) {
			if (npc.type == NPCID.Shark && Main.rand.NextFloat() < .1000f) Item.NewItem(npc.getRect(), mod.ItemType("LadItem"));
		}
	}
}