namespace WebBrowser
{
    partial class WebPage
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.webBrowserPage = new System.Windows.Forms.WebBrowser();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.сохранитьСтраницуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowserPage
            // 
            this.webBrowserPage.ContextMenuStrip = this.contextMenu;
            this.webBrowserPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserPage.IsWebBrowserContextMenuEnabled = false;
            this.webBrowserPage.Location = new System.Drawing.Point(0, 0);
            this.webBrowserPage.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserPage.Name = "webBrowserPage";
            this.webBrowserPage.ScriptErrorsSuppressed = true;
            this.webBrowserPage.Size = new System.Drawing.Size(802, 422);
            this.webBrowserPage.TabIndex = 0;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьСтраницуToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(188, 26);
            // 
            // сохранитьСтраницуToolStripMenuItem
            // 
            this.сохранитьСтраницуToolStripMenuItem.Name = "сохранитьСтраницуToolStripMenuItem";
            this.сохранитьСтраницуToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.сохранитьСтраницуToolStripMenuItem.Text = "Сохранить страницу";
            this.сохранитьСтраницуToolStripMenuItem.Click += new System.EventHandler(this.сохранитьСтраницуToolStripMenuItem_Click);
            // 
            // WebPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.webBrowserPage);
            this.Name = "WebPage";
            this.Size = new System.Drawing.Size(802, 422);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserPage;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem сохранитьСтраницуToolStripMenuItem;
    }
}
