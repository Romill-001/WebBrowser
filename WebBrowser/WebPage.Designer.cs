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
            this.webBrowserPage = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowserPage
            // 
            this.webBrowserPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserPage.Location = new System.Drawing.Point(0, 0);
            this.webBrowserPage.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserPage.Name = "webBrowserPage";
            this.webBrowserPage.Size = new System.Drawing.Size(802, 422);
            this.webBrowserPage.TabIndex = 0;
            // 
            // WebPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.webBrowserPage);
            this.Name = "WebPage";
            this.Size = new System.Drawing.Size(802, 422);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserPage;
    }
}
