using System;
using System.Windows.Forms;
using CefSharpCookies.Forms;
using CefSharpCookies.Interfaces;
using CefSharpCookies.Services;
using CefSharpCookies.Util;

namespace CefSharpCookies
{
    public class StartUp
    {
        public static void Main(String[] args)
        {
            Application.EnableVisualStyles();

            IConfigService configService = new ConfigService();

            CefConfigUtil.InitCefConfig(configService);

            BrowserForm form = new BrowserForm(configService);
            Application.Run(form);
        }
    }
}
