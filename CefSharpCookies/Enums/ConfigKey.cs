using System.Collections.Generic;

namespace CefSharpCookies.Enums
{
    public class ConfigKey
    {

        public static readonly ConfigKey StartupUrl =
            new ConfigKey("startupURL", "http://google.com");


        public static readonly List<ConfigKey> All = new List<ConfigKey>
        {
            StartupUrl
        };

        public ConfigKey(string name, string defaultValue)
        {
            this.Name = name;
            this.DefaultValue = defaultValue;
        }

        public string Name { get; set; }

        public string DefaultValue { get; set; }
    }
}
