namespace WindowsFormsApp1.GUI
{
    partial class FrmEmployessTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployessTable));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChipus = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.rbtnLastName = new System.Windows.Forms.RadioButton();
            this.rbtnId = new System.Windows.Forms.RadioButton();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.btnNewOved = new System.Windows.Forms.Button();
            this.btnUpdateOved = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChipus);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.rbtnLastName);
            this.groupBox1.Controls.Add(this.rbtnId);
            this.groupBox1.Location = new System.Drawing.Point(587, 426);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(266, 103);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "חיפוש";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnChipus
            // 
            this.btnChipus.BackColor = System.Drawing.Color.Crimson;
            this.btnChipus.Enabled = false;
            this.btnChipus.Location = new System.Drawing.Point(11, 24);
            this.btnChipus.Name = "btnChipus";
            this.btnChipus.Size = new System.Drawing.Size(49, 28);
            this.btnChipus.TabIndex = 4;
            this.btnChipus.Text = "חפש";
            this.btnChipus.UseVisualStyleBackColor = false;
            this.btnChipus.Click += new System.EventHandler(this.btnChipus_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(67, 63);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(95, 20);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(66, 29);
            this.txtId.MaxLength = 9;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(96, 20);
            this.txtId.TabIndex = 2;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // rbtnLastName
            // 
            this.rbtnLastName.AutoSize = true;
            this.rbtnLastName.Location = new System.Drawing.Point(160, 66);
            this.rbtnLastName.Name = "rbtnLastName";
            this.rbtnLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtnLastName.Size = new System.Drawing.Size(97, 17);
            this.rbtnLastName.TabIndex = 1;
            this.rbtnLastName.TabStop = true;
            this.rbtnLastName.Text = "חפוש לפי שם ";
            this.rbtnLastName.UseVisualStyleBackColor = true;
            this.rbtnLastName.CheckedChanged += new System.EventHandler(this.rbtnLastName_CheckedChanged);
            // 
            // rbtnId
            // 
            this.rbtnId.AutoSize = true;
            this.rbtnId.Location = new System.Drawing.Point(162, 29);
            this.rbtnId.Name = "rbtnId";
            this.rbtnId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtnId.Size = new System.Drawing.Size(95, 17);
            this.rbtnId.TabIndex = 0;
            this.rbtnId.TabStop = true;
            this.rbtnId.Text = "חפוש לפי ת\"ז";
            this.rbtnId.UseVisualStyleBackColor = true;
            this.rbtnId.CheckedChanged += new System.EventHandler(this.rbtnId_CheckedChanged);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(15, 88);
            this.dgvEmployees.MultiSelect = false;
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(852, 317);
            this.dgvEmployees.TabIndex = 2;
            this.dgvEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtEmployees_CellContentClick);
            // 
            // btnNewOved
            // 
            this.btnNewOved.BackColor = System.Drawing.Color.Crimson;
            this.btnNewOved.Location = new System.Drawing.Point(21, 426);
            this.btnNewOved.Name = "btnNewOved";
            this.btnNewOved.Size = new System.Drawing.Size(109, 43);
            this.btnNewOved.TabIndex = 4;
            this.btnNewOved.Text = "מטפל חדש";
            this.btnNewOved.UseVisualStyleBackColor = false;
            this.btnNewOved.Click += new System.EventHandler(this.btnNewOved_Click);
            // 
            // btnUpdateOved
            // 
            this.btnUpdateOved.BackColor = System.Drawing.Color.Crimson;
            this.btnUpdateOved.Location = new System.Drawing.Point(21, 477);
            this.btnUpdateOved.Name = "btnUpdateOved";
            this.btnUpdateOved.Size = new System.Drawing.Size(109, 43);
            this.btnUpdateOved.TabIndex = 5;
            this.btnUpdateOved.Text = "עדכן פרטי מטפל";
            this.btnUpdateOved.UseVisualStyleBackColor = false;
            this.btnUpdateOved.Click += new System.EventHandler(this.btnUpdateOved_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.ForeColor = System.Drawing.Color.Crimson;
            this.label13.Location = new System.Drawing.Point(330, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(212, 39);
            this.label13.TabIndex = 35;
            this.label13.Text = "מאגר מטפלים";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 84);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // FrmEmployessTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 541);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnUpdateOved);
            this.Controls.Add(this.btnNewOved);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvEmployees);
            this.Name = "FrmEmployessTable";
            this.Text = "מטפלים";
            this.Load += new System.EventHandler(this.FrmEmployessTable_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChipus;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.RadioButton rbtnLastName;
        private System.Windows.Forms.RadioButton rbtnId;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button btnNewOved;
        private System.Windows.Forms.Button btnUpdateOved;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}