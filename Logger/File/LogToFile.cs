namespace Logger.File;

public class LogToFile : ILogger
{
    #region fields

    private readonly PathFileConfig _path;

    #endregion

    #region constructors

    public LogToFile()
    {
        _path = PathFileConfig.Init("log_paths.json");
    }

    public LogToFile(string pathToPathConfig)
    {
        _path = PathFileConfig.Init(pathToPathConfig);
    }

    #endregion

    #region methods

    private void WriteToFile(string path, string message)
    {
        using var file = new StreamWriter(path, true);
        file.WriteLine($"{DateTime.Now:g} {message}");
    }

    public void Info(string message)
    {
        WriteToFile(_path.PathInfo, $"[INFO] {message}");
    }

    public void Warning(string message)
    {
        WriteToFile(_path.PathWarning, $"[WARNING] {message}");
    }

    public void Error(string message)
    {
        WriteToFile(_path.PathError, $"[ERROR] {message}");
    }

    public void Success(string message)
    {
        WriteToFile(_path.PathSuccess, $"[SUCCESS] {message}");
    }

    public void Custom(string type, string message)
    {
        WriteToFile(_path.PathCustom, $"[{type}] {message}");
    }

    #endregion
}
