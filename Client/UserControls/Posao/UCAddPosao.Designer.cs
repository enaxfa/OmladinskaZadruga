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
            this.labal2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labal3 = new System.Windows.Forms.Label();
            this.labal4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPoslodavac = new System.Windows.Forms.ComboBox();
            this.cbTipPosla = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Poslodavac";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodaj.BackColor = System.Drawing.Color.MediumPurple;
            this.btnDodaj.Location = new System.Drawing.Point(199, 345);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(215, 55);
            this.btnDodaj.TabIndex = 23;
            this.btnDodaj.Text = "Dodaj posao";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtBrOml
            // 
            this.txtBrOml.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBrOml.Location = new System.Drawing.Point(199, 192);
            this.txtBrOml.Name = "txtBrOml";
            this.txtBrOml.Size = new System.Drawing.Size(213, 22);
            this.txtBrOml.TabIndex = 22;
            // 
            // txtCenaRS
            // 
            this.txtCenaRS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCenaRS.Location = new System.Drawing.Point(199, 240);
            this.txtCenaRS.Name = "txtCenaRS";
            this.txtCenaRS.Size = new System.Drawing.Size(213, 22);
            this.txtCenaRS.TabIndex = 21;
            // 
            // txtSat
            // 
            this.txtSat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSat.Location = new System.Drawing.Point(197, 283);
            this.txtSat.Name = "txtSat";
            this.txtSat.Size = new System.Drawing.Size(215, 22);
            this.txtSat.TabIndex = 20;
            // 
            // txtLokacija
            // 
            this.txtLokacija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLokacija.Location = new System.Drawing.Point(199, 142);
            this.txtLokacija.Name = "txtLokacija";
            this.txtLokacija.Size = new System.Drawing.Size(213, 22);
            this.txtLokacija.TabIndex = 19;
            // 
            // labal2
            // 
            this.labal2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labal2.AutoSize = true;
            this.labal2.Location = new System.Drawing.Point(71, 192);
            this.labal2.Name = "labal2";
            this.labal2.Size = new System.Drawing.Size(105, 16);
            this.labal2.TabIndex = 18;
            this.labal2.Text = "Broj omladinaca";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tip posla";
            // 
            // labal3
            // 
            this.labal3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labal3.AutoSize = true;
            this.labal3.Location = new System.Drawing.Point(71, 240);
            this.labal3.Name = "labal3";
            this.labal3.Size = new System.Drawing.Size(114, 16);
            this.labal3.TabIndex = 16;
            this.labal3.Text = "Cena radnog sata";
            // 
            // labal4
            // 
            this.labal4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labal4.AutoSize = true;
            this.labal4.Location = new System.Drawing.Point(71, 283);
            this.labal4.Name = "labal4";
            this.labal4.Size = new System.Drawing.Size(55, 16);
            this.labal4.TabIndex = 15;
            this.labal4.Text = "Broj sati";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Lokacija";
            // 
            // cbPoslodavac
            // 
            this.cbPoslodavac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbPoslodavac.FormattingEnabled = true;
            this.cbPoslodavac.Location = new System.Drawing.Point(199, 55);
            this.cbPoslodavac.Name = "cbPoslodavac";
            this.cbPoslodavac.Size = new System.Drawing.Size(213, 24);
            this.cbPoslodavac.TabIndex = 25;
            
            // 
            // cbTipPosla
            // 
            this.cbTipPosla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTipPosla.FormattingEnabled = true;
            this.cbTipPosla.Location = new System.Drawing.Point(199, 97);
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
            this.Controls.Add(this.labal2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labal3);
            this.Controls.Add(this.labal4);
            this.Controls.Add(this.label1);
            this.Name = "UCAddPosao";
            this.Size = new System.Drawing.Size(485, 485);
            this.Load += new System.EventHandler(this.UCAddPosao_Load);
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
        private System.Windows.Forms.Label labal2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labal3;
        private System.Windows.Forms.Label labal4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPoslodavac;
        private System.Windows.Forms.ComboBox cbTipPosla;
    }
}
