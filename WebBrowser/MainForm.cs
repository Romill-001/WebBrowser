using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace WebBrowser
{
    public partial class MainForm : Form
    {
        public WebPage wp = new WebPage();
        public HistoryPage hp = new HistoryPage();
        public FavPage fp = new FavPage();
        public Rectangle origFormSize;
        public Rectangle origUCSize;
        public Rectangle origUCSizeHis;
        public Rectangle origUCSizeFav;
        XmlDocument data = new XmlDocument();
        public MainForm()
        {
            data.Load(@"./../../HistoryData.xml");
            wp.Location = new Point(0, 31);
            hp.Location = new Point(0, 31);
            fp.Location= new Point(0, 31);
            ToList(hp.hist, data.DocumentElement);
            InitializeComponent();
            foreach (XmlNode elem in data.DocumentElement) elem.RemoveAll();
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
                SaveToXml(secSearchBar.Text);
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
            SaveToXml(secSearchBar.Text);
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
                    SaveToXml(secSearchBar.Text);
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
            fp.fav.Add(secSearchBar.Text);
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
            origUCSizeFav = new Rectangle(fp.Location.X, fp.Location.Y, fp.Size.Width, fp.Size.Height);
            origFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            ResizeUC(origUCSize, wp);
            ResizeUC(origUCSizeHis, hp);
            ResizeUC(origUCSizeFav, fp);
        }
        private void историяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fp.Hide();
            hp.Show();
            hp.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            Controls.Add(hp);
            hp.ShowHistory(hp.hist);
            hp.BringToFront();

        }
        private void закладкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hp.Hide();
            fp.Show();
            fp.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            Controls.Add(fp);
            fp.ShowFav(fp.fav);
            fp.BringToFront();
            if (hp.check == true)
            {
                DeleteData(data.DocumentElement);
            }
        }
        public void SaveToXml(string url)
        {
            XmlElement root = data.DocumentElement;
            XmlElement site = data.CreateElement("site");
            XmlElement URL = data.CreateElement("url");
            XmlElement date = data.CreateElement("date");
            XmlText urltext = data.CreateTextNode(url);
            XmlText datetext = data.CreateTextNode(DateTime.Now.ToString("dd.MM.yyyy | hh:mm:ss tt"));
            URL.AppendChild(urltext);
            date.AppendChild(datetext);
            site.AppendChild(URL);
            site.AppendChild(date);
            root.AppendChild(site);
            data.Save(@"./../../HistoryData.xml");
            hp.hist.Add($"{url} {DateTime.Now:dd.MM.yyyy | hh:mm:ss tt}");
        }
        public void ToList(List<string> list, XmlElement doc) // добавление информации при запуске прграммы
        {
            foreach (XmlElement elem in doc)
            {
                list.Add($"{elem.ChildNodes[0].InnerText} {elem.ChildNodes[1].InnerText}");
            }
        }
        public void DeleteData(XmlElement data)
        {
            foreach (XmlNode elem in data) elem.RemoveAll();
        }
    }   
}
