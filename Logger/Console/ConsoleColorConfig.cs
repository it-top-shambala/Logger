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

using System.Text.Json;

namespace Logger.Console;

/// <summary>
/// Класс для конфигурирования цвета текста в консоли
/// </summary>
internal class ConsoleColorConfig
{
    /// <summary>
    /// Конструктор по умолчанию
    /// </summary>
    public ConsoleColorConfig()
    {
    }

    /// <summary>
    /// Конструктор с аргументами
    /// </summary>
    /// <param name="colorInfo">Объект класса ConsoleColor для определения цвета информационного текста в консоли</param>
    /// <param name="colorWarning">Объект класса ConsoleColor для определения цвета текста предупреждений в консоли</param>
    /// <param name="colorError">Объект класса ConsoleColor для определения цвета текста ошибок в консоли</param>
    /// <param name="colorSuccess">Объект класса ConsoleColor для определения цвета текста успешного выполнения в консоли</param>
    /// <param name="colorCustom">Объект класса ConsoleColor для определения цвета пользовательского текста в консоли</param>
    public ConsoleColorConfig(ConsoleColor colorInfo, ConsoleColor colorWarning, ConsoleColor colorError,
        ConsoleColor colorSuccess, ConsoleColor colorCustom)
    {
        ColorInfo = colorInfo;
        ColorWarning = colorWarning;
        ColorError = colorError;
        ColorSuccess = colorSuccess;
        ColorCustom = colorCustom;
    }

    /// <value>
    /// Свойство класса ConsoleColor для определения цвета информационного текста в консоли
    /// </value>
    public ConsoleColor ColorInfo { get; set; }

    /// <value>
    /// Свойство класса ConsoleColor для определения цвета текста предупреждений в консоли
    /// </value>
    public ConsoleColor ColorWarning { get; set; }

    /// <value>
    /// Свойство класса ConsoleColor для определения цвета текста ошибок в консоли
    /// </value>
    public ConsoleColor ColorError { get; set; }

    /// <value>
    /// Свойство класса ConsoleColor для определения цвета текста успешного выполнения в консоли
    /// </value>
    public ConsoleColor ColorSuccess { get; set; }

    /// <value>
    /// Свойство класса ConsoleColor для определения цвета пользовательского текста в консоли
    /// </value>
    public ConsoleColor ColorCustom { get; set; }

    /// <summary>
    /// Статический метод для определения конфигурации методов из файла
    /// </summary>
    /// <param name="path">Путь к файлу конфигурации</param>
    /// <returns>Объект класса конфигурации с необходимыми установками цвета текста</returns>
    /// <exception cref="InvalidOperationException">Исключение выбросится, если резудьтат десериализации будет null</exception>
    public static ConsoleColorConfig Init(string path)
    {
        using var file = new FileStream(path, FileMode.Open, FileAccess.Read);
        return JsonSerializer.Deserialize<ConsoleColorConfig>(file) ?? throw new InvalidOperationException();
    }
}
