using System;

namespace DepotDownloader;

class Console
{
    public static IConsole handler = new SystemConsole();
    public static bool IsInputRedirected => handler.IsInputRedirected;

    internal static void WriteLine(string format = null, params object[] values) => handler.WriteLine(format, values);

    public static ConsoleKeyInfo ReadKey(bool b) => handler.ReadKey(b);

    public static void Write(string p0, params object[] args) => handler.Write(p0, args);
    public static void Write(char c) => handler.Write(c);
    public static string ReadLine() => handler.ReadLine();
}
