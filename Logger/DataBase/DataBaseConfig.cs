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

using Logger.File;

namespace Logger.DataBase;

/// <summary>
///
/// </summary>
public class DataBaseConfig
{
    /// <summary>
    /// 
    /// </summary>
    public string? path { get; set; }
    /// <summary>
    ///
    /// </summary>
    public DataBaseConfig() { }
    public DataBaseConfig(string path)
    {
        this.path = @$"Data Source={path}";
    }    
}
