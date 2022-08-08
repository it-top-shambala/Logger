// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using System.Text.Json;

namespace Logger.File;

/// <summary>
/// Класс конфигурирования файлов логирования
/// </summary>
internal class PathFileConfig
{
    public PathFileConfig() { }

    public PathFileConfig(string? pathInfo, string? pathWarning, string? pathError, string? pathSuccess,
        string? pathCustom)
    {
        PathInfo = pathInfo;
        PathWarning = pathWarning;
        PathError = pathError;
        PathSuccess = pathSuccess;
        PathCustom = pathCustom;
    }

    /// <value>
    /// Свойство хранения пути файла логирования информационных сообщений
    /// </value>
    public string? PathInfo { get; set; }

    /// <value>
    /// Свойство хранения пути файла логирования сообщений предупреждений
    /// </value>
    public string? PathWarning { get; set; }

    /// <value>
    /// Свойство хранения пути файла логирования сообщений ошибок
    /// </value>
    public string? PathError { get; set; }

    /// <value>
    /// Свойство хранения пути файла логирования сообщений успешного выполнения
    /// </value>
    public string? PathSuccess { get; set; }

    /// <value>
    /// Свойство хранения пути файла логирования пользовательских сообщений
    /// </value>
    public string? PathCustom { get; set; }

    /// <summary>
    /// Статический метод класса PathFileConfig для определения конфигурации методов из файла
    /// </summary>
    /// <param name="path">Путь к файлу конфигурации</param>
    /// <returns>Объект класса конфигурации с устанвленным набором путей к файлам логирования</returns>
    public static PathFileConfig Init(string path)
    {
        using var file = new FileStream(path, FileMode.Open, FileAccess.Read);
        return JsonSerializer.Deserialize<PathFileConfig>(file) ?? throw new InvalidOperationException();
    }
}
