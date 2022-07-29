namespace Logger.Console;

public class LogToConsole : ILogger
{
    private readonly ConsoleColorConfig _colors;
    public LogToConsole()
    {
        _colors = ConsoleColorConfig.Init("log_colors.json");
    }

    public LogToConsole(string pathToColorsConfig)
    {
        _colors = ConsoleColorConfig.Init(pathToColorsConfig);
    }
    
    private static void WriteToConsole(string message, ConsoleColor color)
    {
        System.Console.ForegroundColor = color;
        System.Console.WriteLine($"{DateTime.Now:g} {message}");
        System.Console.ResetColor();
    }

    public void Info(string message)
    {
        WriteToConsole($"[INFO] {message}", _colors.ColorInfo);
    }

    public void Warning(string message)
    {
        WriteToConsole($"[WARNING] {message}", _colors.ColorWarning);
    }

    public void Error(string message)
    {
        WriteToConsole($"[ERROR] {message}", _colors.ColorError);
    }

    public void Success(string message)
    {
        WriteToConsole($"[SUCCESS] {message}", _colors.ColorSuccess);
    }

    public void Custom(string type, string message)
    {
        WriteToConsole($"[{type}] {message}", _colors.ColorCustom);
    }
}
