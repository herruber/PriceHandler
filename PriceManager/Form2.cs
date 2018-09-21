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
using System.Runtime.InteropServices;
using System.IO;
using Newtonsoft.Json;

namespace PriceManager
{
    public partial class Form2 : Form
    {

        public ChromiumWebBrowser chromeBrowser;
        public static ScriptManager manager;
        [ComVisible(true)] //Visible to the js
        public class ScriptManager
        {
            private Form2 form;

            public ScriptManager(Form2 _form)
            {
                form = _form;
            }

            public void SetImage(string base64)
            {

            }
        }


        public Form2()
        {
            InitializeComponent();

            manager = new ScriptManager(this);
            InitializeChromium();

            CefSharpSettings.LegacyJavascriptBindingEnabled = true;
            chromeBrowser.RegisterJsObject("scriptManager", manager);

        }

        public void InitializeChromium()
        {
            CefSettings settings = new CefSettings();

            settings.RemoteDebuggingPort = 8088;
            BrowserSettings sett = new BrowserSettings();
            sett.Javascript = CefState.Enabled;

            sett.WebSecurity = CefState.Disabled;
            // Initialize cef with the provided settings
            Cef.Initialize(settings);

            // Create a browser component

            chromeBrowser = new ChromiumWebBrowser(AppDomain.CurrentDomain.BaseDirectory + "scene.html");

            // Add it to the form and fill it to the form window.

            Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Select_Click(object sender, EventArgs e)
        {

            Button b = (sender as Button);

            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (b.Name.Contains("select"))
                    {
                        var p = (Panel)b.Parent;
                        PictureBox pBox;


                        for (int i = 0; i < p.Controls.Count; i++)
                        {
                            var c = p.Controls[i];

                            if (c.Name.Contains("picture"))
                            {
                                pBox = (c as PictureBox);
                                pBox.SizeMode = PictureBoxSizeMode.StretchImage;
                                pBox.Image = Image.FromFile(dlg.FileName);


                                byte[] data;

                               
                                var path = dlg.FileName;

                                var json = Convert.ToBase64String(File.ReadAllBytes(dlg.FileName));

                                string type = p.Name.Split('_')[1];

                               
                                chromeBrowser.ExecuteScriptAsync("setTexture", json, type);
                            }
                        }
                    }
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            var tbar = (sender as TrackBar);
            chromeBrowser.ExecuteScriptAsync("setFloat", (float)tbar.Value / 100f, tbar.Name);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            string[] info = textBox5.Text.Split(',');

            if (info.Length > 1)
            {

                try
                {
                    float x = float.Parse(info[0]);
                    float y = float.Parse(info[1]);
                    chromeBrowser.ExecuteScriptAsync("setTiling", x, y);
                }
                catch (Exception)
                {

                    
                }

            }
          
        }
    }
}
