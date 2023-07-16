namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.btnCnisatMazcira = new System.Windows.Forms.Button();
            this.btnRoshTchum = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(39, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "כניסת מטפל";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCnisatMazcira
            // 
            this.btnCnisatMazcira.BackColor = System.Drawing.Color.Crimson;
            this.btnCnisatMazcira.Location = new System.Drawing.Point(39, 260);
            this.btnCnisatMazcira.Name = "btnCnisatMazcira";
            this.btnCnisatMazcira.Size = new System.Drawing.Size(128, 38);
            this.btnCnisatMazcira.TabIndex = 2;
            this.btnCnisatMazcira.Text = "כניסת מזכירה";
            this.btnCnisatMazcira.UseVisualStyleBackColor = false;
            this.btnCnisatMazcira.Click += new System.EventHandler(this.btnCnisatMazcira_Click);
            // 
            // btnRoshTchum
            // 
            this.btnRoshTchum.BackColor = System.Drawing.Color.Crimson;
            this.btnRoshTchum.Location = new System.Drawing.Point(39, 386);
            this.btnRoshTchum.Name = "btnRoshTchum";
            this.btnRoshTchum.Size = new System.Drawing.Size(128, 38);
            this.btnRoshTchum.TabIndex = 3;
            this.btnRoshTchum.Text = "כניסת ראש תחום";
            this.btnRoshTchum.UseVisualStyleBackColor = false;
            this.btnRoshTchum.Click += new System.EventHandler(this.btnRoshTchum_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(241, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 369);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(607, 57);
            this.label1.TabIndex = 28;
            this.label1.Text = "ברוכים הבאים למערכת מכון שלבים ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRoshTchum);
            this.Controls.Add(this.btnCnisatMazcira);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "מכון להתפתחות הילד מכון שלבים";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCnisatMazcira;
        private System.Windows.Forms.Button btnRoshTchum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

