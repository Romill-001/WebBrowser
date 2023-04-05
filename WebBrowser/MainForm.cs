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
        public WebPage wp = new WebPage();
        public HistoryPage hp = new HistoryPage();
        public List<string> ListOfFav = new List<string>();
        public List<string> HistoryList = new List<string>();
        public Rectangle origFormSize;
        public Rectangle origUCSize;
        public Rectangle origUCSizeHis;
        public MainForm()
        {
            wp.Location = new Point(0, 31);
            hp.Location = new Point(0, 31);
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(searchBar.Text))
            {
                secSearchBar.Text = searchBar.Text;
                secSearchBar.ReadOnly = false;
                secSearchBar.Enabled = true;
                secSearchButton.Enabled = true;
                secSearchBar.Visible = true;
                secSearchButton.Visible = true;
                refreshButton.Enabled = true;
                stopLoadButton.Enabled = true;
                addToFavList.Enabled = true;
                wp.URL = secSearchBar.Text;
                wp.Navigate();
                SetPage(wp);
                HistoryList.Add(secSearchBar.Text);
            }
        }
        private void SetPage(UserControl wp)
        {
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
            prevButton.Enabled = true;
            wp.Navigate();
            HistoryList.Add(secSearchBar.Text);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            wp.Reload();
        }

        private void stopLoadButton_Click(object sender, EventArgs e)
        {
            wp.Cancel();
        }

        private void SearchKeyPressForMainSearchbar(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!String.IsNullOrEmpty(searchBar.Text))
                {
                    secSearchBar.Text = searchBar.Text;
                    secSearchBar.ReadOnly = false;
                    secSearchBar.Enabled = true;
                    secSearchButton.Enabled = true;
                    secSearchBar.Visible = true;
                    secSearchButton.Visible = true;
                    prevButton.Enabled = true;
                    refreshButton.Enabled = true;
                    stopLoadButton.Enabled = true;
                    addToFavList.Enabled = true;
                    wp.URL = secSearchBar.Text;
                    wp.Navigate();
                    SetPage(wp);
                    HistoryList.Add(secSearchBar.Text);
                }
            }
        }

        private void secSearchBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                wp.URL = secSearchBar.Text;
                wp.Navigate();
            }
        }

        private void addToFavList_Click(object sender, EventArgs e)
        {
            ListOfFav.Add(secSearchBar.Text);
        }

        private void ResizeUC(Rectangle r, Control us)
        {
            float xRatio = (float)this.Width / (float)origFormSize.Width;
            float yRatio = (float)this.Height/ (float)origFormSize.Height;

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            us.Location = new Point(newX, newY);
            us.Size = new Size(newWidth, newHeight);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            origUCSize = new Rectangle(wp.Location.X, wp.Location.Y, wp.Size.Width, wp.Size.Height);
            origUCSizeHis = new Rectangle(hp.Location.X, hp.Location.Y, hp.Size.Width, hp.Size.Height);
            origFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            ResizeUC(origUCSize, wp);
            ResizeUC(origUCSizeHis, hp);
        }

        private void историяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hp.check == false)
            {
                HistoryList.Clear();
            }
            hp.Show();
            hp.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            Controls.Add(hp);
            hp.ShowHistory(HistoryList);
            hp.BringToFront();
        }
    }
}
