using System.Text.Json;

namespace Logger.Console;

public class ConsoleColorConfig
{
    public ConsoleColor ColorInfo { get; set; }
    public ConsoleColor ColorWarning { get; set; }
    public ConsoleColor ColorError { get; set; }
    public ConsoleColor ColorSuccess { get; set; }
    public ConsoleColor ColorCustom { get; set; }

    public static ConsoleColorConfig Init(string path)
    {
        using var file = new FileStream(path, FileMode.Open, FileAccess.Read);
        return JsonSerializer.DeserializeAsync<ConsoleColorConfig>(file).Result;
    }
}
