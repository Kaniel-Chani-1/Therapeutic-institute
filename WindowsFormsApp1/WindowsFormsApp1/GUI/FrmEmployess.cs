using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;

namespace WindowsFormsApp1.GUI
{
    public partial class FrmEmployess : Form
    {
        EmployessTable MyEmployessT = new EmployessTable();
        Employess MyEmployess1;
        string frmState;
        public void MiluyCombs()
        {
            combCodeCity.DataSource = new CityTable().GetDataTable();
            combCodeCity.DisplayMember = "ShemCity";
            combCodeCity.ValueMember = "CodeCity";
            combKidPelephone.DataSource = new KidomotTable().GetKidomot1();
            combKidPelephone.DisplayMember = "Kid";
            combKidPelephone.ValueMember = "Kid";
            combKidTelephone.DataSource = new KidomotTable().GetKidomot2();
            combKidTelephone.DisplayMember = "Kid";
            combKidTelephone.ValueMember = "Kid";
            combCodeHitmachut.DataSource = new HitmachuiotTable().GetDataTable();
            combCodeHitmachut.DisplayMember = "ShemHitmachut";
            combCodeHitmachut.ValueMember = "CodeHitmachut";
            dtpTaharichTchilatAvoda.MinDate = DateTime.Today;
        }
        public FrmEmployess()
        {
            InitializeComponent();
            frmState = "NEW";
            MiluyCombs();
            MyEmployess1 = new Employess();
        }
        public FrmEmployess(Employess ee)
        {
            InitializeComponent();
            frmState = "UPDATE";
            MiluyCombs();
            MyEmployess1 = ee;
            txtTazOved.Text = MyEmployess1.TazOved;
            txtShemPraty.Text = MyEmployess1.ShemPraty;
            txtShemMishpacha.Text = MyEmployess1.ShemMishpacha;
            txtCtovet.Text = MyEmployess1.Ctovet;
            numricuMisparCtovet.Value = MyEmployess1.MisparCtovet;
            combCodeCity.SelectedValue = MyEmployess1.CodeCity;
            combKidTelephone.SelectedValue = MyEmployess1.KidTelephone;
            txtTelephone.Text = MyEmployess1.Telephone;
            combKidPelephone.SelectedValue = MyEmployess1.KidPelephone;
            txtPelephone.Text = MyEmployess1.Pelephone;
            txtMail.Text = MyEmployess1.Mail;
            combHekefMisra.Text = MyEmployess1.HekefMisra;
            dtpTaharichTchilatAvoda.Value = MyEmployess1.TaharichTchilatAvoda;
            combCodeHitmachut.SelectedValue = MyEmployess1.CodeHitmachut;
            combTafkid.Text = MyEmployess1.Tafkid;
            chbPail.Checked = MyEmployess1.Pail;
        }

        private void FrmEmployess_Load(object sender, EventArgs e)
        {

        }

        private void btnEshur_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool degel = true;
            try
            {
                MyEmployess1.TazOved = txtTazOved.Text;
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(txtTazOved, ex.Message);
                degel = false;
            }


            try
            {
                MyEmployess1.ShemPraty = txtShemPraty.Text;
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(txtShemPraty, ex.Message);
                degel = false;
            }
            try
            {
                MyEmployess1.ShemMishpacha = txtShemMishpacha.Text;
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(txtShemMishpacha, ex.Message);
                degel = false;
            }
            try
            {
                MyEmployess1.Ctovet = txtCtovet.Text;
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(txtCtovet, ex.Message);
                degel = false;
            }
           
                MyEmployess1.MisparCtovet =Convert.ToInt32 (numricuMisparCtovet.Value);
           
          
                MyEmployess1.CodeCity = Convert.ToInt32(combCodeCity.SelectedValue);
            
          
                MyEmployess1.KidTelephone = Convert.ToString(combKidTelephone.SelectedValue);
           
           
            try
            {
                MyEmployess1.Telephone = txtTelephone.Text;
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(txtTelephone, ex.Message);
                degel = false;
            }
            
                MyEmployess1.KidPelephone = Convert.ToString(combKidPelephone.SelectedValue);
           
            try
            {
                MyEmployess1.Pelephone = txtPelephone.Text;
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(txtPelephone, ex.Message);
                degel = false;
            }
            try
            {
                MyEmployess1.Mail = txtMail.Text;
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(txtMail, ex.Message);
                degel = false;
            }
           
                MyEmployess1.HekefMisra = combHekefMisra.Text;
           
            try
            {
                MyEmployess1.TaharichTchilatAvoda = Convert.ToDateTime(dtpTaharichTchilatAvoda.Text);
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(dtpTaharichTchilatAvoda, ex.Message);
                degel = false;
            }
          
                MyEmployess1.CodeHitmachut = Convert.ToInt32(combCodeHitmachut.SelectedValue);
            
            
                MyEmployess1.Tafkid = Convert.ToString(combTafkid.Text);
            MyEmployess1.Pail = chbPail.Checked;
           

            if (degel)
            {
                if (frmState == "NEW")
                {
                    try
                    {
                        MyEmployess1.Add();
                        MessageBox.Show("העובד נוסף בהצלחה");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("יש תקלה בהוספה" + ex.Message);

                    }
                }
                if (frmState == "UPDATE")
                    try
                    {
                        MyEmployess1.Update();
                        MessageBox.Show("העובד עודכן בהצלחה");

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("יש תקלה בעדכון" + ex.Message);
                    }
            }
        }

        private void txtTazOved_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '\b' )
            {

            }
            else
                e.Handled = true;
        }

        private void txtShemPraty_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtShemPraty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == ' ' || e.KeyChar == '-')
            {

            }
            else
                e.Handled = true;
        }
    }
}
