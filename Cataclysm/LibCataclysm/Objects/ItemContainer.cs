namespace Cataclysm.Objects; 

public class ItemContainer {
	public Slot slot;
	public Item? item;

	public ItemContainer(Slot slot, Item? item = null) {
		this.slot = slot;
		this.item = item;
	}
}