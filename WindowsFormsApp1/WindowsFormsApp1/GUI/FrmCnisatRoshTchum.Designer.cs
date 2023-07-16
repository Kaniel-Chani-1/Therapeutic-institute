namespace WindowsFormsApp1.GUI
{
    partial class FrmCnisatRoshTchum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCnisatRoshTchum));
            this.btnEshur = new System.Windows.Forms.Button();
            this.txtMisZehut = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEshur
            // 
            this.btnEshur.BackColor = System.Drawing.Color.Crimson;
            this.btnEshur.Location = new System.Drawing.Point(111, 103);
            this.btnEshur.Name = "btnEshur";
            this.btnEshur.Size = new System.Drawing.Size(159, 30);
            this.btnEshur.TabIndex = 4;
            this.btnEshur.Text = "אשור";
            this.btnEshur.UseVisualStyleBackColor = false;
            this.btnEshur.Click += new System.EventHandler(this.btnEshur_Click);
            // 
            // txtMisZehut
            // 
            this.txtMisZehut.Location = new System.Drawing.Point(100, 65);
            this.txtMisZehut.MaxLength = 9;
            this.txtMisZehut.Name = "txtMisZehut";
            this.txtMisZehut.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMisZehut.Size = new System.Drawing.Size(180, 20);
            this.txtMisZehut.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 84);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(118, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 40;
            this.label1.Text = "הכנס מספר זהות";
            // 
            // FrmCnisatRoshTchum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 166);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEshur);
            this.Controls.Add(this.txtMisZehut);
            this.Name = "FrmCnisatRoshTchum";
            this.Text = "מכון שלבים";
            this.Load += new System.EventHandler(this.FrmCnisatRoshTchum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEshur;
        private System.Windows.Forms.TextBox txtMisZehut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}