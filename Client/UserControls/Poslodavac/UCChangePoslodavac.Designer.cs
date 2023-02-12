using System.Windows.Forms;

namespace Client.UserControls.Poslodavac
{
    partial class UCChangePoslodavac
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
            this.dgvPoslodavci = new System.Windows.Forms.DataGridView();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.txtBrTelefona = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtPIB = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoslodavci)).BeginInit();
            this.pnlDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 83;
            this.label1.Text = "Pretraži poslodavce";
            // 
            // dgvPoslodavci
            // 
            this.dgvPoslodavci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPoslodavci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoslodavci.Location = new System.Drawing.Point(49, 167);
            this.dgvPoslodavci.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPoslodavci.Name = "dgvPoslodavci";
            this.dgvPoslodavci.ReadOnly = true;
            this.dgvPoslodavci.RowHeadersWidth = 51;
            this.dgvPoslodavci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPoslodavci.Size = new System.Drawing.Size(537, 206);
            this.dgvPoslodavci.TabIndex = 80;
            this.dgvPoslodavci.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPoslodavci_CellMouseClick);
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFilter.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.txtFilter.Location = new System.Drawing.Point(49, 117);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(247, 24);
            this.txtFilter.TabIndex = 79;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // pnlDetails
            // 
            this.pnlDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDetails.Controls.Add(this.btnObrisi);
            this.pnlDetails.Controls.Add(this.btnIzmeni);
            this.pnlDetails.Controls.Add(this.txtBrTelefona);
            this.pnlDetails.Controls.Add(this.txtEmail);
            this.pnlDetails.Controls.Add(this.txtAdresa);
            this.pnlDetails.Controls.Add(this.txtPIB);
            this.pnlDetails.Controls.Add(this.txtNaziv);
            this.pnlDetails.Controls.Add(this.label5);
            this.pnlDetails.Controls.Add(this.label4);
            this.pnlDetails.Controls.Add(this.label3);
            this.pnlDetails.Controls.Add(this.label2);
            this.pnlDetails.Controls.Add(this.label6);
            this.pnlDetails.Location = new System.Drawing.Point(644, 77);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(428, 448);
            this.pnlDetails.TabIndex = 78;
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.MediumPurple;
            this.btnObrisi.Enabled = false;
            this.btnObrisi.Location = new System.Drawing.Point(246, 344);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(145, 45);
            this.btnObrisi.TabIndex = 84;
            this.btnObrisi.Text = "Izbrisi poslodavca";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzmeni.BackColor = System.Drawing.Color.MediumPurple;
            this.btnIzmeni.Enabled = false;
            this.btnIzmeni.Location = new System.Drawing.Point(48, 344);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(145, 45);
            this.btnIzmeni.TabIndex = 21;
            this.btnIzmeni.Text = "Sacuvaj izmene";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // txtBrTelefona
            // 
            this.txtBrTelefona.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBrTelefona.Location = new System.Drawing.Point(158, 268);
            this.txtBrTelefona.Name = "txtBrTelefona";
            this.txtBrTelefona.Size = new System.Drawing.Size(228, 22);
            this.txtBrTelefona.TabIndex = 20;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(158, 215);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(228, 22);
            this.txtEmail.TabIndex = 19;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdresa.Location = new System.Drawing.Point(158, 163);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(228, 22);
            this.txtAdresa.TabIndex = 18;
            // 
            // txtPIB
            // 
            this.txtPIB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPIB.Location = new System.Drawing.Point(158, 107);
            this.txtPIB.Name = "txtPIB";
            this.txtPIB.Size = new System.Drawing.Size(228, 22);
            this.txtPIB.TabIndex = 17;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNaziv.Location = new System.Drawing.Point(158, 40);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(228, 22);
            this.txtNaziv.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Kontakt";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Adresa";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Naziv firme";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "PIB";
            // 
            // UCChangePoslodavac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPoslodavci);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.pnlDetails);
            this.Name = "UCChangePoslodavac";
            this.Size = new System.Drawing.Size(1150, 650);
            this.Load += new System.EventHandler(this.UCChangePoslodavac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoslodavci)).EndInit();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPoslodavci;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.TextBox txtBrTelefona;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtPIB;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}
