using System;

namespace DepotDownloader;

public interface IConsole
{
    void WriteLine(string format, params object[] values);
    ConsoleKeyInfo ReadKey(bool intercept);
    void Write(string format, params object[] args);
    void Write(char c);
    string ReadLine();
    bool IsInputRedirected { get; }
}
