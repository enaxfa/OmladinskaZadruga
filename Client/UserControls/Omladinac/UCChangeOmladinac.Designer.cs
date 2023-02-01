namespace Client.UserControls.Omladinac
{
    partial class UCChangeOmladinac
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
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOdaberi = new System.Windows.Forms.Button();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.dgvOmladinci = new System.Windows.Forms.DataGridView();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOmladinci)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetails
            // 
            this.pnlDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDetails.Location = new System.Drawing.Point(595, 69);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(361, 408);
            this.pnlDetails.TabIndex = 0;
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
            // btnIzbrisi
            // 
            this.btnIzbrisi.BackColor = System.Drawing.Color.MediumPurple;
            this.btnIzbrisi.Location = new System.Drawing.Point(354, 423);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(172, 45);
            this.btnIzbrisi.TabIndex = 79;
            this.btnIzbrisi.Text = "Izbrisi omladinca";
            this.btnIzbrisi.UseVisualStyleBackColor = false;
            // 
            // UCChangeOmladinac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOdaberi);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.dgvOmladinci);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.pnlDetails);
            this.Name = "UCChangeOmladinac";
            this.Size = new System.Drawing.Size(989, 557);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOmladinci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOdaberi;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.DataGridView dgvOmladinci;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnIzbrisi;
    }
}
