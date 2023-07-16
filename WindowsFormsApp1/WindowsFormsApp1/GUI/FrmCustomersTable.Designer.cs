namespace WindowsFormsApp1.GUI
{
    partial class FrmCustomersTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomersTable));
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtResearchName = new System.Windows.Forms.TextBox();
            this.txtResearchId = new System.Windows.Forms.TextBox();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBTelephone = new System.Windows.Forms.RadioButton();
            this.btnChipus = new System.Windows.Forms.Button();
            this.rbtnShem = new System.Windows.Forms.RadioButton();
            this.rbtnId = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Crimson;
            this.btnNew.Location = new System.Drawing.Point(875, 533);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(115, 39);
            this.btnNew.TabIndex = 23;
            this.btnNew.Text = "הוספת מטופל חדש";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Crimson;
            this.btnUpdate.Location = new System.Drawing.Point(875, 481);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 40);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "עדכן פרטי מטופל";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtResearchName
            // 
            this.txtResearchName.Location = new System.Drawing.Point(61, 66);
            this.txtResearchName.Name = "txtResearchName";
            this.txtResearchName.Size = new System.Drawing.Size(140, 20);
            this.txtResearchName.TabIndex = 21;
            this.txtResearchName.TextChanged += new System.EventHandler(this.txtResearchLastName_TextChanged);
            this.txtResearchName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResearchName_KeyPress);
            // 
            // txtResearchId
            // 
            this.txtResearchId.Location = new System.Drawing.Point(63, 32);
            this.txtResearchId.MaxLength = 9;
            this.txtResearchId.Name = "txtResearchId";
            this.txtResearchId.Size = new System.Drawing.Size(138, 20);
            this.txtResearchId.TabIndex = 18;
            this.txtResearchId.TextChanged += new System.EventHandler(this.txtResearchId_TextChanged);
            this.txtResearchId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResearchId_KeyPress);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(40, 72);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(765, 357);
            this.dgvCustomers.TabIndex = 12;
            this.dgvCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellContentClick);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(59, 98);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(140, 20);
            this.txtTel.TabIndex = 25;
            this.txtTel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBTelephone);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.btnChipus);
            this.groupBox1.Controls.Add(this.rbtnShem);
            this.groupBox1.Controls.Add(this.rbtnId);
            this.groupBox1.Controls.Add(this.txtResearchId);
            this.groupBox1.Controls.Add(this.txtResearchName);
            this.groupBox1.Location = new System.Drawing.Point(12, 435);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(354, 143);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "חיפוש";
            // 
            // radioBTelephone
            // 
            this.radioBTelephone.AutoSize = true;
            this.radioBTelephone.BackColor = System.Drawing.Color.LavenderBlush;
            this.radioBTelephone.Location = new System.Drawing.Point(205, 99);
            this.radioBTelephone.Name = "radioBTelephone";
            this.radioBTelephone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioBTelephone.Size = new System.Drawing.Size(109, 17);
            this.radioBTelephone.TabIndex = 5;
            this.radioBTelephone.TabStop = true;
            this.radioBTelephone.Text = "חפוש לפי טלפון";
            this.radioBTelephone.UseVisualStyleBackColor = false;
            this.radioBTelephone.CheckedChanged += new System.EventHandler(this.radioBTelephone_CheckedChanged);
            // 
            // btnChipus
            // 
            this.btnChipus.BackColor = System.Drawing.Color.Crimson;
            this.btnChipus.Enabled = false;
            this.btnChipus.Location = new System.Drawing.Point(6, 24);
            this.btnChipus.Name = "btnChipus";
            this.btnChipus.Size = new System.Drawing.Size(49, 28);
            this.btnChipus.TabIndex = 4;
            this.btnChipus.Text = "חפש";
            this.btnChipus.UseVisualStyleBackColor = false;
            this.btnChipus.Click += new System.EventHandler(this.btnChipus_Click);
            // 
            // rbtnShem
            // 
            this.rbtnShem.AutoSize = true;
            this.rbtnShem.BackColor = System.Drawing.Color.LavenderBlush;
            this.rbtnShem.Location = new System.Drawing.Point(217, 67);
            this.rbtnShem.Name = "rbtnShem";
            this.rbtnShem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtnShem.Size = new System.Drawing.Size(97, 17);
            this.rbtnShem.TabIndex = 1;
            this.rbtnShem.TabStop = true;
            this.rbtnShem.Text = "חפוש לפי שם ";
            this.rbtnShem.UseVisualStyleBackColor = false;
            this.rbtnShem.CheckedChanged += new System.EventHandler(this.rbtnShemMale_CheckedChanged);
            // 
            // rbtnId
            // 
            this.rbtnId.AutoSize = true;
            this.rbtnId.BackColor = System.Drawing.Color.LavenderBlush;
            this.rbtnId.Location = new System.Drawing.Point(219, 30);
            this.rbtnId.Name = "rbtnId";
            this.rbtnId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtnId.Size = new System.Drawing.Size(95, 17);
            this.rbtnId.TabIndex = 0;
            this.rbtnId.TabStop = true;
            this.rbtnId.Text = "חפוש לפי ת\"ז";
            this.rbtnId.UseVisualStyleBackColor = false;
            this.rbtnId.CheckedChanged += new System.EventHandler(this.rbtnId_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(760, 533);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 39);
            this.button1.TabIndex = 27;
            this.button1.Text = "לקביעת סדרת טיפולים";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(861, 113);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(118, 49);
            this.label1.TabIndex = 29;
            this.label1.Text = "רשימת המתנה \r\nלאשור";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(896, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 103);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(851, 165);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBox1.Size = new System.Drawing.Size(139, 264);
            this.listBox1.TabIndex = 32;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(316, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 39);
            this.label3.TabIndex = 33;
            this.label3.Text = "מאגר מטופלים";
            // 
            // FrmCustomersTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 590);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvCustomers);
            this.Name = "FrmCustomersTable";
            this.Text = "מטופלים";
            this.Load += new System.EventHandler(this.FrmCustomersTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtResearchName;
        private System.Windows.Forms.TextBox txtResearchId;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBTelephone;
        private System.Windows.Forms.Button btnChipus;
        private System.Windows.Forms.RadioButton rbtnShem;
        private System.Windows.Forms.RadioButton rbtnId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
    }
}