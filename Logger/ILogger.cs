// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

namespace Logger;

/// <summary>
/// Интерфейс для классов журналирования событий
/// </summary>
public interface ILogger
{
    /// <summary>
    /// Метод вывода информационных сообщений
    /// </summary>
    /// <param name="message">Текст сообщения</param>
    public void Info(string message);

    /// <summary>
    /// Метод вывода сообщений предупреждения
    /// </summary>
    /// <param name="message">Текст сообщения</param>
    public void Warning(string message);

    /// <summary>
    /// Метод вывода сообщений ошибок
    /// </summary>
    /// <param name="message">Текст сообщения</param>
    public void Error(string message);

    /// <summary>
    /// Метод вывода сообщений успешного выполнения
    /// </summary>
    /// <param name="message">Текст сообщения</param>
    public void Success(string message);

    /// <summary>
    /// Метод вывода пользовательских сообщений
    /// </summary>
    /// <param name="type">Тип пользовательского сообщения</param>
    /// <param name="message">Текст сообщения</param>
    public void Custom(string type, string message);
}
