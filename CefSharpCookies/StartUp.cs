using System;
using System.IO;
using CefSharpCookies.Enums;
using CefSharpCookies.Interfaces;
using CefSharpCookies.Services;
using CefSharpCookies.Util;

namespace CefSharpCookies
{
    public class StartUp
    {
        public static void Main(String[] args)
        {
            IConfigService configService = new ConfigService();

            CefConfigUtil.InitCefConfig(configService);
        }
    }
}
