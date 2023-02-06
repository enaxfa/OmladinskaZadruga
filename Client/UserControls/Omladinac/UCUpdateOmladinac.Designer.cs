using System.Windows.Forms;

namespace Client.UserControls.Omladinac
{
    partial class UCUpdateOmladinac
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
            this.btnOdaberi = new System.Windows.Forms.Button();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.dgvOmladinci = new System.Windows.Forms.DataGridView();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.txtBrRacuna = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.txtBrTelefona = new System.Windows.Forms.TextBox();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.txtDatumRodjenja = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOmladinci)).BeginInit();
            this.pnlDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 77;
            this.label1.Text = "Pretraži omladince";
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOdaberi.BackColor = System.Drawing.Color.MediumPurple;
            this.btnOdaberi.Location = new System.Drawing.Point(354, 356);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(172, 43);
            this.btnOdaberi.TabIndex = 76;
            this.btnOdaberi.Text = "Izaberi omladinca";
            this.btnOdaberi.UseVisualStyleBackColor = false;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPretrazi.BackColor = System.Drawing.Color.MediumPurple;
            this.btnPretrazi.Location = new System.Drawing.Point(410, 74);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(116, 36);
            this.btnPretrazi.TabIndex = 75;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // dgvOmladinci
            // 
            this.dgvOmladinci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvOmladinci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOmladinci.Location = new System.Drawing.Point(36, 137);
            this.dgvOmladinci.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOmladinci.Name = "dgvOmladinci";
            this.dgvOmladinci.ReadOnly = true;
            this.dgvOmladinci.RowHeadersWidth = 51;
            this.dgvOmladinci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOmladinci.Size = new System.Drawing.Size(490, 195);
            this.dgvOmladinci.TabIndex = 74;

            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFilter.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.txtFilter.Location = new System.Drawing.Point(87, 86);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(247, 24);
            this.txtFilter.TabIndex = 73;
            // 
            // pnlDetails
            // 
            this.pnlDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDetails.Controls.Add(this.txtDatumRodjenja);
            this.pnlDetails.Controls.Add(this.btnObrisi);
            this.pnlDetails.Controls.Add(this.txtBrRacuna);
            this.pnlDetails.Controls.Add(this.label6);
            this.pnlDetails.Controls.Add(this.btnIzmeni);
            this.pnlDetails.Controls.Add(this.txtBrTelefona);
            this.pnlDetails.Controls.Add(this.txtJMBG);
            this.pnlDetails.Controls.Add(this.txtPrezime);
            this.pnlDetails.Controls.Add(this.txtIme);
            this.pnlDetails.Controls.Add(this.label5);
            this.pnlDetails.Controls.Add(this.label4);
            this.pnlDetails.Controls.Add(this.label3);
            this.pnlDetails.Controls.Add(this.label2);
            this.pnlDetails.Controls.Add(this.label7);
            this.pnlDetails.Location = new System.Drawing.Point(582, 69);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(374, 406);
            this.pnlDetails.TabIndex = 0;
            // 
            // txtBrRacuna
            // 
            this.txtBrRacuna.Location = new System.Drawing.Point(157, 206);
            this.txtBrRacuna.Name = "txtBrRacuna";
            this.txtBrRacuna.Size = new System.Drawing.Size(173, 22);
            this.txtBrRacuna.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Broj racuna";
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.Color.MediumPurple;
            this.btnIzmeni.Location = new System.Drawing.Point(44, 331);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(132, 31);
            this.btnIzmeni.TabIndex = 23;
            this.btnIzmeni.Text = "Sacuvaj izmene";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            // 
            // txtBrTelefona
            // 
            this.txtBrTelefona.Location = new System.Drawing.Point(157, 162);
            this.txtBrTelefona.Name = "txtBrTelefona";
            this.txtBrTelefona.Size = new System.Drawing.Size(173, 22);
            this.txtBrTelefona.TabIndex = 21;
            // 
            // txtJMBG
            // 
            this.txtJMBG.Location = new System.Drawing.Point(157, 118);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(173, 22);
            this.txtJMBG.TabIndex = 20;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(157, 74);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(173, 22);
            this.txtPrezime.TabIndex = 19;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(157, 25);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(173, 22);
            this.txtIme.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Broj telefona";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Datum rođenja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "JMBG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Prezime";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ime";
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.MediumPurple;
            this.btnObrisi.Location = new System.Drawing.Point(198, 331);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(132, 31);
            this.btnObrisi.TabIndex = 26;
            this.btnObrisi.Text = "Obrisi omladinca";
            this.btnObrisi.UseVisualStyleBackColor = false;
            // 
            // txtDatumRodjenja
            // 
            this.txtDatumRodjenja.Location = new System.Drawing.Point(157, 252);
            this.txtDatumRodjenja.Name = "txtDatumRodjenja";
            this.txtDatumRodjenja.Size = new System.Drawing.Size(173, 22);
            this.txtDatumRodjenja.TabIndex = 27;
            // 
            // UCUpdateOmladinac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOdaberi);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.dgvOmladinci);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.pnlDetails);
            this.Name = "UCUpdateOmladinac";
            this.Size = new System.Drawing.Size(989, 557);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOmladinci)).EndInit();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        public DataGridView DgvOmladinci { get => dgvOmladinci; set => dgvOmladinci = value; }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOdaberi;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.DataGridView dgvOmladinci;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.TextBox txtBrRacuna;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.TextBox txtBrTelefona;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.TextBox txtDatumRodjenja;
    }
}
