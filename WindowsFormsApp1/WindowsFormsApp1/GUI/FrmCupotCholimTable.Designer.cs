namespace WindowsFormsApp1.GUI
{
    partial class FrmCupotCholimTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCupotCholimTable));
            this.grbAddUpdate = new System.Windows.Forms.GroupBox();
            this.lblCodeCupa = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtShemCupa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dgvCupotCholimTable = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbAddUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCupotCholimTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbAddUpdate
            // 
            this.grbAddUpdate.Controls.Add(this.lblCodeCupa);
            this.grbAddUpdate.Controls.Add(this.btnUpdate);
            this.grbAddUpdate.Controls.Add(this.btnAdd);
            this.grbAddUpdate.Controls.Add(this.txtShemCupa);
            this.grbAddUpdate.Controls.Add(this.label2);
            this.grbAddUpdate.Controls.Add(this.label1);
            this.grbAddUpdate.Location = new System.Drawing.Point(342, 153);
            this.grbAddUpdate.Name = "grbAddUpdate";
            this.grbAddUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grbAddUpdate.Size = new System.Drawing.Size(238, 215);
            this.grbAddUpdate.TabIndex = 17;
            this.grbAddUpdate.TabStop = false;
            this.grbAddUpdate.Text = "קופות חולים";
            this.grbAddUpdate.Visible = false;
            // 
            // lblCodeCupa
            // 
            this.lblCodeCupa.Enabled = false;
            this.lblCodeCupa.Location = new System.Drawing.Point(86, 63);
            this.lblCodeCupa.Name = "lblCodeCupa";
            this.lblCodeCupa.Size = new System.Drawing.Size(68, 17);
            this.lblCodeCupa.TabIndex = 8;
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
            // txtShemCupa
            // 
            this.txtShemCupa.Location = new System.Drawing.Point(61, 97);
            this.txtShemCupa.Name = "txtShemCupa";
            this.txtShemCupa.Size = new System.Drawing.Size(94, 20);
            this.txtShemCupa.TabIndex = 7;
            this.txtShemCupa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShemCupa_KeyPress);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(161, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "שם קופה";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(161, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "קוד קופה";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.Location = new System.Drawing.Point(462, 107);
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
            this.btnNew.Location = new System.Drawing.Point(342, 107);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(97, 28);
            this.btnNew.TabIndex = 15;
            this.btnNew.Text = "חדש";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dgvCupotCholimTable
            // 
            this.dgvCupotCholimTable.AllowUserToAddRows = false;
            this.dgvCupotCholimTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCupotCholimTable.Location = new System.Drawing.Point(43, 153);
            this.dgvCupotCholimTable.MultiSelect = false;
            this.dgvCupotCholimTable.Name = "dgvCupotCholimTable";
            this.dgvCupotCholimTable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvCupotCholimTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCupotCholimTable.Size = new System.Drawing.Size(279, 209);
            this.dgvCupotCholimTable.TabIndex = 14;
            this.dgvCupotCholimTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCupotCholimTable_CellContentClick);
            this.dgvCupotCholimTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCupotCholimTable_CellDoubleClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(182, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 39);
            this.label3.TabIndex = 29;
            this.label3.Text = "מאגר קופות חולים";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 84);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCupotCholimTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 428);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grbAddUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvCupotCholimTable);
            this.Name = "FrmCupotCholimTable";
            this.Text = " קופות חולים";
            this.Load += new System.EventHandler(this.FrmCupotCholimTable_Load);
            this.grbAddUpdate.ResumeLayout(false);
            this.grbAddUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCupotCholimTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAddUpdate;
        private System.Windows.Forms.Label lblCodeCupa;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtShemCupa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dgvCupotCholimTable;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}