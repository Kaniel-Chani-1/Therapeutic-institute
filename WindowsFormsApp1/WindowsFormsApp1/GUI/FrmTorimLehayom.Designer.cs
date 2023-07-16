namespace WindowsFormsApp1.GUI
{
    partial class FrmTorimLehayom
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
            this.dgvYomanTorimLehayom = new System.Windows.Forms.DataGridView();
            this.btnLedivuchTipul = new System.Windows.Forms.Button();
            this.btnZfia = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYomanTorimLehayom)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvYomanTorimLehayom
            // 
            this.dgvYomanTorimLehayom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYomanTorimLehayom.Location = new System.Drawing.Point(35, 156);
            this.dgvYomanTorimLehayom.MultiSelect = false;
            this.dgvYomanTorimLehayom.Name = "dgvYomanTorimLehayom";
            this.dgvYomanTorimLehayom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvYomanTorimLehayom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvYomanTorimLehayom.Size = new System.Drawing.Size(684, 257);
            this.dgvYomanTorimLehayom.TabIndex = 1;
            this.dgvYomanTorimLehayom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvYomanTorimLehayom_CellContentClick);
            // 
            // btnLedivuchTipul
            // 
            this.btnLedivuchTipul.BackColor = System.Drawing.Color.Crimson;
            this.btnLedivuchTipul.Location = new System.Drawing.Point(26, 82);
            this.btnLedivuchTipul.Name = "btnLedivuchTipul";
            this.btnLedivuchTipul.Size = new System.Drawing.Size(108, 47);
            this.btnLedivuchTipul.TabIndex = 2;
            this.btnLedivuchTipul.Text = "לדווח טיפול";
            this.btnLedivuchTipul.UseVisualStyleBackColor = false;
            this.btnLedivuchTipul.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnZfia
            // 
            this.btnZfia.BackColor = System.Drawing.Color.Crimson;
            this.btnZfia.Location = new System.Drawing.Point(140, 82);
            this.btnZfia.Name = "btnZfia";
            this.btnZfia.Size = new System.Drawing.Size(108, 47);
            this.btnZfia.TabIndex = 3;
            this.btnZfia.Text = "לצפיה על מהלך טיפול המטופל";
            this.btnZfia.UseVisualStyleBackColor = false;
            this.btnZfia.Click += new System.EventHandler(this.btnZfia_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.ForeColor = System.Drawing.Color.Crimson;
            this.label13.Location = new System.Drawing.Point(325, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(342, 39);
            this.label13.TabIndex = 39;
            this.label13.Text = "רשימת מטופלים להיום ";
            // 
            // FrmTorimLehayom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnZfia);
            this.Controls.Add(this.btnLedivuchTipul);
            this.Controls.Add(this.dgvYomanTorimLehayom);
            this.Name = "FrmTorimLehayom";
            this.Text = "כניסת מטפל";
            this.Load += new System.EventHandler(this.FrmTorimLehayom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYomanTorimLehayom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvYomanTorimLehayom;
        private System.Windows.Forms.Button btnLedivuchTipul;
        private System.Windows.Forms.Button btnZfia;
        private System.Windows.Forms.Label label13;
    }
}