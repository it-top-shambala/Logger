namespace Logger.Console;

public class LogToConsole : ILogger
{
    private static void WriteToConsole(string message, ConsoleColor color)
    {
        System.Console.ForegroundColor = color;
        System.Console.WriteLine($"{DateTime.Now:g} {message}");
        System.Console.ResetColor();
    }

    public void Info(string message)
    {
        WriteToConsole($"[INFO] {message}", ConsoleColor.Blue);
    }

    public void Warning(string message)
    {
        WriteToConsole($"[WARNING] {message}", ConsoleColor.Yellow);
    }

    public void Error(string message)
    {
        WriteToConsole($"[ERROR] {message}", ConsoleColor.Red);
    }

    public void Success(string message)
    {
        WriteToConsole($"[SUCCESS] {message}", ConsoleColor.Green);
    }

    public void Custom(string type, string message)
    {
        WriteToConsole($"[{type}] {message}", ConsoleColor.Gray);
    }
}
