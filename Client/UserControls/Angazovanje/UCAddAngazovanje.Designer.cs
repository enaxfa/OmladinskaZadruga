using System.Windows.Forms;

namespace Client.UserControls.Posao
{
    partial class UCAddAngazovanje
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
            this.dgvPoslovi = new System.Windows.Forms.DataGridView();
            this.txtFilterPosao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvOmladinci = new System.Windows.Forms.DataGridView();
            this.txtFilterOmladinac = new System.Windows.Forms.TextBox();
            this.dtpDatumAngazovanja = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lblBrOml = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoslovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOmladinci)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 83;
            this.label1.Text = "Pretraži poslove";
            // 
            // dgvPoslovi
            // 
            this.dgvPoslovi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPoslovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoslovi.Location = new System.Drawing.Point(154, 120);
            this.dgvPoslovi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPoslovi.Name = "dgvPoslovi";
            this.dgvPoslovi.ReadOnly = true;
            this.dgvPoslovi.RowHeadersWidth = 51;
            this.dgvPoslovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPoslovi.Size = new System.Drawing.Size(795, 158);
            this.dgvPoslovi.TabIndex = 80;
            this.dgvPoslovi.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPoslovi_CellMouseClick);
            // 
            // txtFilterPosao
            // 
            this.txtFilterPosao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFilterPosao.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.txtFilterPosao.Location = new System.Drawing.Point(292, 76);
            this.txtFilterPosao.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilterPosao.Name = "txtFilterPosao";
            this.txtFilterPosao.Size = new System.Drawing.Size(247, 24);
            this.txtFilterPosao.TabIndex = 79;
            this.txtFilterPosao.TextChanged += new System.EventHandler(this.txtFilterPosao_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 86;
            this.label2.Text = "Pretraži omladince";
            // 
            // dgvOmladinci
            // 
            this.dgvOmladinci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvOmladinci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOmladinci.Location = new System.Drawing.Point(154, 389);
            this.dgvOmladinci.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOmladinci.Name = "dgvOmladinci";
            this.dgvOmladinci.ReadOnly = true;
            this.dgvOmladinci.RowHeadersWidth = 51;
            this.dgvOmladinci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOmladinci.Size = new System.Drawing.Size(795, 158);
            this.dgvOmladinci.TabIndex = 85;
            this.dgvOmladinci.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOmladinci_CellClick);
            this.dgvOmladinci.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOmladinci_CellMouseDown);
            // 
            // txtFilterOmladinac
            // 
            this.txtFilterOmladinac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFilterOmladinac.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.txtFilterOmladinac.Location = new System.Drawing.Point(292, 331);
            this.txtFilterOmladinac.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilterOmladinac.Name = "txtFilterOmladinac";
            this.txtFilterOmladinac.Size = new System.Drawing.Size(247, 24);
            this.txtFilterOmladinac.TabIndex = 84;
            this.txtFilterOmladinac.TextChanged += new System.EventHandler(this.txtFilterOmladinac_TextChanged);
            // 
            // dtpDatumAngazovanja
            // 
            this.dtpDatumAngazovanja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDatumAngazovanja.Location = new System.Drawing.Point(1047, 153);
            this.dtpDatumAngazovanja.Name = "dtpDatumAngazovanja";
            this.dtpDatumAngazovanja.Size = new System.Drawing.Size(267, 22);
            this.dtpDatumAngazovanja.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1044, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 88;
            this.label3.Text = "Datum angazovanja";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1044, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 16);
            this.label4.TabIndex = 89;
            this.label4.Text = "Broj potrebnih omladinaca za ovaj posao:";
            this.label4.Visible = false;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodaj.BackColor = System.Drawing.Color.MediumPurple;
            this.btnDodaj.Location = new System.Drawing.Point(1104, 305);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(156, 50);
            this.btnDodaj.TabIndex = 91;
            this.btnDodaj.Text = "Dodaj angazovanje";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lblBrOml
            // 
            this.lblBrOml.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBrOml.AutoSize = true;
            this.lblBrOml.Location = new System.Drawing.Point(1317, 227);
            this.lblBrOml.Name = "lblBrOml";
            this.lblBrOml.Size = new System.Drawing.Size(44, 16);
            this.lblBrOml.TabIndex = 92;
            this.lblBrOml.Text = "label5";
            this.lblBrOml.Visible = false;
            // 
            // UCAddAngazovanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblBrOml);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDatumAngazovanja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvOmladinci);
            this.Controls.Add(this.txtFilterOmladinac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPoslovi);
            this.Controls.Add(this.txtFilterPosao);
            this.Name = "UCAddAngazovanje";
            this.Size = new System.Drawing.Size(1440, 610);
            this.Load += new System.EventHandler(this.UCAddAngazovanje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoslovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOmladinci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPoslovi;
        private System.Windows.Forms.TextBox txtFilterPosao;
        private Label label2;
        private DataGridView dgvOmladinci;
        private TextBox txtFilterOmladinac;
        private DateTimePicker dtpDatumAngazovanja;
        private Label label3;
        private Label label4;
        private Button btnDodaj;
        private Label lblBrOml;
    }
}
