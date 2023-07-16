namespace WindowsFormsApp1.GUI
{
    partial class FrmCnisatMetapel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCnisatMetapel));
            this.txtMisZehut = new System.Windows.Forms.TextBox();
            this.btnEshur = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMisZehut
            // 
            this.txtMisZehut.Location = new System.Drawing.Point(77, 73);
            this.txtMisZehut.MaxLength = 9;
            this.txtMisZehut.Name = "txtMisZehut";
            this.txtMisZehut.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMisZehut.Size = new System.Drawing.Size(198, 20);
            this.txtMisZehut.TabIndex = 0;
            this.txtMisZehut.TextAlignChanged += new System.EventHandler(this.txtMisZehut_TextAlignChanged);
            this.txtMisZehut.MultilineChanged += new System.EventHandler(this.txtMisZehut_TextChanged);
            this.txtMisZehut.TextChanged += new System.EventHandler(this.txtMisZehut_TextChanged);
            this.txtMisZehut.MouseHover += new System.EventHandler(this.txtMisZehut_TextChanged);
            // 
            // btnEshur
            // 
            this.btnEshur.BackColor = System.Drawing.Color.Crimson;
            this.btnEshur.Location = new System.Drawing.Point(98, 110);
            this.btnEshur.Name = "btnEshur";
            this.btnEshur.Size = new System.Drawing.Size(159, 30);
            this.btnEshur.TabIndex = 1;
            this.btnEshur.Text = "אשור";
            this.btnEshur.UseVisualStyleBackColor = false;
            this.btnEshur.Click += new System.EventHandler(this.btnEshur_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(116, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "הכנס מספר זהות";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 84);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCnisatMetapel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 183);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEshur);
            this.Controls.Add(this.txtMisZehut);
            this.Name = "FrmCnisatMetapel";
            this.Text = "מכון שלבים";
            this.Load += new System.EventHandler(this.FrmCnisatMetapel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMisZehut;
        private System.Windows.Forms.Button btnEshur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}