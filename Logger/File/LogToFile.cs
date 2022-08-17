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

namespace Logger.File;

/// <summary>
/// Класс логирования сообщений в файл
/// </summary>
/// <inheritdoc cref="ILogger"/>
public class LogToFile : ILogger
{
    #region fields

    /// <summary>
    /// Приватная переменная конфигурации путей к файлам логирования, только для чтения
    /// </summary>
    private readonly PathFileConfig _path;

    #endregion

    #region constructors

    /// <summary>
    /// Конструктор, который создает объект конфигурации из файла по умолчанию
    /// </summary>
    public LogToFile()
    {
        _path = PathFileConfig.Init("log_paths.json");
    }

    /// <summary>
    /// Конструктор, который принимает путь к файлу и создает объект конфигурации из него
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
    private static void WriteToFile(string path, string message)
    {
        using var file = new StreamWriter(path, true);
        file.WriteLine($"{DateTime.Now:g} {message}");
    }

    /// <summary>
    /// Метод вывода информациооных сообщений
    /// </summary>
    /// <param name="message">Текст сообщения</param>
    /// <exception cref="InvalidOperationException">Если путь файла для логирования информационных сообщений будет пустой, то произойдёт исключение</exception>
    public void Info(string message)
    {
        WriteToFile(_path.PathInfo ?? throw new InvalidOperationException(), $"[INFO] {message}");
    }

    /// <summary>
    /// Метод вывода сообщений предупреждения
    /// </summary>
    /// <param name="message">Текст сообщения</param>
    /// <exception cref="InvalidOperationException">Если путь файла для логирования предупреждений будет пустой, то произойдёт исключение</exception>
    public void Warning(string message)
    {
        WriteToFile(_path.PathWarning ?? throw new InvalidOperationException(), $"[WARNING] {message}");
    }

    /// <summary>
    /// Метод вывода сообщений ошибок
    /// </summary>
    /// <param name="message">Текст сообщения</param>
    /// <exception cref="InvalidOperationException">Если путь файла для логирования сообщений об ошибках будет пустой, то произойдёт исключение</exception>
    public void Error(string message)
    {
        WriteToFile(_path.PathError ?? throw new InvalidOperationException(), $"[ERROR] {message}");
    }

    /// <summary>
    /// Метод вывода сообщений успешного выполнения
    /// </summary>
    /// <param name="message">Текст сообщения</param>
    /// <exception cref="InvalidOperationException">Если путь файла для логирования сообщений успеха будет пустой, то произойдёт исключение</exception>
    public void Success(string message)
    {
        WriteToFile(_path.PathSuccess ?? throw new InvalidOperationException(), $"[SUCCESS] {message}");
    }

    /// <summary>
    /// Метод вывода пользовательских сообщений
    /// </summary>
    /// <param name="type">Тип сообщений</param>
    /// <param name="message">Текст сообщения</param>
    /// <exception cref="InvalidOperationException">Если путь файла для логирования пользовательских сообщений будет пустой, то произойдёт исключение</exception>
    public void Custom(string type, string message)
    {
        WriteToFile(_path.PathCustom ?? throw new InvalidOperationException(), $"[{type}] {message}");
    }

    #endregion
}
