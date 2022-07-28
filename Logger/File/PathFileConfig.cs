using System.Text.Json;
using Logger.Console;

namespace Logger.File;

public class PathFileConfig
{
    public string PathInfo { get; set; }
    public string PathWarning { get; set; }
    public string PathError { get; set; }
    public string PathSuccess { get; set; }
    public string PathCustom { get; set; }
    
    public static PathFileConfig Init(string path)
    {
        using var file = new FileStream(path, FileMode.Open, FileAccess.Read);
        return JsonSerializer.DeserializeAsync<PathFileConfig>(file).Result;
    }
}
