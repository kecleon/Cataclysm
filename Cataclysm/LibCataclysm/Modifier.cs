namespace Cataclysm; 

public struct Modifier {
	public Statistic stat;
	public Change change;
	public double amount;
	public Statistic extra;
	public ModType type;
	public bool extractable;
}