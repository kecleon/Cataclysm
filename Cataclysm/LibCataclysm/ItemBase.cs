namespace Cataclysm; 

public struct ItemBase {
	public Slot slot;
	public Rarity rarity;
	public List<Modifier> mods;
	public string name;
	public Sprite icon;

	private static readonly string[] lines = new string[] { "\r", "\n" };

	public static ItemBase Parse(string input) {
		var item = new ItemBase();
		var split = input.Split(lines, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
		foreach (var line in split) {
			var colon = line.Split(':', StringSplitOptions.TrimEntries);
			if (colon.Length == 2) {
				switch (colon[0]) {
					case "Slot": {
						if (!Enum.TryParse(colon[1], out item.slot)) {
							Log.
						}
						break;
					}
				}
			}
		}
	}
}