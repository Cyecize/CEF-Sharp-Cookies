using System;
using System.Collections.Generic;
using System.IO;
using CefSharpCookies.Enums;
using CefSharpCookies.Interfaces;
using Newtonsoft.Json;

namespace CefSharpCookies.Services
{
    public class ConfigService : IConfigService
    {
        private const string ConfigFileName = "app_conf.json";

        private const string EmptyJson = "{}";

        private readonly Dictionary<string, string> _config;

        public ConfigService()
        {
            this.CreateConfigFile();
            this._config = this.GetParsedConfigFile();
            this.ValidateConfigFields();
        }

        public void Save()
        {
            this.WriteToFile(JsonConvert.SerializeObject(this._config));
        }

        public void Set(string key, string value)
        {
            this._config[key] = value;
        }

        public void Set(ConfigKey key, string value)
        {
            this._config[key.Name] = value;
        }

        public string GetString(string key)
        {
            return !this._config.ContainsKey(key) ? null : this._config[key];
        }
        public string GetString(ConfigKey key)
        {
            return this._config[key.Name];
        }

        public int GetInt(ConfigKey key)
        {
            return int.Parse(this.GetString(key));
        }

        public double GetDouble(ConfigKey key)
        {
            return double.Parse(this.GetString(key));
        }

        private void CreateConfigFile()
        {
            if (File.Exists(ConfigFileName)) return;

            using (FileStream file = File.Create(ConfigFileName))
            {
            }

            this.WriteToFile(EmptyJson);
        }

        private Dictionary<string, string> GetParsedConfigFile()
        {
            try
            {
                return JsonConvert.DeserializeObject<Dictionary<string, string>>(this.ReadFile()) ?? new Dictionary<string, string>();
            }
            catch (Exception)
            {
                this.WriteToFile(EmptyJson);
                return new Dictionary<string, string>();
            }
        }

        private void ValidateConfigFields()
        {
            ICollection<string> keys = this._config.Keys;

            ConfigKey.All.ForEach(cfg =>
            {
                if (!keys.Contains(cfg.Name)) this.Set(cfg.Name, cfg.DefaultValue);
            });

            this.Save();
        }

        private string ReadFile()
        {
            return File.ReadAllText(ConfigFileName);
        }

        private void WriteToFile(string content)
        {
            File.WriteAllText(ConfigFileName, content);
        }
    }
}
