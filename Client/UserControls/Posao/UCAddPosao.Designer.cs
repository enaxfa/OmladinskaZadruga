namespace Client.UserControls.Posao
{
    partial class UCAddPosao
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtBrOml = new System.Windows.Forms.TextBox();
            this.txtCenaRS = new System.Windows.Forms.TextBox();
            this.txtSat = new System.Windows.Forms.TextBox();
            this.txtLokacija = new System.Windows.Forms.TextBox();
            this.txtBrOmladinaca = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCena = new System.Windows.Forms.Label();
            this.txtSatnica = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPoslodavac = new System.Windows.Forms.ComboBox();
            this.cbTipPosla = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Poslodavac";
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.MediumPurple;
            this.btnDodaj.Location = new System.Drawing.Point(185, 362);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(215, 55);
            this.btnDodaj.TabIndex = 23;
            this.btnDodaj.Text = "Dodaj posao";
            this.btnDodaj.UseVisualStyleBackColor = false;
            // 
            // txtBrOml
            // 
            this.txtBrOml.Location = new System.Drawing.Point(187, 196);
            this.txtBrOml.Name = "txtBrOml";
            this.txtBrOml.Size = new System.Drawing.Size(213, 22);
            this.txtBrOml.TabIndex = 22;
            // 
            // txtCenaRS
            // 
            this.txtCenaRS.Location = new System.Drawing.Point(187, 244);
            this.txtCenaRS.Name = "txtCenaRS";
            this.txtCenaRS.Size = new System.Drawing.Size(213, 22);
            this.txtCenaRS.TabIndex = 21;
            // 
            // txtSat
            // 
            this.txtSat.Location = new System.Drawing.Point(185, 287);
            this.txtSat.Name = "txtSat";
            this.txtSat.Size = new System.Drawing.Size(215, 22);
            this.txtSat.TabIndex = 20;
            // 
            // txtLokacija
            // 
            this.txtLokacija.Location = new System.Drawing.Point(187, 146);
            this.txtLokacija.Name = "txtLokacija";
            this.txtLokacija.Size = new System.Drawing.Size(213, 22);
            this.txtLokacija.TabIndex = 19;
            // 
            // txtBrOmladinaca
            // 
            this.txtBrOmladinaca.AutoSize = true;
            this.txtBrOmladinaca.Location = new System.Drawing.Point(59, 196);
            this.txtBrOmladinaca.Name = "txtBrOmladinaca";
            this.txtBrOmladinaca.Size = new System.Drawing.Size(105, 16);
            this.txtBrOmladinaca.TabIndex = 18;
            this.txtBrOmladinaca.Text = "Broj omladinaca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tip posla";
            // 
            // txtCena
            // 
            this.txtCena.AutoSize = true;
            this.txtCena.Location = new System.Drawing.Point(59, 244);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(114, 16);
            this.txtCena.TabIndex = 16;
            this.txtCena.Text = "Cena radnog sata";
            // 
            // txtSatnica
            // 
            this.txtSatnica.AutoSize = true;
            this.txtSatnica.Location = new System.Drawing.Point(59, 287);
            this.txtSatnica.Name = "txtSatnica";
            this.txtSatnica.Size = new System.Drawing.Size(55, 16);
            this.txtSatnica.TabIndex = 15;
            this.txtSatnica.Text = "Broj sati";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Lokacija";
            // 
            // cbPoslodavac
            // 
            this.cbPoslodavac.FormattingEnabled = true;
            this.cbPoslodavac.Location = new System.Drawing.Point(187, 59);
            this.cbPoslodavac.Name = "cbPoslodavac";
            this.cbPoslodavac.Size = new System.Drawing.Size(213, 24);
            this.cbPoslodavac.TabIndex = 25;
            // 
            // cbTipPosla
            // 
            this.cbTipPosla.FormattingEnabled = true;
            this.cbTipPosla.Location = new System.Drawing.Point(187, 101);
            this.cbTipPosla.Name = "cbTipPosla";
            this.cbTipPosla.Size = new System.Drawing.Size(213, 24);
            this.cbTipPosla.TabIndex = 26;
            // 
            // UCAddPosao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbTipPosla);
            this.Controls.Add(this.cbPoslodavac);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtBrOml);
            this.Controls.Add(this.txtCenaRS);
            this.Controls.Add(this.txtSat);
            this.Controls.Add(this.txtLokacija);
            this.Controls.Add(this.txtBrOmladinaca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.txtSatnica);
            this.Controls.Add(this.label1);
            this.Name = "UCAddPosao";
            this.Size = new System.Drawing.Size(478, 481);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtBrOml;
        private System.Windows.Forms.TextBox txtCenaRS;
        private System.Windows.Forms.TextBox txtSat;
        private System.Windows.Forms.TextBox txtLokacija;
        private System.Windows.Forms.Label txtBrOmladinaca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtCena;
        private System.Windows.Forms.Label txtSatnica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPoslodavac;
        private System.Windows.Forms.ComboBox cbTipPosla;
    }
}
