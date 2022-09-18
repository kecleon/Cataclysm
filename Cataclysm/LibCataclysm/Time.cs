namespace Cataclysm; 

public static class Time {
	public static string Now => DateTime.Now.ToBinary().ToString();
}