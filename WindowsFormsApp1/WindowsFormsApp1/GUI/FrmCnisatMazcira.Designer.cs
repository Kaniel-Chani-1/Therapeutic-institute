namespace WindowsFormsApp1.GUI
{
    partial class FrmCnisatMazcira
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCnisatMazcira));
            this.label1 = new System.Windows.Forms.Label();
            this.btnEshur = new System.Windows.Forms.Button();
            this.txtMisSisma = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(108, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "הכנס סיסמה";
            // 
            // btnEshur
            // 
            this.btnEshur.BackColor = System.Drawing.Color.Crimson;
            this.btnEshur.Location = new System.Drawing.Point(93, 122);
            this.btnEshur.Name = "btnEshur";
            this.btnEshur.Size = new System.Drawing.Size(122, 30);
            this.btnEshur.TabIndex = 4;
            this.btnEshur.Text = "אשור";
            this.btnEshur.UseVisualStyleBackColor = false;
            this.btnEshur.Click += new System.EventHandler(this.btnEshur_Click);
            // 
            // txtMisSisma
            // 
            this.txtMisSisma.Location = new System.Drawing.Point(80, 80);
            this.txtMisSisma.MaxLength = 4;
            this.txtMisSisma.Name = "txtMisSisma";
            this.txtMisSisma.PasswordChar = '#';
            this.txtMisSisma.Size = new System.Drawing.Size(153, 20);
            this.txtMisSisma.TabIndex = 3;
            this.txtMisSisma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMisSisma_KeyPress);
            this.txtMisSisma.MouseLeave += new System.EventHandler(this.txtMisSisma_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 84);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCnisatMazcira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 202);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEshur);
            this.Controls.Add(this.txtMisSisma);
            this.Name = "FrmCnisatMazcira";
            this.Text = "מכון שלבים";
            this.Load += new System.EventHandler(this.FrmCnisatMazcira_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEshur;
        private System.Windows.Forms.TextBox txtMisSisma;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}