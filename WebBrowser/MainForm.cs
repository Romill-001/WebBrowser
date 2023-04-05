using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class MainForm : Form
    {
        WebPage wp = new WebPage();
        public MainForm()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            secSearchBar.Text = searchBar.Text;
            secSearchBar.ReadOnly = false;
            secSearchBar.Enabled = true;
            secSearchButton.Enabled = true;
            prevButton.Enabled = true;
            refreshButton.Enabled = true;
            stopLoadButton.Enabled = true;
            wp.URL = secSearchBar.Text;
            wp.Navigate();
            SetPage(wp);
        }
        private void SetPage(UserControl wp)
        {
            wp.Location = new Point(-2, 31);
            wp.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            Controls.Add(wp);
            wp.BringToFront();
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            wp.Prev();
            nextButton.Enabled = true;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            wp.Next();
        }

        private void secSearchButton_Click(object sender, EventArgs e)
        {
            wp.URL = secSearchBar.Text;
            wp.Navigate();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            wp.Reload();
        }

        private void stopLoadButton_Click(object sender, EventArgs e)
        {
            wp.Cancel();
        }
    }
}
