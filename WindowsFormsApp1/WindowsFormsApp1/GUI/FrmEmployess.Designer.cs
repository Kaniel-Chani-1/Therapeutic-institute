namespace WindowsFormsApp1.GUI
{
    partial class FrmEmployess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployess));
            this.combKidTelephone = new System.Windows.Forms.ComboBox();
            this.combCodeCity = new System.Windows.Forms.ComboBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtCtovet = new System.Windows.Forms.TextBox();
            this.txtShemPraty = new System.Windows.Forms.TextBox();
            this.txtShemMishpacha = new System.Windows.Forms.TextBox();
            this.txtTazOved = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCtovet = new System.Windows.Forms.Label();
            this.lblShemMishpacha = new System.Windows.Forms.Label();
            this.lblShemPrati = new System.Windows.Forms.Label();
            this.lblTazOved = new System.Windows.Forms.Label();
            this.numricuMisparCtovet = new System.Windows.Forms.NumericUpDown();
            this.dtpTaharichTchilatAvoda = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.chbPail = new System.Windows.Forms.CheckBox();
            this.combHekefMisra = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.combCodeHitmachut = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.combKidPelephone = new System.Windows.Forms.ComboBox();
            this.txtPelephone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.combTafkid = new System.Windows.Forms.ComboBox();
            this.grbEshi = new System.Windows.Forms.GroupBox();
            this.grbAvoda = new System.Windows.Forms.GroupBox();
            this.btnEshur = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numricuMisparCtovet)).BeginInit();
            this.grbEshi.SuspendLayout();
            this.grbAvoda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // combKidTelephone
            // 
            this.combKidTelephone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combKidTelephone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combKidTelephone.FormattingEnabled = true;
            this.combKidTelephone.Location = new System.Drawing.Point(28, 161);
            this.combKidTelephone.Name = "combKidTelephone";
            this.combKidTelephone.Size = new System.Drawing.Size(57, 21);
            this.combKidTelephone.TabIndex = 51;
            // 
            // combCodeCity
            // 
            this.combCodeCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combCodeCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combCodeCity.FormattingEnabled = true;
            this.combCodeCity.Location = new System.Drawing.Point(91, 135);
            this.combCodeCity.Name = "combCodeCity";
            this.combCodeCity.Size = new System.Drawing.Size(134, 21);
            this.combCodeCity.TabIndex = 49;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(96, 214);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(129, 20);
            this.txtMail.TabIndex = 44;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(96, 162);
            this.txtTelephone.MaxLength = 7;
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(129, 20);
            this.txtTelephone.TabIndex = 43;
            this.txtTelephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTazOved_KeyPress);
            // 
            // txtCtovet
            // 
            this.txtCtovet.Location = new System.Drawing.Point(96, 109);
            this.txtCtovet.Name = "txtCtovet";
            this.txtCtovet.Size = new System.Drawing.Size(129, 20);
            this.txtCtovet.TabIndex = 42;
            this.txtCtovet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShemPraty_KeyPress);
            // 
            // txtShemPraty
            // 
            this.txtShemPraty.Location = new System.Drawing.Point(96, 52);
            this.txtShemPraty.Name = "txtShemPraty";
            this.txtShemPraty.Size = new System.Drawing.Size(129, 20);
            this.txtShemPraty.TabIndex = 41;
            this.txtShemPraty.TextChanged += new System.EventHandler(this.txtShemPraty_TextChanged);
            this.txtShemPraty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShemPraty_KeyPress);
            // 
            // txtShemMishpacha
            // 
            this.txtShemMishpacha.Location = new System.Drawing.Point(96, 78);
            this.txtShemMishpacha.Name = "txtShemMishpacha";
            this.txtShemMishpacha.Size = new System.Drawing.Size(129, 20);
            this.txtShemMishpacha.TabIndex = 40;
            this.txtShemMishpacha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShemPraty_KeyPress);
            // 
            // txtTazOved
            // 
            this.txtTazOved.Location = new System.Drawing.Point(96, 23);
            this.txtTazOved.MaxLength = 9;
            this.txtTazOved.Name = "txtTazOved";
            this.txtTazOved.Size = new System.Drawing.Size(129, 20);
            this.txtTazOved.TabIndex = 39;
            this.txtTazOved.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTazOved_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(169, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "תפקיד ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(238, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "מייל";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(231, 138);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(25, 13);
            this.lblCity.TabIndex = 33;
            this.lblCity.Text = "עיר";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "טלפון ";
            // 
            // lblCtovet
            // 
            this.lblCtovet.AutoSize = true;
            this.lblCtovet.Location = new System.Drawing.Point(231, 109);
            this.lblCtovet.Name = "lblCtovet";
            this.lblCtovet.Size = new System.Drawing.Size(40, 13);
            this.lblCtovet.TabIndex = 31;
            this.lblCtovet.Text = "כתובת";
            // 
            // lblShemMishpacha
            // 
            this.lblShemMishpacha.AutoSize = true;
            this.lblShemMishpacha.Location = new System.Drawing.Point(231, 78);
            this.lblShemMishpacha.Name = "lblShemMishpacha";
            this.lblShemMishpacha.Size = new System.Drawing.Size(67, 13);
            this.lblShemMishpacha.TabIndex = 29;
            this.lblShemMishpacha.Text = "*שם משפחה";
            // 
            // lblShemPrati
            // 
            this.lblShemPrati.AutoSize = true;
            this.lblShemPrati.Location = new System.Drawing.Point(231, 52);
            this.lblShemPrati.Name = "lblShemPrati";
            this.lblShemPrati.Size = new System.Drawing.Size(55, 13);
            this.lblShemPrati.TabIndex = 28;
            this.lblShemPrati.Text = "*שם פרטי";
            // 
            // lblTazOved
            // 
            this.lblTazOved.AutoSize = true;
            this.lblTazOved.Location = new System.Drawing.Point(231, 26);
            this.lblTazOved.Name = "lblTazOved";
            this.lblTazOved.Size = new System.Drawing.Size(57, 13);
            this.lblTazOved.TabIndex = 27;
            this.lblTazOved.Text = "*ת\"ז עובד";
            // 
            // numricuMisparCtovet
            // 
            this.numricuMisparCtovet.Location = new System.Drawing.Point(37, 107);
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
            this.numricuMisparCtovet.TabIndex = 54;
            this.numricuMisparCtovet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numricuMisparCtovet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpTaharichTchilatAvoda
            // 
            this.dtpTaharichTchilatAvoda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTaharichTchilatAvoda.Location = new System.Drawing.Point(27, 128);
            this.dtpTaharichTchilatAvoda.Name = "dtpTaharichTchilatAvoda";
            this.dtpTaharichTchilatAvoda.Size = new System.Drawing.Size(136, 20);
            this.dtpTaharichTchilatAvoda.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "תאריך תחילת עבודה";
            // 
            // chbPail
            // 
            this.chbPail.AutoSize = true;
            this.chbPail.Location = new System.Drawing.Point(29, 163);
            this.chbPail.Name = "chbPail";
            this.chbPail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbPail.Size = new System.Drawing.Size(52, 17);
            this.chbPail.TabIndex = 57;
            this.chbPail.Text = "פעיל";
            this.chbPail.UseVisualStyleBackColor = true;
            // 
            // combHekefMisra
            // 
            this.combHekefMisra.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combHekefMisra.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combHekefMisra.FormattingEnabled = true;
            this.combHekefMisra.Items.AddRange(new object[] {
            "מישרה חלקית",
            "מישרה מלאה"});
            this.combHekefMisra.Location = new System.Drawing.Point(27, 94);
            this.combHekefMisra.Name = "combHekefMisra";
            this.combHekefMisra.Size = new System.Drawing.Size(136, 21);
            this.combHekefMisra.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(169, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 59;
            this.label10.Text = "הקף מישרה";
            // 
            // combCodeHitmachut
            // 
            this.combCodeHitmachut.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combCodeHitmachut.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combCodeHitmachut.FormattingEnabled = true;
            this.combCodeHitmachut.Location = new System.Drawing.Point(29, 31);
            this.combCodeHitmachut.Name = "combCodeHitmachut";
            this.combCodeHitmachut.Size = new System.Drawing.Size(134, 21);
            this.combCodeHitmachut.TabIndex = 60;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(169, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 61;
            this.label11.Text = "התמחות";
            // 
            // combKidPelephone
            // 
            this.combKidPelephone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combKidPelephone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combKidPelephone.FormattingEnabled = true;
            this.combKidPelephone.Location = new System.Drawing.Point(28, 187);
            this.combKidPelephone.Name = "combKidPelephone";
            this.combKidPelephone.Size = new System.Drawing.Size(57, 21);
            this.combKidPelephone.TabIndex = 63;
            // 
            // txtPelephone
            // 
            this.txtPelephone.Location = new System.Drawing.Point(96, 188);
            this.txtPelephone.MaxLength = 7;
            this.txtPelephone.Name = "txtPelephone";
            this.txtPelephone.Size = new System.Drawing.Size(129, 20);
            this.txtPelephone.TabIndex = 62;
            this.txtPelephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTazOved_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(231, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 64;
            this.label12.Text = "פלאפון ";
            // 
            // combTafkid
            // 
            this.combTafkid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combTafkid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combTafkid.FormattingEnabled = true;
            this.combTafkid.Items.AddRange(new object[] {
            "מטפלת",
            "מטפלת וראש סקטור"});
            this.combTafkid.Location = new System.Drawing.Point(27, 64);
            this.combTafkid.Name = "combTafkid";
            this.combTafkid.Size = new System.Drawing.Size(136, 21);
            this.combTafkid.TabIndex = 65;
            // 
            // grbEshi
            // 
            this.grbEshi.Controls.Add(this.lblTazOved);
            this.grbEshi.Controls.Add(this.lblShemPrati);
            this.grbEshi.Controls.Add(this.lblShemMishpacha);
            this.grbEshi.Controls.Add(this.combKidPelephone);
            this.grbEshi.Controls.Add(this.label12);
            this.grbEshi.Controls.Add(this.txtPelephone);
            this.grbEshi.Controls.Add(this.lblCtovet);
            this.grbEshi.Controls.Add(this.label6);
            this.grbEshi.Controls.Add(this.lblCity);
            this.grbEshi.Controls.Add(this.txtTazOved);
            this.grbEshi.Controls.Add(this.txtMail);
            this.grbEshi.Controls.Add(this.txtShemPraty);
            this.grbEshi.Controls.Add(this.txtShemMishpacha);
            this.grbEshi.Controls.Add(this.label8);
            this.grbEshi.Controls.Add(this.txtCtovet);
            this.grbEshi.Controls.Add(this.numricuMisparCtovet);
            this.grbEshi.Controls.Add(this.combKidTelephone);
            this.grbEshi.Controls.Add(this.combCodeCity);
            this.grbEshi.Controls.Add(this.txtTelephone);
            this.grbEshi.Location = new System.Drawing.Point(334, 65);
            this.grbEshi.Name = "grbEshi";
            this.grbEshi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grbEshi.Size = new System.Drawing.Size(306, 251);
            this.grbEshi.TabIndex = 66;
            this.grbEshi.TabStop = false;
            this.grbEshi.Text = "פרטים אישיים";
            // 
            // grbAvoda
            // 
            this.grbAvoda.Controls.Add(this.combCodeHitmachut);
            this.grbAvoda.Controls.Add(this.dtpTaharichTchilatAvoda);
            this.grbAvoda.Controls.Add(this.label11);
            this.grbAvoda.Controls.Add(this.label10);
            this.grbAvoda.Controls.Add(this.combTafkid);
            this.grbAvoda.Controls.Add(this.label4);
            this.grbAvoda.Controls.Add(this.chbPail);
            this.grbAvoda.Controls.Add(this.label9);
            this.grbAvoda.Controls.Add(this.combHekefMisra);
            this.grbAvoda.Location = new System.Drawing.Point(29, 65);
            this.grbAvoda.Name = "grbAvoda";
            this.grbAvoda.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grbAvoda.Size = new System.Drawing.Size(280, 195);
            this.grbAvoda.TabIndex = 67;
            this.grbAvoda.TabStop = false;
            this.grbAvoda.Text = "פרטים בעבודה";
            // 
            // btnEshur
            // 
            this.btnEshur.BackColor = System.Drawing.Color.Crimson;
            this.btnEshur.Location = new System.Drawing.Point(12, 336);
            this.btnEshur.Name = "btnEshur";
            this.btnEshur.Size = new System.Drawing.Size(124, 48);
            this.btnEshur.TabIndex = 68;
            this.btnEshur.Text = "אשור";
            this.btnEshur.UseVisualStyleBackColor = false;
            this.btnEshur.Click += new System.EventHandler(this.btnEshur_Click);
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
            this.label13.Location = new System.Drawing.Point(285, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(174, 39);
            this.label13.TabIndex = 69;
            this.label13.Text = "פרטי מטפל";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 84);
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // FrmEmployess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 396);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnEshur);
            this.Controls.Add(this.grbAvoda);
            this.Controls.Add(this.grbEshi);
            this.Name = "FrmEmployess";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "פרטי מטפל";
            this.Load += new System.EventHandler(this.FrmEmployess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numricuMisparCtovet)).EndInit();
            this.grbEshi.ResumeLayout(false);
            this.grbEshi.PerformLayout();
            this.grbAvoda.ResumeLayout(false);
            this.grbAvoda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox combKidTelephone;
        private System.Windows.Forms.ComboBox combCodeCity;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtCtovet;
        private System.Windows.Forms.TextBox txtShemPraty;
        private System.Windows.Forms.TextBox txtShemMishpacha;
        private System.Windows.Forms.TextBox txtTazOved;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCtovet;
        private System.Windows.Forms.Label lblShemMishpacha;
        private System.Windows.Forms.Label lblShemPrati;
        private System.Windows.Forms.Label lblTazOved;
        private System.Windows.Forms.NumericUpDown numricuMisparCtovet;
        private System.Windows.Forms.DateTimePicker dtpTaharichTchilatAvoda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chbPail;
        private System.Windows.Forms.ComboBox combHekefMisra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox combCodeHitmachut;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox combKidPelephone;
        private System.Windows.Forms.TextBox txtPelephone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox combTafkid;
        private System.Windows.Forms.GroupBox grbEshi;
        private System.Windows.Forms.GroupBox grbAvoda;
        private System.Windows.Forms.Button btnEshur;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}