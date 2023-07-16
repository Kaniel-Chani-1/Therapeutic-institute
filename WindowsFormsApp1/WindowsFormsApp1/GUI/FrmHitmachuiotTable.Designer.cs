namespace WindowsFormsApp1.GUI
{
    partial class FrmHitmachuiotTable
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHitmachuiotTable));
            this.grbAddUpdate = new System.Windows.Forms.GroupBox();
            this.numericUpDTarif = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCodeHitmachut = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtShemHitmachut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dgvHitmachuiotTable = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbAddUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDTarif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHitmachuiotTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbAddUpdate
            // 
            this.grbAddUpdate.Controls.Add(this.numericUpDTarif);
            this.grbAddUpdate.Controls.Add(this.label3);
            this.grbAddUpdate.Controls.Add(this.lblCodeHitmachut);
            this.grbAddUpdate.Controls.Add(this.btnUpdate);
            this.grbAddUpdate.Controls.Add(this.btnAdd);
            this.grbAddUpdate.Controls.Add(this.txtShemHitmachut);
            this.grbAddUpdate.Controls.Add(this.label2);
            this.grbAddUpdate.Controls.Add(this.label1);
            this.grbAddUpdate.Location = new System.Drawing.Point(361, 106);
            this.grbAddUpdate.Name = "grbAddUpdate";
            this.grbAddUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grbAddUpdate.Size = new System.Drawing.Size(238, 215);
            this.grbAddUpdate.TabIndex = 21;
            this.grbAddUpdate.TabStop = false;
            this.grbAddUpdate.Text = "התמחויות";
            this.grbAddUpdate.Visible = false;
            this.grbAddUpdate.Enter += new System.EventHandler(this.grbAddUpdate_Enter);
            // 
            // numericUpDTarif
            // 
            this.numericUpDTarif.Location = new System.Drawing.Point(86, 125);
            this.numericUpDTarif.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDTarif.Minimum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericUpDTarif.Name = "numericUpDTarif";
            this.numericUpDTarif.Size = new System.Drawing.Size(62, 20);
            this.numericUpDTarif.TabIndex = 10;
            this.numericUpDTarif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDTarif.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(137, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "*תעריף לשעה בש\"ח";
            // 
            // lblCodeHitmachut
            // 
            this.lblCodeHitmachut.Enabled = false;
            this.lblCodeHitmachut.Location = new System.Drawing.Point(86, 63);
            this.lblCodeHitmachut.Name = "lblCodeHitmachut";
            this.lblCodeHitmachut.Size = new System.Drawing.Size(68, 17);
            this.lblCodeHitmachut.TabIndex = 8;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Crimson;
            this.btnUpdate.Location = new System.Drawing.Point(24, 165);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 24);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "עדכון";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Crimson;
            this.btnAdd.Location = new System.Drawing.Point(120, 165);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 26);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "הוספה";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtShemHitmachut
            // 
            this.txtShemHitmachut.Location = new System.Drawing.Point(61, 87);
            this.txtShemHitmachut.Name = "txtShemHitmachut";
            this.txtShemHitmachut.Size = new System.Drawing.Size(94, 20);
            this.txtShemHitmachut.TabIndex = 7;
            this.txtShemHitmachut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShemHitmachut_KeyPress);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(161, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "*שם התמחות";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(155, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "קוד התמחות";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.Location = new System.Drawing.Point(488, 72);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 28);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "מחק";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Crimson;
            this.btnNew.Location = new System.Drawing.Point(378, 72);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(97, 28);
            this.btnNew.TabIndex = 19;
            this.btnNew.Text = "חדש";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dgvHitmachuiotTable
            // 
            this.dgvHitmachuiotTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHitmachuiotTable.Location = new System.Drawing.Point(12, 106);
            this.dgvHitmachuiotTable.MultiSelect = false;
            this.dgvHitmachuiotTable.Name = "dgvHitmachuiotTable";
            this.dgvHitmachuiotTable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvHitmachuiotTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHitmachuiotTable.Size = new System.Drawing.Size(338, 209);
            this.dgvHitmachuiotTable.TabIndex = 18;
            this.dgvHitmachuiotTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHitmachuiotTable_CellContentClick);
            this.dgvHitmachuiotTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHitmachuiotTable_CellDoubleClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.ForeColor = System.Drawing.Color.Crimson;
            this.label13.Location = new System.Drawing.Point(171, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(275, 39);
            this.label13.TabIndex = 36;
            this.label13.Text = "מאגר תחומי טיפול";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 84);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // FrmHitmachuiotTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 367);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.grbAddUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvHitmachuiotTable);
            this.Name = "FrmHitmachuiotTable";
            this.Text = "התמחויות";
            this.Load += new System.EventHandler(this.FrmHitmachuiotTable_Load);
            this.grbAddUpdate.ResumeLayout(false);
            this.grbAddUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDTarif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHitmachuiotTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAddUpdate;
        private System.Windows.Forms.Label lblCodeHitmachut;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtShemHitmachut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dgvHitmachuiotTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown numericUpDTarif;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}