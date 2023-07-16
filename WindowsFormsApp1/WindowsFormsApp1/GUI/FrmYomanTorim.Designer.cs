namespace WindowsFormsApp1.GUI
{
    partial class FrmYomanTorim
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
            this.dgvYomanTorim = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYomanTorim)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvYomanTorim
            // 
            this.dgvYomanTorim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYomanTorim.Location = new System.Drawing.Point(22, 21);
            this.dgvYomanTorim.MultiSelect = false;
            this.dgvYomanTorim.Name = "dgvYomanTorim";
            this.dgvYomanTorim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvYomanTorim.Size = new System.Drawing.Size(819, 297);
            this.dgvYomanTorim.TabIndex = 0;
            this.dgvYomanTorim.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvYomanTorim_CellContentClick);
            // 
            // FrmYomanTorim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 450);
            this.Controls.Add(this.dgvYomanTorim);
            this.Name = "FrmYomanTorim";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "FrmYomanTorim";
            this.Load += new System.EventHandler(this.FrmYomanTorim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYomanTorim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvYomanTorim;
    }
}