namespace Server
{
    partial class FrmServer
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
            this.txtStanjeServera = new System.Windows.Forms.TextBox();
            this.lblStanje = new System.Windows.Forms.Label();
            this.btnZaustavi = new System.Windows.Forms.Button();
            this.btnPokreni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtStanjeServera
            // 
            this.txtStanjeServera.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStanjeServera.Enabled = false;
            this.txtStanjeServera.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStanjeServera.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtStanjeServera.Location = new System.Drawing.Point(277, 93);
            this.txtStanjeServera.Margin = new System.Windows.Forms.Padding(4);
            this.txtStanjeServera.Name = "txtStanjeServera";
            this.txtStanjeServera.ReadOnly = true;
            this.txtStanjeServera.Size = new System.Drawing.Size(173, 23);
            this.txtStanjeServera.TabIndex = 11;
            // 
            // lblStanje
            // 
            this.lblStanje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStanje.AutoSize = true;
            this.lblStanje.Location = new System.Drawing.Point(165, 96);
            this.lblStanje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStanje.Name = "lblStanje";
            this.lblStanje.Size = new System.Drawing.Size(97, 16);
            this.lblStanje.TabIndex = 10;
            this.lblStanje.Text = "Stanje servera:";
            // 
            // btnZaustavi
            // 
            this.btnZaustavi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnZaustavi.Location = new System.Drawing.Point(367, 153);
            this.btnZaustavi.Margin = new System.Windows.Forms.Padding(4);
            this.btnZaustavi.Name = "btnZaustavi";
            this.btnZaustavi.Size = new System.Drawing.Size(161, 60);
            this.btnZaustavi.TabIndex = 9;
            this.btnZaustavi.Text = "Stop";
            this.btnZaustavi.UseVisualStyleBackColor = true;
            this.btnZaustavi.Click += new System.EventHandler(this.btnZaustavi_Click);
            // 
            // btnPokreni
            // 
            this.btnPokreni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPokreni.Location = new System.Drawing.Point(98, 153);
            this.btnPokreni.Margin = new System.Windows.Forms.Padding(4);
            this.btnPokreni.Name = "btnPokreni";
            this.btnPokreni.Size = new System.Drawing.Size(156, 60);
            this.btnPokreni.TabIndex = 8;
            this.btnPokreni.Text = "Start";
            this.btnPokreni.UseVisualStyleBackColor = true;
            this.btnPokreni.Click += new System.EventHandler(this.btnPokreni_Click);
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 350);
            this.Controls.Add(this.txtStanjeServera);
            this.Controls.Add(this.lblStanje);
            this.Controls.Add(this.btnZaustavi);
            this.Controls.Add(this.btnPokreni);
            this.Name = "FrmServer";
            this.Text = "Serverska strana";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmServer_FormClosed);
            this.Load += new System.EventHandler(this.FrmServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStanjeServera;
        private System.Windows.Forms.Label lblStanje;
        private System.Windows.Forms.Button btnZaustavi;
        private System.Windows.Forms.Button btnPokreni;
    }
}

