namespace PM_MaliyetHesaplama
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.defterMaliyetiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kutuMaliyetiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çantaMaliyetiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defterMaliyetiToolStripMenuItem,
            this.kutuMaliyetiToolStripMenuItem,
            this.çantaMaliyetiToolStripMenuItem,
            this.stokToolStripMenuItem,
            this.çalışanlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1484, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // defterMaliyetiToolStripMenuItem
            // 
            this.defterMaliyetiToolStripMenuItem.Name = "defterMaliyetiToolStripMenuItem";
            this.defterMaliyetiToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.defterMaliyetiToolStripMenuItem.Text = "Defter Maliyeti";
            this.defterMaliyetiToolStripMenuItem.Click += new System.EventHandler(this.DefterMaliyetiToolStripMenuItem_Click_1);
            // 
            // kutuMaliyetiToolStripMenuItem
            // 
            this.kutuMaliyetiToolStripMenuItem.Name = "kutuMaliyetiToolStripMenuItem";
            this.kutuMaliyetiToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.kutuMaliyetiToolStripMenuItem.Text = "Kutu Maliyeti";
            this.kutuMaliyetiToolStripMenuItem.Click += new System.EventHandler(this.KutuMaliyetiToolStripMenuItem_Click_1);
            // 
            // çantaMaliyetiToolStripMenuItem
            // 
            this.çantaMaliyetiToolStripMenuItem.Name = "çantaMaliyetiToolStripMenuItem";
            this.çantaMaliyetiToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.çantaMaliyetiToolStripMenuItem.Text = "Çanta Maliyeti";
            this.çantaMaliyetiToolStripMenuItem.Click += new System.EventHandler(this.CantaMaliyetiToolStripMenuItem_Click_1);
            // 
            // stokToolStripMenuItem
            // 
            this.stokToolStripMenuItem.Name = "stokToolStripMenuItem";
            this.stokToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.stokToolStripMenuItem.Text = "Teklifler";
            this.stokToolStripMenuItem.Click += new System.EventHandler(this.StokToolStripMenuItem_Click_1);
            // 
            // çalışanlarToolStripMenuItem
            // 
            this.çalışanlarToolStripMenuItem.Name = "çalışanlarToolStripMenuItem";
            this.çalışanlarToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.çalışanlarToolStripMenuItem.Text = "Stok";
            this.çalışanlarToolStripMenuItem.Click += new System.EventHandler(this.CalışanlarToolStripMenuItem_Click_1);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PM_MaliyetHesaplama.Properties.Resources.PM_LOGO;
            this.ClientSize = new System.Drawing.Size(1484, 861);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Anasayfa";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Anasayfa";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem defterMaliyetiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kutuMaliyetiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çantaMaliyetiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çalışanlarToolStripMenuItem;
    }
}