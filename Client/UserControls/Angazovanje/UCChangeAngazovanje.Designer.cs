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
            this.btnOdaberi = new System.Windows.Forms.Button();
            this.dgvAngazovanja = new System.Windows.Forms.DataGridView();
            this.txtFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAngazovanja)).BeginInit();
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
            // btnOdaberi
            // 
            this.btnOdaberi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOdaberi.BackColor = System.Drawing.Color.MediumPurple;
            this.btnOdaberi.Location = new System.Drawing.Point(489, 407);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(172, 45);
            this.btnOdaberi.TabIndex = 80;
            this.btnOdaberi.Text = "Izaberi angazovanje";
            this.btnOdaberi.UseVisualStyleBackColor = false;
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
            // 
            // UCChangeAngazovanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOdaberi);
            this.Controls.Add(this.dgvAngazovanja);
            this.Controls.Add(this.txtFilter);
            this.Name = "UCChangeAngazovanje";
            this.Size = new System.Drawing.Size(1440, 610);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAngazovanja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOdaberi;
        private System.Windows.Forms.DataGridView dgvAngazovanja;
        private System.Windows.Forms.TextBox txtFilter;
    }
}
