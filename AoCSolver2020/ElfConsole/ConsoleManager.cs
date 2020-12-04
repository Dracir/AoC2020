using System;
using System.IO;
using System.Collections.Generic;

public static class ConsoleManager
{
	static ConsoleManager()
	{
		Console.WriteLine("ConsoleManager");
	}

	public static ConsoleHeader Header = new ConsoleHeader();
	private static ConsoleCenter Center = new ConsoleCenter();
	public static int FooterHeight = 3;
	public static ConsoleSkin Skin = new ConsoleSkin();


	public static void WriteLineAt(string text, int line) => BetterConsole.WriteAt(text, line);

	public static int Height => BetterConsole.Height;
	public static int Width => BetterConsole.Width;
	public static Point Size => new Point(Width, Height);
	public static ConsoleKeyInfo ReadKey() => Console.ReadKey();

	public static void SetFullScreen() => ConsoleUtils.SetUp();

	public static void Refresh()
	{
		var lines = BetterConsole.Height - Header.ReservedLines - FooterHeight;
		Center.Reset(lines, Header.ReservedLines - 1);
	}


	public static void WriteLine(string text) => Center.WriteLine(text);

	public static void Clear()
	{
		Console.Clear();
	}
}