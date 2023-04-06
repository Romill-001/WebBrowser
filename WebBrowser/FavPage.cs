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
    public partial class FavPage : UserControl
    {
        public List<Panel> Panels = new List<Panel>();
        public List<string> fav = new List<string>();
        List<string> deleted = new List<string>();
        public FavPage()
        {
            InitializeComponent();
        }
        public void ShowFav(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Label label = new Label
                {
                    Text = list[i],
                    AutoSize = true,
                    BorderStyle = BorderStyle.FixedSingle,
                    Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),
                    Location = new Point(5, 5),
                    Tag = i,
                    BackColor = SystemColors.ControlLightLight
                };
                Button deleteBtn = new Button
                {
                    Text = "Удалить",
                    FlatStyle = FlatStyle.Flat,
                    Size = new Size(70,26),
                    Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),
                    Location = new Point(626, 1),
                    Tag = i
                };
                deleteBtn.Click += new EventHandler(deleteBtn_Click);
                Panel panel = new Panel
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    Location = new Point(2, 64 + 30 * i),
                    Size = new Size(700, 30),
                    Tag = i,
                    BackColor = SystemColors.ControlLightLight
                };
                panel.Controls.Add(label);
                panel.Controls.Add(deleteBtn);
                this.Controls.Add((Control)panel);
                Panels.Add(panel);
            }
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int this_tag = int.Parse(((Button)sender).Tag.ToString());
            for (int i = 0; i < Panels.Count; i++)
            {
                if (Panels[i].Tag.Equals(this_tag))
                {
                    Panels[i].Visible = false;
                    deleted.Add(fav[i]);
                    for (int j = i; j < Panels.Count; j++)
                    {
                        Panels[j].Location = new Point(Panels[j].Location.X, Panels[j].Location.Y-30);
                    }
                }
            }
        }
        public void Del()
        {
            MainForm m = new MainForm();
            foreach(string t in deleted)
            {
                fav.Remove(t);
                m.DeleteDataFav(t);
            }
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            for (int i = 0; i < Panels.Count; i++)
            {
                Panels[i].Dispose();
            }
            Del();
            Panels.Clear();
        }
    }
}
