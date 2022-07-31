namespace Logger.File;
/// <summary>
/// Класс логирования сообщений в файл
/// </summary>
public class LogToFile : ILogger
{
    #region fields
    private readonly PathFileConfig _path;
    #endregion
    #region constructors
    /// <summary>
    /// Конструктор (по умолчанию) класса LogToFile который создает объект конфигурации
    /// </summary>
    public LogToFile()
    {
        _path = PathFileConfig.Init("log_paths.json");
    }
    /// <summary>
    /// Конструктор (с параметрами) класса LogToFile который принимает путь к файлу конфигурации и создает объект конфигурации 
    /// </summary>
    /// <param name="pathToPathConfig">Путь к файлу конфигурации</param>
    public LogToFile(string pathToPathConfig)
    {
        _path = PathFileConfig.Init(pathToPathConfig);
    }
    #endregion
    #region methods
    /// <summary>
    /// Статический метод вывода в файл сообщений по принятым параметрам
    /// </summary>
    /// <param name="path">Путь к файлу логирования</param>
    /// <param name="message">Текст сообщения</param>
    private void WriteToFile(string path, string message)
    {
        using var file = new StreamWriter(path, true);
        file.WriteLine($"{DateTime.Now:g} {message}");
    }
    /// <summary>
    /// Метод вывода информациооных сообщений
    /// </summary>
    /// <param name="message">Текст сообщения</param>
    public void Info(string message)
    {
        WriteToFile(_path.PathInfo, $"[INFO] {message}");
    }
    /// <summary>
    /// Метод вывода сообщений предупреждения
    /// </summary>
    /// <param name="message">Текст сообщения</param>
    public void Warning(string message)
    {
        WriteToFile(_path.PathWarning, $"[WARNING] {message}");
    }
    /// <summary>
    /// Метод вывода сообщений ошибок
    /// </summary>
    /// <param name="message">Текст сообщения</param>
    public void Error(string message)
    {
        WriteToFile(_path.PathError, $"[ERROR] {message}");
    }
    /// <summary>
    /// Метод вывода сообщений выполнения
    /// </summary>
    /// <param name="message">Текст сообщения</param>
    public void Success(string message)
    {
        WriteToFile(_path.PathSuccess, $"[SUCCESS] {message}");
    }
    /// <summary>
    /// Метод вывода пользовательских сообщений
    /// </summary>
    /// <param name="type">Тип сообщений</param>
    /// <param name="message">Текст сообщения</param>
    public void Custom(string type, string message)
    {
        WriteToFile(_path.PathCustom, $"[{type}] {message}");
    }
    #endregion
}
