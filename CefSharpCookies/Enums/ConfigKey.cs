using System.Collections.Generic;
using System.Windows.Forms;

namespace CefSharpCookies.Enums
{
    public class ConfigKey
    {

        public static readonly ConfigKey StartupUrl =
            new ConfigKey("startupURL", "http://google.com");

        public static readonly ConfigKey CacheFolderName = 
            new ConfigKey("cacheFolderName", "CefCache");

        public static readonly ConfigKey WindowState = 
            new ConfigKey("formWindowState", FormWindowState.Normal.ToString());

        public static readonly ConfigKey WindowHeight = 
            new ConfigKey("windowHeight", "768");

        public static readonly ConfigKey WindowWidth = 
            new ConfigKey("windowWidth", "1366"); 

        public static readonly List<ConfigKey> All = new List<ConfigKey>
        {
            StartupUrl,
            CacheFolderName,
            WindowState,
            WindowHeight,
            WindowWidth
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
