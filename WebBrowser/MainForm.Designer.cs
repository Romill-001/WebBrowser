namespace WebBrowser
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.stopLoadButton = new System.Windows.Forms.Button();
            this.secSearchBar = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.secSearchButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.addToFavList = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.историяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закладкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBar
            // 
            this.searchBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.searchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBar.Location = new System.Drawing.Point(158, 170);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(433, 22);
            this.searchBar.TabIndex = 0;
            this.searchBar.WordWrap = false;
            this.searchBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchKeyPressForMainSearchbar);
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(331, 117);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(107, 33);
            this.label.TabIndex = 1;
            this.label.Text = "Браузер";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(303, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите URL адрес...";
            // 
            // prevButton
            // 
            this.prevButton.BackColor = System.Drawing.SystemColors.Window;
            this.prevButton.Enabled = false;
            this.prevButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prevButton.Location = new System.Drawing.Point(4, 5);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(22, 22);
            this.prevButton.TabIndex = 4;
            this.prevButton.Text = "<";
            this.description.SetToolTip(this.prevButton, "Предыдущая страница");
            this.prevButton.UseVisualStyleBackColor = false;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.SystemColors.Window;
            this.nextButton.Enabled = false;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextButton.Location = new System.Drawing.Point(32, 5);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(22, 22);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = ">";
            this.description.SetToolTip(this.nextButton, "Следующая страница");
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // stopLoadButton
            // 
            this.stopLoadButton.BackColor = System.Drawing.SystemColors.Window;
            this.stopLoadButton.Enabled = false;
            this.stopLoadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopLoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopLoadButton.Location = new System.Drawing.Point(88, 5);
            this.stopLoadButton.Name = "stopLoadButton";
            this.stopLoadButton.Size = new System.Drawing.Size(22, 22);
            this.stopLoadButton.TabIndex = 6;
            this.stopLoadButton.Text = "X";
            this.description.SetToolTip(this.stopLoadButton, "Прервать загрузку страниы");
            this.stopLoadButton.UseVisualStyleBackColor = false;
            this.stopLoadButton.Click += new System.EventHandler(this.stopLoadButton_Click);
            // 
            // secSearchBar
            // 
            this.secSearchBar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.secSearchBar.BackColor = System.Drawing.SystemColors.Window;
            this.secSearchBar.Enabled = false;
            this.secSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secSearchBar.Location = new System.Drawing.Point(144, 5);
            this.secSearchBar.Name = "secSearchBar";
            this.secSearchBar.ReadOnly = true;
            this.secSearchBar.Size = new System.Drawing.Size(592, 22);
            this.secSearchBar.TabIndex = 8;
            this.secSearchBar.Visible = false;
            this.secSearchBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.secSearchBar_KeyPress);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.searchButton.BackColor = System.Drawing.SystemColors.Window;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Image = global::WebBrowser.Properties.Resources.icons8_search_22;
            this.searchButton.Location = new System.Drawing.Point(597, 170);
            this.searchButton.MaximumSize = new System.Drawing.Size(22, 22);
            this.searchButton.MinimumSize = new System.Drawing.Size(22, 22);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(22, 22);
            this.searchButton.TabIndex = 3;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // secSearchButton
            // 
            this.secSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.secSearchButton.BackColor = System.Drawing.SystemColors.Window;
            this.secSearchButton.Enabled = false;
            this.secSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secSearchButton.Image = global::WebBrowser.Properties.Resources.icons8_search_22;
            this.secSearchButton.Location = new System.Drawing.Point(742, 5);
            this.secSearchButton.MaximumSize = new System.Drawing.Size(22, 22);
            this.secSearchButton.MinimumSize = new System.Drawing.Size(22, 22);
            this.secSearchButton.Name = "secSearchButton";
            this.secSearchButton.Size = new System.Drawing.Size(22, 22);
            this.secSearchButton.TabIndex = 9;
            this.secSearchButton.UseVisualStyleBackColor = false;
            this.secSearchButton.Visible = false;
            this.secSearchButton.Click += new System.EventHandler(this.secSearchButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.SystemColors.Window;
            this.refreshButton.Enabled = false;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refreshButton.Location = new System.Drawing.Point(60, 5);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(22, 22);
            this.refreshButton.TabIndex = 10;
            this.refreshButton.Text = "O";
            this.description.SetToolTip(this.refreshButton, "Обновить страницу");
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // addToFavList
            // 
            this.addToFavList.BackColor = System.Drawing.SystemColors.Window;
            this.addToFavList.Enabled = false;
            this.addToFavList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToFavList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToFavList.Location = new System.Drawing.Point(116, 5);
            this.addToFavList.Name = "addToFavList";
            this.addToFavList.Size = new System.Drawing.Size(22, 22);
            this.addToFavList.TabIndex = 11;
            this.addToFavList.Text = "+";
            this.description.SetToolTip(this.addToFavList, "Добавить в закладки");
            this.addToFavList.UseVisualStyleBackColor = false;
            this.addToFavList.Click += new System.EventHandler(this.addToFavList_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Location = new System.Drawing.Point(251, 317);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(202, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menu.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menu.Size = new System.Drawing.Size(804, 28);
            this.menu.TabIndex = 13;
            this.menu.Text = "menu";
            this.description.SetToolTip(this.menu, "Меню");
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.историяToolStripMenuItem,
            this.закладкиToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(36, 24);
            this.toolStripMenuItem1.Text = "...";
            // 
            // историяToolStripMenuItem
            // 
            this.историяToolStripMenuItem.Name = "историяToolStripMenuItem";
            this.историяToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.историяToolStripMenuItem.Text = "История";
            this.историяToolStripMenuItem.Click += new System.EventHandler(this.историяToolStripMenuItem_Click);
            // 
            // закладкиToolStripMenuItem
            // 
            this.закладкиToolStripMenuItem.Name = "закладкиToolStripMenuItem";
            this.закладкиToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.закладкиToolStripMenuItem.Text = "Закладки";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.addToFavList);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.secSearchButton);
            this.Controls.Add(this.secSearchBar);
            this.Controls.Add(this.stopLoadButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menu);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(820, 490);
            this.Name = "MainForm";
            this.Text = "Браузер";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button stopLoadButton;
        private System.Windows.Forms.TextBox secSearchBar;
        private System.Windows.Forms.Button secSearchButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button addToFavList;
        private System.Windows.Forms.ToolTip description;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem историяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закладкиToolStripMenuItem;
    }
}

