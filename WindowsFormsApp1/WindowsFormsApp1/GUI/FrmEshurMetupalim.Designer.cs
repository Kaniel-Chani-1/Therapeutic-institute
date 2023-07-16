namespace WindowsFormsApp1.GUI
{
    partial class FrmEshurMetupalim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEshurMetupalim));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLeun = new System.Windows.Forms.Button();
            this.btnEshur = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(96, 72);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(355, 172);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnLeun
            // 
            this.btnLeun.BackColor = System.Drawing.Color.Crimson;
            this.btnLeun.Location = new System.Drawing.Point(24, 269);
            this.btnLeun.Name = "btnLeun";
            this.btnLeun.Size = new System.Drawing.Size(85, 54);
            this.btnLeun.TabIndex = 1;
            this.btnLeun.Text = "לעיון בהפניה";
            this.btnLeun.UseVisualStyleBackColor = false;
            this.btnLeun.Click += new System.EventHandler(this.btnLeun_Click);
            // 
            // btnEshur
            // 
            this.btnEshur.BackColor = System.Drawing.Color.Crimson;
            this.btnEshur.Location = new System.Drawing.Point(128, 269);
            this.btnEshur.Name = "btnEshur";
            this.btnEshur.Size = new System.Drawing.Size(85, 54);
            this.btnEshur.TabIndex = 2;
            this.btnEshur.Text = "לאשור  מטופל";
            this.btnEshur.UseVisualStyleBackColor = false;
            this.btnEshur.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 84);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.ForeColor = System.Drawing.Color.Crimson;
            this.label13.Location = new System.Drawing.Point(148, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(221, 39);
            this.label13.TabIndex = 36;
            this.label13.Text = "אשור מטופלים";
            // 
            // FrmEshurMetupalim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 347);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEshur);
            this.Controls.Add(this.btnLeun);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmEshurMetupalim";
            this.Text = "אשור מטופלים";
            this.Load += new System.EventHandler(this.FrmEshurMetupalim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLeun;
        private System.Windows.Forms.Button btnEshur;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
    }
}