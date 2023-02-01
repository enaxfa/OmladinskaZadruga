namespace Client
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.omladinacToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poslodavacToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.omladinacToolStripMenuItem,
            this.poslodavacToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // omladinacToolStripMenuItem
            // 
            this.omladinacToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem,
            this.izmeniToolStripMenuItem});
            this.omladinacToolStripMenuItem.Name = "omladinacToolStripMenuItem";
            this.omladinacToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.omladinacToolStripMenuItem.Text = "Omladinac";
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            // 
            // izmeniToolStripMenuItem
            // 
            this.izmeniToolStripMenuItem.Name = "izmeniToolStripMenuItem";
            this.izmeniToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.izmeniToolStripMenuItem.Text = "Izmeni";
            // 
            // poslodavacToolStripMenuItem
            // 
            this.poslodavacToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem1,
            this.izmeniToolStripMenuItem1});
            this.poslodavacToolStripMenuItem.Name = "poslodavacToolStripMenuItem";
            this.poslodavacToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.poslodavacToolStripMenuItem.Text = "Poslodavac";
            // 
            // dodajToolStripMenuItem1
            // 
            this.dodajToolStripMenuItem1.Name = "dodajToolStripMenuItem1";
            this.dodajToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.dodajToolStripMenuItem1.Text = "Dodaj";
            // 
            // izmeniToolStripMenuItem1
            // 
            this.izmeniToolStripMenuItem1.Name = "izmeniToolStripMenuItem1";
            this.izmeniToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.izmeniToolStripMenuItem1.Text = "Izmeni";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem omladinacToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poslodavacToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem izmeniToolStripMenuItem1;
    }
}