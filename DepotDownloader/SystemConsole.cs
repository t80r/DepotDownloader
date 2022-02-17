using System;

namespace DepotDownloader;

class SystemConsole : IConsole
{
    public void WriteLine(string format, params object[] values)
    {
        if (format == null)
            System.Console.WriteLine();
        else
            System.Console.WriteLine(format, values);
    }

    public ConsoleKeyInfo ReadKey(bool intercept) => System.Console.ReadKey(intercept);
    public void Write(string format, params object[] args) => System.Console.Write(format, args);

    public void Write(char c) => System.Console.Write(c);
    public string ReadLine() => System.Console.ReadLine();
    public bool IsInputRedirected => System.Console.IsInputRedirected;
}
