namespace WindowsFormsApp1.GUI
{
    partial class FrmSidratTipulim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSidratTipulim));
            this.dgtSidratTipulim = new System.Windows.Forms.DataGridView();
            this.btnMetupalLoPail = new System.Windows.Forms.Button();
            this.btnEshurMetupalim = new System.Windows.Forms.Button();
            this.btnLeun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNameMetapel = new System.Windows.Forms.Label();
            this.lblMisTipulim = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNameMetupal = new System.Windows.Forms.Label();
            this.lblTchumTipul = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHosafatTipulim = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgtSidratTipulim)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgtSidratTipulim
            // 
            this.dgtSidratTipulim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtSidratTipulim.Location = new System.Drawing.Point(219, 56);
            this.dgtSidratTipulim.MultiSelect = false;
            this.dgtSidratTipulim.Name = "dgtSidratTipulim";
            this.dgtSidratTipulim.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgtSidratTipulim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgtSidratTipulim.Size = new System.Drawing.Size(500, 298);
            this.dgtSidratTipulim.TabIndex = 0;
            this.dgtSidratTipulim.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnMetupalLoPail
            // 
            this.btnMetupalLoPail.BackColor = System.Drawing.Color.Crimson;
            this.btnMetupalLoPail.Location = new System.Drawing.Point(15, 381);
            this.btnMetupalLoPail.Name = "btnMetupalLoPail";
            this.btnMetupalLoPail.Size = new System.Drawing.Size(97, 60);
            this.btnMetupalLoPail.TabIndex = 1;
            this.btnMetupalLoPail.Text = "קבלות לא פעילות";
            this.btnMetupalLoPail.UseVisualStyleBackColor = false;
            this.btnMetupalLoPail.Click += new System.EventHandler(this.btnMetupalLoPail_Click);
            // 
            // btnEshurMetupalim
            // 
            this.btnEshurMetupalim.BackColor = System.Drawing.Color.Crimson;
            this.btnEshurMetupalim.Location = new System.Drawing.Point(115, 382);
            this.btnEshurMetupalim.Name = "btnEshurMetupalim";
            this.btnEshurMetupalim.Size = new System.Drawing.Size(97, 60);
            this.btnEshurMetupalim.TabIndex = 2;
            this.btnEshurMetupalim.Text = "אשור מטופלים";
            this.btnEshurMetupalim.UseVisualStyleBackColor = false;
            this.btnEshurMetupalim.Click += new System.EventHandler(this.btnEshurMetupalim_Click);
            // 
            // btnLeun
            // 
            this.btnLeun.BackColor = System.Drawing.Color.Crimson;
            this.btnLeun.Location = new System.Drawing.Point(623, 382);
            this.btnLeun.Name = "btnLeun";
            this.btnLeun.Size = new System.Drawing.Size(78, 41);
            this.btnLeun.TabIndex = 5;
            this.btnLeun.Text = "עיין";
            this.btnLeun.UseVisualStyleBackColor = false;
            this.btnLeun.Click += new System.EventHandler(this.btnLeun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(410, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lblNameMetapel);
            this.groupBox1.Controls.Add(this.lblMisTipulim);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblNameMetupal);
            this.groupBox1.Controls.Add(this.lblTchumTipul);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(29, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 265);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "הוספת טיפולים לסדרה קימת";
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(33, 197);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(107, 20);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "מספר טיפולים להוספה";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(9, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 26);
            this.button1.TabIndex = 11;
            this.button1.Text = "אשור";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNameMetapel
            // 
            this.lblNameMetapel.AutoSize = true;
            this.lblNameMetapel.Enabled = false;
            this.lblNameMetapel.Location = new System.Drawing.Point(3, 107);
            this.lblNameMetapel.Name = "lblNameMetapel";
            this.lblNameMetapel.Size = new System.Drawing.Size(59, 13);
            this.lblNameMetapel.TabIndex = 10;
            this.lblNameMetapel.Text = "שם מטופל";
            // 
            // lblMisTipulim
            // 
            this.lblMisTipulim.AutoSize = true;
            this.lblMisTipulim.Enabled = false;
            this.lblMisTipulim.Location = new System.Drawing.Point(6, 138);
            this.lblMisTipulim.Name = "lblMisTipulim";
            this.lblMisTipulim.Size = new System.Drawing.Size(59, 13);
            this.lblMisTipulim.TabIndex = 9;
            this.lblMisTipulim.Text = "שם מטופל";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(68, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "מספר טיפולים בסדרה";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Location = new System.Drawing.Point(68, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "שם מטפל";
            // 
            // lblNameMetupal
            // 
            this.lblNameMetupal.AutoSize = true;
            this.lblNameMetupal.Enabled = false;
            this.lblNameMetupal.Location = new System.Drawing.Point(3, 37);
            this.lblNameMetupal.Name = "lblNameMetupal";
            this.lblNameMetupal.Size = new System.Drawing.Size(59, 13);
            this.lblNameMetupal.TabIndex = 6;
            this.lblNameMetupal.Text = "שם מטופל";
            // 
            // lblTchumTipul
            // 
            this.lblTchumTipul.AutoSize = true;
            this.lblTchumTipul.Enabled = false;
            this.lblTchumTipul.Location = new System.Drawing.Point(3, 72);
            this.lblTchumTipul.Name = "lblTchumTipul";
            this.lblTchumTipul.Size = new System.Drawing.Size(59, 13);
            this.lblTchumTipul.TabIndex = 5;
            this.lblTchumTipul.Text = "שם מטופל";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(68, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "תחום טיפול";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(68, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "שם מטופל";
            // 
            // btnHosafatTipulim
            // 
            this.btnHosafatTipulim.BackColor = System.Drawing.Color.Crimson;
            this.btnHosafatTipulim.Location = new System.Drawing.Point(15, 346);
            this.btnHosafatTipulim.Name = "btnHosafatTipulim";
            this.btnHosafatTipulim.Size = new System.Drawing.Size(197, 30);
            this.btnHosafatTipulim.TabIndex = 9;
            this.btnHosafatTipulim.Text = "הוספת טיפולים למטופל";
            this.btnHosafatTipulim.UseVisualStyleBackColor = false;
            this.btnHosafatTipulim.Click += new System.EventHandler(this.btnHosafatTipulim_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 78);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // FrmSidratTipulim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 454);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnHosafatTipulim);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLeun);
            this.Controls.Add(this.btnEshurMetupalim);
            this.Controls.Add(this.btnMetupalLoPail);
            this.Controls.Add(this.dgtSidratTipulim);
            this.Name = "FrmSidratTipulim";
            this.Text = "כניסת ראש תחום";
            this.Load += new System.EventHandler(this.FrmSidratTipulim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtSidratTipulim)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgtSidratTipulim;
        private System.Windows.Forms.Button btnMetupalLoPail;
        private System.Windows.Forms.Button btnEshurMetupalim;
        private System.Windows.Forms.Button btnLeun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNameMetapel;
        private System.Windows.Forms.Label lblMisTipulim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNameMetupal;
        private System.Windows.Forms.Label lblTchumTipul;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHosafatTipulim;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}