namespace SaymanProje
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.okulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğretmenlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrencilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maliyetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtreleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.okulToolStripMenuItem,
            this.öğretmenlerToolStripMenuItem,
            this.öğrencilerToolStripMenuItem,
            this.maliyetToolStripMenuItem,
            this.raporlarToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(962, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.filtreleToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // okulToolStripMenuItem
            // 
            this.okulToolStripMenuItem.Name = "okulToolStripMenuItem";
            this.okulToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.okulToolStripMenuItem.Text = "Okul";
            // 
            // öğretmenlerToolStripMenuItem
            // 
            this.öğretmenlerToolStripMenuItem.Name = "öğretmenlerToolStripMenuItem";
            this.öğretmenlerToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.öğretmenlerToolStripMenuItem.Text = "Öğretmenler";
            // 
            // öğrencilerToolStripMenuItem
            // 
            this.öğrencilerToolStripMenuItem.Name = "öğrencilerToolStripMenuItem";
            this.öğrencilerToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.öğrencilerToolStripMenuItem.Text = "Öğrenciler";
            // 
            // maliyetToolStripMenuItem
            // 
            this.maliyetToolStripMenuItem.Name = "maliyetToolStripMenuItem";
            this.maliyetToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.maliyetToolStripMenuItem.Text = "Maliyet";
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Image = global::SaymanProje.Properties.Resources.app_x_python_bytecode_icon;
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // filtreleToolStripMenuItem
            // 
            this.filtreleToolStripMenuItem.Image = global::SaymanProje.Properties.Resources.app_x_python_bytecode_icon;
            this.filtreleToolStripMenuItem.Name = "filtreleToolStripMenuItem";
            this.filtreleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.B)));
            this.filtreleToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.filtreleToolStripMenuItem.Text = "Filtrele";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 483);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem okulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğretmenlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrencilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maliyetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtreleToolStripMenuItem;
    }
}

