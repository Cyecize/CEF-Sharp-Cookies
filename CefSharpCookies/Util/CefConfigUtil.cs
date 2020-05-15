using System.IO;
using CefSharp;
using CefSharp.WinForms;
using CefSharpCookies.Enums;
using CefSharpCookies.Interfaces;

namespace CefSharpCookies.Util
{
    public static class CefConfigUtil
    {
        public static void InitCefConfig(IConfigService configService)
        {
            //To avoid leaving chromium sub process running.
            CefSharpSettings.SubprocessExitIfParentProcessClosed = true;

            Cef.EnableHighDPISupport();
            CefSettings settings = GetCefSettings(configService);
        
            Cef.Initialize(settings, performDependencyCheck: true, browserProcessHandler: null);
        }

        private static CefSettings GetCefSettings(IConfigService configService)
        {
            CefSettings settings = new CefSettings
            {
                CachePath = Path.Combine(Directory.GetCurrentDirectory(),
                    configService.GetString(ConfigKey.CacheFolderName)),
                PersistSessionCookies = configService.GetBool(ConfigKey.StoreCookies),
                CefCommandLineArgs = { "renderer-process-limit" , "1"}
            };


            return settings;
        }
    }
}
