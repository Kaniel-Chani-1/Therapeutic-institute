namespace WindowsFormsApp1.GUI
{
    partial class FrmKidomotTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKidomotTable));
            this.grbAddUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtKidName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dgvKidTable = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbAddUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKidTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbAddUpdate
            // 
            this.grbAddUpdate.Controls.Add(this.btnUpdate);
            this.grbAddUpdate.Controls.Add(this.btnAdd);
            this.grbAddUpdate.Controls.Add(this.txtKidName);
            this.grbAddUpdate.Controls.Add(this.label2);
            this.grbAddUpdate.Location = new System.Drawing.Point(205, 116);
            this.grbAddUpdate.Name = "grbAddUpdate";
            this.grbAddUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grbAddUpdate.Size = new System.Drawing.Size(238, 215);
            this.grbAddUpdate.TabIndex = 17;
            this.grbAddUpdate.TabStop = false;
            this.grbAddUpdate.Text = "קידומות";
            this.grbAddUpdate.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Crimson;
            this.btnUpdate.Location = new System.Drawing.Point(24, 140);
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
            this.btnAdd.Location = new System.Drawing.Point(120, 138);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 26);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "הוספה";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtKidName
            // 
            this.txtKidName.Location = new System.Drawing.Point(103, 79);
            this.txtKidName.MaxLength = 3;
            this.txtKidName.Name = "txtKidName";
            this.txtKidName.Size = new System.Drawing.Size(94, 20);
            this.txtKidName.TabIndex = 7;
            this.txtKidName.TextChanged += new System.EventHandler(this.txtKidName_TextChanged);
            this.txtKidName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKidName_KeyPress);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(117, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "*קוד קידומת";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.Location = new System.Drawing.Point(315, 81);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 28);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "מחק";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Crimson;
            this.btnNew.Location = new System.Drawing.Point(205, 81);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(97, 28);
            this.btnNew.TabIndex = 15;
            this.btnNew.Text = "חדש";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dgvKidTable
            // 
            this.dgvKidTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKidTable.Location = new System.Drawing.Point(51, 92);
            this.dgvKidTable.MultiSelect = false;
            this.dgvKidTable.Name = "dgvKidTable";
            this.dgvKidTable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvKidTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKidTable.Size = new System.Drawing.Size(114, 209);
            this.dgvKidTable.TabIndex = 14;
            this.dgvKidTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKidTable_CellDoubleClick);
            this.dgvKidTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKidTable_CellDoubleClick);
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
            this.label13.Location = new System.Drawing.Point(156, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(214, 39);
            this.label13.TabIndex = 37;
            this.label13.Text = "מאגר קידומות";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 84);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // FrmKidomotTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 357);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.grbAddUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvKidTable);
            this.Name = "FrmKidomotTable";
            this.Text = "קידומות";
            this.Load += new System.EventHandler(this.FrmKidomotTable_Load);
            this.grbAddUpdate.ResumeLayout(false);
            this.grbAddUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKidTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAddUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtKidName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dgvKidTable;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}