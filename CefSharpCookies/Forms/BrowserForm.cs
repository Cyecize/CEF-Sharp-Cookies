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

        private void InitEvents(IConfigService configService)
        {
            //TODO: init events.
        }
    }
}
