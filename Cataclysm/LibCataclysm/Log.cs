using System.Text;

namespace Cataclysm; 

public static class Log {
	private static FileStream LogFile = (FileStream)Stream.Null;
	private static TextWriter TextStream = new StreamWriter(LogFile, Encoding.UTF8);
	private static StringBuilder sb = new();

	public static void Init(string path) {
		LogFile = File.OpenWrite(path);
	}

	public static void Write(string text) {
		sb.Append(Time.Now);
		sb.Append('|');
		sb.Append(text);
		TextStream.WriteLine(sb.ToString());
		sb.Clear();
	}
}