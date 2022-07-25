namespace Logger.File;

public class LogToFile : ILogger
{
    #region fields

    private readonly string _path;

    #endregion
    
    #region constructors

    public LogToFile()
    {
        _path = "journal.log";
    }

    public LogToFile(string path)
    {
        _path = path;
    }

    #endregion

    #region methods

    private void WriteToFile(string message)
    {
        using var file = new StreamWriter(_path, append: true);
        file.WriteLine($"{DateTime.Now:g} {message}");
    }

    public void Info(string message)
    {
        WriteToFile($"[INFO] {message}");
    }

    public void Warning(string message)
    {
        WriteToFile($"[WARNING] {message}");
    }

    public void Error(string message)
    {
        WriteToFile($"[ERROR] {message}");
    }

    public void Success(string message)
    {
        WriteToFile($"[SUCCESS] {message}");
    }

    public void Custom(string type, string message)
    {
        WriteToFile($"[{type}] {message}");
    }

    #endregion
    
}
