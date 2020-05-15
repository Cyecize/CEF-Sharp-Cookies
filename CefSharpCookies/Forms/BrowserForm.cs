using System;
using System.Windows.Forms;
using CefSharp.WinForms;
using CefSharpCookies.Enums;
using CefSharpCookies.Interfaces;

namespace CefSharpCookies.Forms
{
    public partial class BrowserForm : Form
    {
        private readonly ChromiumWebBrowser _browser;

        public BrowserForm(IConfigService configService)
        {
            InitializeComponent();

            this.InitFormPosition(configService);

            this._browser = new ChromiumWebBrowser(configService.GetString(ConfigKey.StartupUrl))
            {
                Dock = DockStyle.Fill,
            };

            this._browser.IsBrowserInitializedChanged += this.OnIsBrowserInitializedChanged;

            this.Controls.Add(this._browser);

            this.InitEvents(configService);
        }

        private void OnIsBrowserInitializedChanged(object sender, EventArgs e)
        {
            this._browser.Show();
            this.LblLoading.Hide();
        }

        private void InitFormPosition(IConfigService configService)
        {
            this.Width = configService.GetInt(ConfigKey.WindowWidth);
            this.Height = configService.GetInt(ConfigKey.WindowHeight);


            bool successfulParse = Enum.TryParse(configService.GetString(ConfigKey.WindowState), out FormWindowState state);

            if (successfulParse)
            {
                this.WindowState = state;
            }
        }

        private void InitEvents(IConfigService configService)
        {
            this.SizeChanged += (sender, eventArgs) =>
            {
                configService.Set(ConfigKey.WindowWidth, this.Width.ToString());
                configService.Set(ConfigKey.WindowHeight, this.Height.ToString());
            };


            this.FormClosing += (sender, eventArgs) =>
            {
                configService.Set(ConfigKey.WindowState, this.WindowState.ToString());
                configService.Save();
                Environment.Exit(0);
            };
        }
    }
}
