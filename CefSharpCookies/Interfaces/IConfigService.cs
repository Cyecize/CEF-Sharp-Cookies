using System;
using CefSharpCookies.Enums;

namespace CefSharpCookies.Interfaces
{
    public interface IConfigService
    {
        void Save();

        void Set(string key, string value);

        void Set(ConfigKey key, string value);

        string GetString(string key);

        string GetString(ConfigKey configKey);

        int GetInt(ConfigKey key);

        double GetDouble(ConfigKey key);

        bool GetBool(ConfigKey key);
    }
}
