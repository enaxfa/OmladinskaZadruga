using System.Windows.Forms;

namespace Client.UserControls.Posao
{
    partial class UCChangePosao
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
            this.txtFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoslovi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 83;
            this.label1.Text = "Pretraži poslove";
            // 
            // dgvPoslovi
            // 
            this.dgvPoslovi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPoslovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoslovi.Location = new System.Drawing.Point(47, 174);
            this.dgvPoslovi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPoslovi.Name = "dgvPoslovi";
            this.dgvPoslovi.ReadOnly = true;
            this.dgvPoslovi.RowHeadersWidth = 51;
            this.dgvPoslovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPoslovi.Size = new System.Drawing.Size(894, 241);
            this.dgvPoslovi.TabIndex = 80;
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFilter.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.txtFilter.Location = new System.Drawing.Point(47, 120);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(247, 24);
            this.txtFilter.TabIndex = 79;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // UCChangePosao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPoslovi);
            this.Controls.Add(this.txtFilter);
            this.Name = "UCChangePosao";
            this.Size = new System.Drawing.Size(1065, 550);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoslovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DataGridView DgvOmladinci { get => dgvPoslovi; set => dgvPoslovi = value; }
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPoslovi;
        private System.Windows.Forms.TextBox txtFilter;
    }
}
