using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace PriceManager
{
    public partial class Form2 : Form
    {

        public ChromiumWebBrowser chromeBrowser;


        public Form2()
        {
            InitializeComponent();

            InitializeChromium();


        }

        public void InitializeChromium()
        {
            CefSettings settings = new CefSettings();
            settings.RemoteDebuggingPort = 8088;
            BrowserSettings sett = new BrowserSettings();
            sett.WebSecurity = CefState.Disabled;
            // Initialize cef with the provided settings
            Cef.Initialize(settings);

            // Create a browser component

            chromeBrowser = new ChromiumWebBrowser(AppDomain.CurrentDomain.BaseDirectory + "scene.html");

            // Add it to the form and fill it to the form window.
            this.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
        }

    }
}
