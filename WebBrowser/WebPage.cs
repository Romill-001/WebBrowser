using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class WebPage : UserControl
    {
        public string URL { get; set; }
        public WebPage()
        {
            InitializeComponent();
            webBrowserPage.ContextMenuStrip = contextMenu;
        }
        public void Navigate()
        {
            if (String.IsNullOrEmpty(URL)) return;
            if (URL.Equals("about:blank")) return;
            if (!URL.StartsWith("http://") &&
                !URL.StartsWith("https://"))
            {
                URL = "http://" + URL;
            }
            try
            {
                webBrowserPage.Navigate(new Uri(URL));
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }
        public void Prev()
        {
            webBrowserPage.GoBack();
        }
        public void Next()
        {
            webBrowserPage.GoForward();
        }
        public void Reload()
        {
            webBrowserPage.Refresh();
        }
        public void Cancel()
        {
            webBrowserPage.Stop();
        }

        private void сохранитьСтраницуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowserPage.ShowSaveAsDialog();
        }
    }
}
