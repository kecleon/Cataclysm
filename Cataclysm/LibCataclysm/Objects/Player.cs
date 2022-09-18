namespace Cataclysm.Objects; 

public class Player : Entity {
	public const byte EquipsLength =11;
	public ItemContainer[] equips;
	public ItemContainer[] items = new ItemContainer[EquipsLength];
}