/*
Copyright 2022 Starinin Andrey, Ankushin Alexey, Computer Academy TOP

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

namespace Logger.Console;

/// <summary>
/// Класс логирования сообщений в консоль
/// </summary>
/// <inheritdoc cref="ILogger"/>
public class LogToConsole : ILogger
{
    /// <summary>
    /// Приватная переменная конфигурации цветов текста в консоли, только для чтения
    /// </summary>
    private readonly ConsoleColorConfig _colors;

    /// <summary>
    /// Конструктор, который создает объект конфигурации из файла по умолчанию
    /// </summary>
    public LogToConsole()
    {
        _colors = ConsoleColorConfig.Init("log_colors.json");
    }

    /// <summary>
    /// Конструктор, который принимает путь к файлу и создает объект конфигурации из него
    /// </summary>
    /// <param name="pathToColorsConfig">Путь к файлу конфигурации</param>
    public LogToConsole(string pathToColorsConfig)
    {
        _colors = ConsoleColorConfig.Init(pathToColorsConfig);
    }

    /// <summary>
    /// Статический метод вывода в консоль сообщений по принятым параметрам с указанием даты и времени
    /// </summary>
    /// <param name="message">Текст сообщений</param>
    /// <param name="color">Цвет текста сообщений</param>
    private static void WriteToConsole(string message, ConsoleColor color)
    {
        System.Console.ForegroundColor = color;
        System.Console.WriteLine($"{DateTime.Now:g} {message}");
        System.Console.ResetColor();
    }

    /// <summary>
    /// Метод вывода в консоль информационных сообщений
    /// </summary>
    /// <param name="message">Текст сообщения</param>
    public void Info(string message)
    {
        WriteToConsole($"[INFO] {message}", _colors.ColorInfo);
    }

    /// <summary>
    /// Метод вывода в консоль сообщений предупреждения
    /// </summary>
    /// <param name="message">Текст сообщения</param>
    public void Warning(string message)
    {
        WriteToConsole($"[WARNING] {message}", _colors.ColorWarning);
    }

    /// <summary>
    /// Метод вывода в консоль сообщений ошибок
    /// </summary>
    /// <param name="message">Текст сообщения</param>
    public void Error(string message)
    {
        WriteToConsole($"[ERROR] {message}", _colors.ColorError);
    }

    /// <summary>
    /// Метод вывода в консоль сообщений успешного выполнения
    /// </summary>
    /// <param name="message">Текст сообщения</param>
    public void Success(string message)
    {
        WriteToConsole($"[SUCCESS] {message}", _colors.ColorSuccess);
    }

    /// <summary>
    /// Метод вывода в консоль пользовательских сообщений
    /// </summary>
    /// <param name="type">Пользовательский тип сообщения</param>
    /// <param name="message">Текст сообщения</param>
    public void Custom(string type, string message)
    {
        WriteToConsole($"[{type}] {message}", _colors.ColorCustom);
    }
}
