namespace Client.UserControls.Angazovanje
{
    partial class UCChangeAngazovanje
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAngazovanja = new System.Windows.Forms.DataGridView();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.pnlOmladinac = new System.Windows.Forms.Panel();
            this.txtDatumRodj = new System.Windows.Forms.TextBox();
            this.txtBrRacOml = new System.Windows.Forms.TextBox();
            this.txtBrTelOml = new System.Windows.Forms.TextBox();
            this.txtImeOmladinca = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlPosao = new System.Windows.Forms.Panel();
            this.txtBrOml = new System.Windows.Forms.TextBox();
            this.txtCenaRS = new System.Windows.Forms.TextBox();
            this.txtSatnica = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPoslodavac = new System.Windows.Forms.TextBox();
            this.txtPosao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.dgvOmladinci = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFilterOml = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpDatumAngazovanja = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAngazovanja)).BeginInit();
            this.pnlOmladinac.SuspendLayout();
            this.pnlPosao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOmladinci)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 81;
            this.label1.Text = "Pretraži angazovanja";
            // 
            // dgvAngazovanja
            // 
            this.dgvAngazovanja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvAngazovanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAngazovanja.Location = new System.Drawing.Point(88, 160);
            this.dgvAngazovanja.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAngazovanja.Name = "dgvAngazovanja";
            this.dgvAngazovanja.ReadOnly = true;
            this.dgvAngazovanja.RowHeadersWidth = 51;
            this.dgvAngazovanja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAngazovanja.Size = new System.Drawing.Size(573, 209);
            this.dgvAngazovanja.TabIndex = 79;
            this.dgvAngazovanja.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAngazovanja_CellMouseClick);
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFilter.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.txtFilter.Location = new System.Drawing.Point(88, 110);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(247, 24);
            this.txtFilter.TabIndex = 78;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // pnlOmladinac
            // 
            this.pnlOmladinac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlOmladinac.Controls.Add(this.txtDatumRodj);
            this.pnlOmladinac.Controls.Add(this.txtBrRacOml);
            this.pnlOmladinac.Controls.Add(this.txtBrTelOml);
            this.pnlOmladinac.Controls.Add(this.txtImeOmladinca);
            this.pnlOmladinac.Controls.Add(this.label6);
            this.pnlOmladinac.Controls.Add(this.label5);
            this.pnlOmladinac.Controls.Add(this.label4);
            this.pnlOmladinac.Controls.Add(this.label2);
            this.pnlOmladinac.Location = new System.Drawing.Point(743, 56);
            this.pnlOmladinac.Name = "pnlOmladinac";
            this.pnlOmladinac.Size = new System.Drawing.Size(673, 88);
            this.pnlOmladinac.TabIndex = 82;
            // 
            // txtDatumRodj
            // 
            this.txtDatumRodj.Enabled = false;
            this.txtDatumRodj.Location = new System.Drawing.Point(487, 32);
            this.txtDatumRodj.Name = "txtDatumRodj";
            this.txtDatumRodj.Size = new System.Drawing.Size(100, 22);
            this.txtDatumRodj.TabIndex = 7;
            // 
            // txtBrRacOml
            // 
            this.txtBrRacOml.Enabled = false;
            this.txtBrRacOml.Location = new System.Drawing.Point(323, 32);
            this.txtBrRacOml.Name = "txtBrRacOml";
            this.txtBrRacOml.Size = new System.Drawing.Size(100, 22);
            this.txtBrRacOml.TabIndex = 6;
            // 
            // txtBrTelOml
            // 
            this.txtBrTelOml.Enabled = false;
            this.txtBrTelOml.Location = new System.Drawing.Point(161, 32);
            this.txtBrTelOml.Name = "txtBrTelOml";
            this.txtBrTelOml.Size = new System.Drawing.Size(100, 22);
            this.txtBrTelOml.TabIndex = 5;
            // 
            // txtImeOmladinca
            // 
            this.txtImeOmladinca.Enabled = false;
            this.txtImeOmladinca.Location = new System.Drawing.Point(3, 32);
            this.txtImeOmladinca.Name = "txtImeOmladinca";
            this.txtImeOmladinca.Size = new System.Drawing.Size(100, 22);
            this.txtImeOmladinca.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(492, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Datum rođenja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Broj racuna";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Beoj telefona";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Omladinac";
            // 
            // pnlPosao
            // 
            this.pnlPosao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPosao.Controls.Add(this.txtBrOml);
            this.pnlPosao.Controls.Add(this.txtCenaRS);
            this.pnlPosao.Controls.Add(this.txtSatnica);
            this.pnlPosao.Controls.Add(this.label10);
            this.pnlPosao.Controls.Add(this.label9);
            this.pnlPosao.Controls.Add(this.label8);
            this.pnlPosao.Controls.Add(this.label7);
            this.pnlPosao.Controls.Add(this.txtPoslodavac);
            this.pnlPosao.Controls.Add(this.txtPosao);
            this.pnlPosao.Controls.Add(this.label3);
            this.pnlPosao.Location = new System.Drawing.Point(740, 160);
            this.pnlPosao.Name = "pnlPosao";
            this.pnlPosao.Size = new System.Drawing.Size(679, 101);
            this.pnlPosao.TabIndex = 83;
            // 
            // txtBrOml
            // 
            this.txtBrOml.Enabled = false;
            this.txtBrOml.Location = new System.Drawing.Point(556, 32);
            this.txtBrOml.Name = "txtBrOml";
            this.txtBrOml.Size = new System.Drawing.Size(79, 22);
            this.txtBrOml.TabIndex = 9;
            // 
            // txtCenaRS
            // 
            this.txtCenaRS.Enabled = false;
            this.txtCenaRS.Location = new System.Drawing.Point(424, 32);
            this.txtCenaRS.Name = "txtCenaRS";
            this.txtCenaRS.Size = new System.Drawing.Size(79, 22);
            this.txtCenaRS.TabIndex = 8;
            // 
            // txtSatnica
            // 
            this.txtSatnica.Enabled = false;
            this.txtSatnica.Location = new System.Drawing.Point(316, 32);
            this.txtSatnica.Name = "txtSatnica";
            this.txtSatnica.Size = new System.Drawing.Size(68, 22);
            this.txtSatnica.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(532, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Potrebno omladinaca";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(435, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Cena sata";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(323, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Satnica";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(184, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Poslodavac";
            // 
            // txtPoslodavac
            // 
            this.txtPoslodavac.Enabled = false;
            this.txtPoslodavac.Location = new System.Drawing.Point(164, 32);
            this.txtPoslodavac.Name = "txtPoslodavac";
            this.txtPoslodavac.Size = new System.Drawing.Size(117, 22);
            this.txtPoslodavac.TabIndex = 2;
            // 
            // txtPosao
            // 
            this.txtPosao.Enabled = false;
            this.txtPosao.Location = new System.Drawing.Point(0, 32);
            this.txtPosao.Name = "txtPosao";
            this.txtPosao.Size = new System.Drawing.Size(136, 22);
            this.txtPosao.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Posao";
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzmeni.BackColor = System.Drawing.Color.MediumPurple;
            this.btnIzmeni.Enabled = false;
            this.btnIzmeni.Location = new System.Drawing.Point(88, 408);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(145, 45);
            this.btnIzmeni.TabIndex = 85;
            this.btnIzmeni.Text = "Sacuvaj izmene";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // dgvOmladinci
            // 
            this.dgvOmladinci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvOmladinci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOmladinci.Location = new System.Drawing.Point(740, 344);
            this.dgvOmladinci.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOmladinci.Name = "dgvOmladinci";
            this.dgvOmladinci.ReadOnly = true;
            this.dgvOmladinci.RowHeadersWidth = 51;
            this.dgvOmladinci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOmladinci.Size = new System.Drawing.Size(668, 144);
            this.dgvOmladinci.TabIndex = 87;
            this.dgvOmladinci.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOmladinci_CellMouseClick);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(743, 303);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 16);
            this.label11.TabIndex = 89;
            this.label11.Text = "Pretraži omladince";
            // 
            // txtFilterOml
            // 
            this.txtFilterOml.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFilterOml.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.txtFilterOml.Location = new System.Drawing.Point(904, 298);
            this.txtFilterOml.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilterOml.Name = "txtFilterOml";
            this.txtFilterOml.Size = new System.Drawing.Size(247, 24);
            this.txtFilterOml.TabIndex = 88;
            this.txtFilterOml.TextChanged += new System.EventHandler(this.txtFilterOml_TextChanged);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(743, 526);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 16);
            this.label12.TabIndex = 91;
            this.label12.Text = "Datum angazovanja";
            // 
            // dtpDatumAngazovanja
            // 
            this.dtpDatumAngazovanja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDatumAngazovanja.Location = new System.Drawing.Point(904, 526);
            this.dtpDatumAngazovanja.Name = "dtpDatumAngazovanja";
            this.dtpDatumAngazovanja.Size = new System.Drawing.Size(247, 22);
            this.dtpDatumAngazovanja.TabIndex = 90;
            this.dtpDatumAngazovanja.MouseEnter += new System.EventHandler(this.dtpDatumAngazovanja_MouseEnter);
            // 
            // UCChangeAngazovanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpDatumAngazovanja);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtFilterOml);
            this.Controls.Add(this.dgvOmladinci);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.pnlPosao);
            this.Controls.Add(this.pnlOmladinac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAngazovanja);
            this.Controls.Add(this.txtFilter);
            this.Name = "UCChangeAngazovanje";
            this.Size = new System.Drawing.Size(1440, 610);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAngazovanja)).EndInit();
            this.pnlOmladinac.ResumeLayout(false);
            this.pnlOmladinac.PerformLayout();
            this.pnlPosao.ResumeLayout(false);
            this.pnlPosao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOmladinci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAngazovanja;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Panel pnlOmladinac;
        private System.Windows.Forms.TextBox txtDatumRodj;
        private System.Windows.Forms.TextBox txtBrRacOml;
        private System.Windows.Forms.TextBox txtBrTelOml;
        private System.Windows.Forms.TextBox txtImeOmladinca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlPosao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBrOml;
        private System.Windows.Forms.TextBox txtCenaRS;
        private System.Windows.Forms.TextBox txtSatnica;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPoslodavac;
        private System.Windows.Forms.TextBox txtPosao;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.DataGridView dgvOmladinci;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFilterOml;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpDatumAngazovanja;
    }
}
