namespace Cataclysm.Objects;

public class Item {
	public Rarity rarity;
	public ItemBase itemBase;
	public List<Modifier> staticMods;
	public List<Modifier> dynamicMods;
	public List<Modifier> amplifierMods;
	public long seed;
	public string name;
	public Sprite icon;
	public bool identified;

	public Item(long seed, ItemBase itemBase) {
		this.seed = seed;
		this.itemBase = itemBase;
		this.staticMods = new();
		this.dynamicMods = new();
		this.amplifierMods = new();
		this.rarity = itemBase.rarity;
		this.icon = itemBase.icon;
		this.identified = true;
		Console.WriteLine($"small cons");
	}

	public Item(long seed, ItemBase itemBase, Rarity rarity, List<Modifier> extraMods) : this(seed, itemBase) {
		this.seed = seed;
		this.itemBase = itemBase;
		this.rarity = rarity;
		foreach (var mod in itemBase.mods) {
			this.staticMods.Add(mod);
		}

		foreach (var mod in extraMods) {
			this.dynamicMods.Add(mod);
		}

		Console.WriteLine($"big ctor");
	}
}