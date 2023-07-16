namespace WindowsFormsApp1.GUI
{
    partial class FrmCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomers));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTazLakoach = new System.Windows.Forms.TextBox();
            this.txtShemMishpacha = new System.Windows.Forms.TextBox();
            this.txtShemPraty = new System.Windows.Forms.TextBox();
            this.txtCtovet = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtShemEm = new System.Windows.Forms.TextBox();
            this.txtPelephoneEm = new System.Windows.Forms.TextBox();
            this.txtShemAv = new System.Windows.Forms.TextBox();
            this.txtPelephoneAv = new System.Windows.Forms.TextBox();
            this.combCodeCupatCholim = new System.Windows.Forms.ComboBox();
            this.combCodeCity = new System.Windows.Forms.ComboBox();
            this.dtpTaharichLeida = new System.Windows.Forms.DateTimePicker();
            this.combKidTelephone = new System.Windows.Forms.ComboBox();
            this.combKidPelephoneAv = new System.Windows.Forms.ComboBox();
            this.combKidPelephoneEm = new System.Windows.Forms.ComboBox();
            this.btnEshur = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.numricuMisparCtovet = new System.Windows.Forms.NumericUpDown();
            this.grbEm = new System.Windows.Forms.GroupBox();
            this.grbAv = new System.Windows.Forms.GroupBox();
            this.grbMetupal = new System.Windows.Forms.GroupBox();
            this.btnLekvihatSidratTipulim = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numricuMisparCtovet)).BeginInit();
            this.grbEm.SuspendLayout();
            this.grbAv.SuspendLayout();
            this.grbMetupal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(213, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "* ת\"ז מטופל";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(213, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "*שם פרטי";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(213, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "*שם משפחה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(213, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "*תאריך לידה";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "כתובת";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(213, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "*טלפון בית";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "עיר";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(211, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "שם אם";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(211, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "פלאפון אם";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(211, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "שם אב";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(211, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "פלאפון אב";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(213, 247);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "קופ\"ח \\בטוח";
            // 
            // txtTazLakoach
            // 
            this.txtTazLakoach.Location = new System.Drawing.Point(78, 23);
            this.txtTazLakoach.MaxLength = 9;
            this.txtTazLakoach.Name = "txtTazLakoach";
            this.txtTazLakoach.Size = new System.Drawing.Size(129, 20);
            this.txtTazLakoach.TabIndex = 12;
            this.txtTazLakoach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTazLakoach_KeyPress);
            // 
            // txtShemMishpacha
            // 
            this.txtShemMishpacha.Location = new System.Drawing.Point(78, 87);
            this.txtShemMishpacha.Name = "txtShemMishpacha";
            this.txtShemMishpacha.Size = new System.Drawing.Size(129, 20);
            this.txtShemMishpacha.TabIndex = 13;
            this.txtShemMishpacha.TextChanged += new System.EventHandler(this.txtShemMishpacha_TextChanged);
            this.txtShemMishpacha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShemMishpacha_KeyPress);
            // 
            // txtShemPraty
            // 
            this.txtShemPraty.Location = new System.Drawing.Point(78, 53);
            this.txtShemPraty.Name = "txtShemPraty";
            this.txtShemPraty.Size = new System.Drawing.Size(129, 20);
            this.txtShemPraty.TabIndex = 14;
            this.txtShemPraty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShemPraty_KeyPress);
            // 
            // txtCtovet
            // 
            this.txtCtovet.Location = new System.Drawing.Point(78, 148);
            this.txtCtovet.Name = "txtCtovet";
            this.txtCtovet.Size = new System.Drawing.Size(129, 20);
            this.txtCtovet.TabIndex = 15;
            this.txtCtovet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShemPraty_KeyPress);
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(78, 207);
            this.txtTelephone.MaxLength = 7;
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(129, 20);
            this.txtTelephone.TabIndex = 16;
            this.txtTelephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTazLakoach_KeyPress);
            // 
            // txtShemEm
            // 
            this.txtShemEm.Location = new System.Drawing.Point(76, 28);
            this.txtShemEm.Name = "txtShemEm";
            this.txtShemEm.Size = new System.Drawing.Size(129, 20);
            this.txtShemEm.TabIndex = 17;
            this.txtShemEm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShemMishpacha_KeyPress);
            // 
            // txtPelephoneEm
            // 
            this.txtPelephoneEm.Location = new System.Drawing.Point(76, 57);
            this.txtPelephoneEm.MaxLength = 7;
            this.txtPelephoneEm.Name = "txtPelephoneEm";
            this.txtPelephoneEm.Size = new System.Drawing.Size(129, 20);
            this.txtPelephoneEm.TabIndex = 18;
            this.txtPelephoneEm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTazLakoach_KeyPress);
            // 
            // txtShemAv
            // 
            this.txtShemAv.Location = new System.Drawing.Point(76, 32);
            this.txtShemAv.Name = "txtShemAv";
            this.txtShemAv.Size = new System.Drawing.Size(129, 20);
            this.txtShemAv.TabIndex = 19;
            this.txtShemAv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShemMishpacha_KeyPress);
            // 
            // txtPelephoneAv
            // 
            this.txtPelephoneAv.Location = new System.Drawing.Point(76, 58);
            this.txtPelephoneAv.MaxLength = 7;
            this.txtPelephoneAv.Name = "txtPelephoneAv";
            this.txtPelephoneAv.Size = new System.Drawing.Size(129, 20);
            this.txtPelephoneAv.TabIndex = 20;
            this.txtPelephoneAv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTazLakoach_KeyPress);
            // 
            // combCodeCupatCholim
            // 
            this.combCodeCupatCholim.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combCodeCupatCholim.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combCodeCupatCholim.FormattingEnabled = true;
            this.combCodeCupatCholim.Location = new System.Drawing.Point(73, 244);
            this.combCodeCupatCholim.Name = "combCodeCupatCholim";
            this.combCodeCupatCholim.Size = new System.Drawing.Size(134, 21);
            this.combCodeCupatCholim.TabIndex = 21;
            // 
            // combCodeCity
            // 
            this.combCodeCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combCodeCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combCodeCity.FormattingEnabled = true;
            this.combCodeCity.Location = new System.Drawing.Point(73, 176);
            this.combCodeCity.Name = "combCodeCity";
            this.combCodeCity.Size = new System.Drawing.Size(134, 21);
            this.combCodeCity.TabIndex = 22;
            // 
            // dtpTaharichLeida
            // 
            this.dtpTaharichLeida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTaharichLeida.Location = new System.Drawing.Point(79, 117);
            this.dtpTaharichLeida.Name = "dtpTaharichLeida";
            this.dtpTaharichLeida.Size = new System.Drawing.Size(128, 20);
            this.dtpTaharichLeida.TabIndex = 23;
            this.dtpTaharichLeida.ValueChanged += new System.EventHandler(this.dtpTaharichLeida_ValueChanged);
            // 
            // combKidTelephone
            // 
            this.combKidTelephone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combKidTelephone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combKidTelephone.FormattingEnabled = true;
            this.combKidTelephone.Location = new System.Drawing.Point(11, 207);
            this.combKidTelephone.Name = "combKidTelephone";
            this.combKidTelephone.Size = new System.Drawing.Size(57, 21);
            this.combKidTelephone.TabIndex = 24;
            // 
            // combKidPelephoneAv
            // 
            this.combKidPelephoneAv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combKidPelephoneAv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combKidPelephoneAv.FormattingEnabled = true;
            this.combKidPelephoneAv.Location = new System.Drawing.Point(13, 57);
            this.combKidPelephoneAv.Name = "combKidPelephoneAv";
            this.combKidPelephoneAv.Size = new System.Drawing.Size(57, 21);
            this.combKidPelephoneAv.TabIndex = 25;
            // 
            // combKidPelephoneEm
            // 
            this.combKidPelephoneEm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combKidPelephoneEm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combKidPelephoneEm.FormattingEnabled = true;
            this.combKidPelephoneEm.Location = new System.Drawing.Point(13, 55);
            this.combKidPelephoneEm.Name = "combKidPelephoneEm";
            this.combKidPelephoneEm.Size = new System.Drawing.Size(57, 21);
            this.combKidPelephoneEm.TabIndex = 26;
            // 
            // btnEshur
            // 
            this.btnEshur.BackColor = System.Drawing.Color.Crimson;
            this.btnEshur.Location = new System.Drawing.Point(12, 355);
            this.btnEshur.Name = "btnEshur";
            this.btnEshur.Size = new System.Drawing.Size(109, 44);
            this.btnEshur.TabIndex = 27;
            this.btnEshur.Text = "אשור";
            this.btnEshur.UseVisualStyleBackColor = false;
            this.btnEshur.Click += new System.EventHandler(this.btnEshur_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // numricuMisparCtovet
            // 
            this.numricuMisparCtovet.Location = new System.Drawing.Point(19, 149);
            this.numricuMisparCtovet.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numricuMisparCtovet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numricuMisparCtovet.Name = "numricuMisparCtovet";
            this.numricuMisparCtovet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numricuMisparCtovet.Size = new System.Drawing.Size(53, 20);
            this.numricuMisparCtovet.TabIndex = 28;
            this.numricuMisparCtovet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numricuMisparCtovet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grbEm
            // 
            this.grbEm.Controls.Add(this.txtShemEm);
            this.grbEm.Controls.Add(this.txtPelephoneEm);
            this.grbEm.Controls.Add(this.label8);
            this.grbEm.Controls.Add(this.combKidPelephoneEm);
            this.grbEm.Controls.Add(this.label9);
            this.grbEm.Location = new System.Drawing.Point(12, 65);
            this.grbEm.Name = "grbEm";
            this.grbEm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grbEm.Size = new System.Drawing.Size(281, 109);
            this.grbEm.TabIndex = 29;
            this.grbEm.TabStop = false;
            this.grbEm.Text = "פרטי אם";
            this.grbEm.Enter += new System.EventHandler(this.grbEm_Enter);
            // 
            // grbAv
            // 
            this.grbAv.Controls.Add(this.txtShemAv);
            this.grbAv.Controls.Add(this.label10);
            this.grbAv.Controls.Add(this.label11);
            this.grbAv.Controls.Add(this.txtPelephoneAv);
            this.grbAv.Controls.Add(this.combKidPelephoneAv);
            this.grbAv.Location = new System.Drawing.Point(12, 177);
            this.grbAv.Name = "grbAv";
            this.grbAv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grbAv.Size = new System.Drawing.Size(281, 109);
            this.grbAv.TabIndex = 30;
            this.grbAv.TabStop = false;
            this.grbAv.Text = "פרטי אב";
            // 
            // grbMetupal
            // 
            this.grbMetupal.Controls.Add(this.numricuMisparCtovet);
            this.grbMetupal.Controls.Add(this.combKidTelephone);
            this.grbMetupal.Controls.Add(this.dtpTaharichLeida);
            this.grbMetupal.Controls.Add(this.combCodeCity);
            this.grbMetupal.Controls.Add(this.combCodeCupatCholim);
            this.grbMetupal.Controls.Add(this.label12);
            this.grbMetupal.Controls.Add(this.txtTelephone);
            this.grbMetupal.Controls.Add(this.txtCtovet);
            this.grbMetupal.Controls.Add(this.txtShemPraty);
            this.grbMetupal.Controls.Add(this.txtShemMishpacha);
            this.grbMetupal.Controls.Add(this.txtTazLakoach);
            this.grbMetupal.Controls.Add(this.label7);
            this.grbMetupal.Controls.Add(this.label6);
            this.grbMetupal.Controls.Add(this.label5);
            this.grbMetupal.Controls.Add(this.label4);
            this.grbMetupal.Controls.Add(this.label3);
            this.grbMetupal.Controls.Add(this.label2);
            this.grbMetupal.Controls.Add(this.label1);
            this.grbMetupal.Location = new System.Drawing.Point(312, 51);
            this.grbMetupal.Name = "grbMetupal";
            this.grbMetupal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grbMetupal.Size = new System.Drawing.Size(322, 285);
            this.grbMetupal.TabIndex = 31;
            this.grbMetupal.TabStop = false;
            this.grbMetupal.Text = "פרטי מטופל";
            // 
            // btnLekvihatSidratTipulim
            // 
            this.btnLekvihatSidratTipulim.BackColor = System.Drawing.Color.Crimson;
            this.btnLekvihatSidratTipulim.Enabled = false;
            this.btnLekvihatSidratTipulim.Location = new System.Drawing.Point(539, 352);
            this.btnLekvihatSidratTipulim.Name = "btnLekvihatSidratTipulim";
            this.btnLekvihatSidratTipulim.Size = new System.Drawing.Size(115, 51);
            this.btnLekvihatSidratTipulim.TabIndex = 32;
            this.btnLekvihatSidratTipulim.Text = "לקבלת מטופל";
            this.btnLekvihatSidratTipulim.UseVisualStyleBackColor = false;
            this.btnLekvihatSidratTipulim.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(4, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 84);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.ForeColor = System.Drawing.Color.Crimson;
            this.label13.Location = new System.Drawing.Point(248, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(185, 39);
            this.label13.TabIndex = 34;
            this.label13.Text = "פרטי מטופל";
            // 
            // FrmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 411);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLekvihatSidratTipulim);
            this.Controls.Add(this.grbMetupal);
            this.Controls.Add(this.grbAv);
            this.Controls.Add(this.grbEm);
            this.Controls.Add(this.btnEshur);
            this.Name = "FrmCustomers";
            this.Text = "פרטי מטופל";
            this.Load += new System.EventHandler(this.FrmCustomers_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmCustomers_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numricuMisparCtovet)).EndInit();
            this.grbEm.ResumeLayout(false);
            this.grbEm.PerformLayout();
            this.grbAv.ResumeLayout(false);
            this.grbAv.PerformLayout();
            this.grbMetupal.ResumeLayout(false);
            this.grbMetupal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTazLakoach;
        private System.Windows.Forms.TextBox txtShemMishpacha;
        private System.Windows.Forms.TextBox txtShemPraty;
        private System.Windows.Forms.TextBox txtCtovet;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtShemEm;
        private System.Windows.Forms.TextBox txtPelephoneEm;
        private System.Windows.Forms.TextBox txtShemAv;
        private System.Windows.Forms.TextBox txtPelephoneAv;
        private System.Windows.Forms.ComboBox combCodeCupatCholim;
        private System.Windows.Forms.ComboBox combCodeCity;
        private System.Windows.Forms.DateTimePicker dtpTaharichLeida;
        private System.Windows.Forms.ComboBox combKidTelephone;
        private System.Windows.Forms.ComboBox combKidPelephoneAv;
        private System.Windows.Forms.ComboBox combKidPelephoneEm;
        private System.Windows.Forms.Button btnEshur;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown numricuMisparCtovet;
        private System.Windows.Forms.GroupBox grbMetupal;
        private System.Windows.Forms.GroupBox grbAv;
        private System.Windows.Forms.GroupBox grbEm;
        private System.Windows.Forms.Button btnLekvihatSidratTipulim;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
    }
}