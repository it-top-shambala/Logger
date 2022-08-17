// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using System.Text.Json;

namespace Logger.File;

/// <summary>
/// Класс конфигурирования файлов логирования
/// </summary>
internal class PathFileConfig
{
    /// <summary>
    /// Конструктор по умолчанию
    /// </summary>
    public PathFileConfig() { }

    /// <summary>
    /// Конструктор с аргументами
    /// </summary>
    /// <param name="pathInfo">Путь файла логирования информационных сообщений</param>
    /// <param name="pathWarning">Путь файла логирования сообщений предупреждений</param>
    /// <param name="pathError">Путь файла логирования сообщений ошибок</param>
    /// <param name="pathSuccess">Путь файла логирования сообщений успешного выполнения</param>
    /// <param name="pathCustom">Путь файла логирования пользовательских сообщений</param>
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
    /// <exception cref="InvalidOperationException">Исключение выбросится, если резудьтат десериализации будет null</exception>
    public static PathFileConfig Init(string path)
    {
        using var file = new FileStream(path, FileMode.Open, FileAccess.Read);
        return JsonSerializer.Deserialize<PathFileConfig>(file) ?? throw new InvalidOperationException();
    }
}
