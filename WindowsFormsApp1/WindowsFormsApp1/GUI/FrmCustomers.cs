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
    public partial class FrmCustomers : Form
    {
        CustomersTable MyCustomersT = new CustomersTable();
        Customers MyCustomers1;
        string frmState;
        DataView dvKabala1;
        DataView dvKabala2;
        DataView dvKabala3;
        DataView dvKabala4;
        public void MiluyCombs()
        {
            combCodeCity.DataSource = new CityTable().GetDataTable();
            combCodeCity.DisplayMember = "ShemCity";
            combCodeCity.ValueMember = "CodeCity";
            combCodeCupatCholim.DataSource = new CupotCholimTable().GetDataTable();
            combCodeCupatCholim.DisplayMember = "ShemCupatCholim";
            combCodeCupatCholim.ValueMember = "CodeCupatCholim";
            combKidPelephoneAv.DataSource = new KidomotTable().GetKidomot1();
            combKidPelephoneAv.DisplayMember = "Kid";
            combKidPelephoneAv.ValueMember = "Kid";
            combKidPelephoneEm.DataSource = new KidomotTable().GetKidomot2();
            combKidPelephoneEm.DisplayMember = "Kid";
            combKidPelephoneEm.ValueMember = "Kid";
            combKidTelephone.DataSource = new KidomotTable().GetDataTable();
            combKidTelephone.DisplayMember = "Kid";
            combKidTelephone.ValueMember = "Kid";



        }
        public FrmCustomers()
        {
            InitializeComponent();
            frmState = "NEW";
            MiluyCombs();
            MyCustomers1 = new Customers();
            DateTime dd = DateTime.Today.AddYears(-9);
            dtpTaharichLeida.MaxDate = DateTime.Today;
            dtpTaharichLeida.MinDate = dd;
            dtpTaharichLeida.Value = dd;
        }
        public FrmCustomers(Customers cc)
        {
            InitializeComponent();
            frmState = "UPDATE";
            MiluyCombs();
            MyCustomers1 = cc;
            txtTazLakoach.Text = MyCustomers1.TazLakoach;
            txtShemPraty.Text = MyCustomers1.ShemPraty;
            txtShemMishpacha.Text = MyCustomers1.ShemMishpacha;
           // dtpTaharichLeida.MinDate = DateTime.Today.AddMonths(-1);
            //dtpTaharichLeida.MaxDate = DateTime.Today.AddYears(-9);
            dtpTaharichLeida.Value = MyCustomers1.TaharichLeida;
            txtCtovet.Text = MyCustomers1.Ctovet;
            numricuMisparCtovet.Value = MyCustomers1.MisparCtovet;
            combCodeCity.SelectedValue = MyCustomers1.CodeCity;
            combKidTelephone.SelectedValue = MyCustomers1.KidTelephone;
            txtTelephone.Text = MyCustomers1.Telephone;
            txtShemEm.Text = MyCustomers1.ShemEm;
            combKidPelephoneEm.SelectedValue = MyCustomers1.KidPelephoneEm;
            txtPelephoneEm.Text = MyCustomers1.PelephoneEm;
            txtShemAv.Text = MyCustomers1.ShemAv;
            combKidPelephoneAv.SelectedValue = MyCustomers1.KidPelephoneAv;
            txtPelephoneAv.Text = MyCustomers1.PelephoneAv;
            combCodeCupatCholim.SelectedValue = MyCustomers1.CodeCupatCholim;
          
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

       private void FrmCustomers_Load(object sender, EventArgs e)
       {
           
           
       }

        private void btnEshur_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool degel = true;
            try
            {
                MyCustomers1.TazLakoach = txtTazLakoach.Text;
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(txtTazLakoach, ex.Message);
                degel = false;
            }


            try
            {
                MyCustomers1.ShemPraty = txtShemPraty.Text;
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(txtShemPraty, ex.Message);
                degel = false;
            }
            try
            {
                MyCustomers1.ShemMishpacha = txtShemMishpacha.Text;
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(txtShemMishpacha, ex.Message);
                degel = false;
            }
            try
            {
                MyCustomers1.TaharichLeida = Convert.ToDateTime(dtpTaharichLeida.Text);
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(dtpTaharichLeida, ex.Message);
                degel = false;
            }
            try
            {
                MyCustomers1.Ctovet = txtCtovet.Text;
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(txtCtovet, ex.Message);
                degel = false;
            }
            
                MyCustomers1.MisparCtovet = Convert.ToInt32(numricuMisparCtovet.Value);
           
            
                MyCustomers1.CodeCity = Convert.ToInt32(combCodeCity.SelectedValue);
          
           
                MyCustomers1.KidTelephone = Convert.ToString(combKidTelephone.SelectedValue);
           
            try
            {
                MyCustomers1.Telephone = txtTelephone.Text;
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(txtTelephone, ex.Message);
                degel = false;
            }
          
                MyCustomers1.KidPelephoneAv = Convert.ToString(combKidPelephoneAv.SelectedValue);
           
            try
            {
                MyCustomers1.PelephoneAv = txtPelephoneAv.Text;
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(txtPelephoneAv, ex.Message);
                degel = false;
            }
            
                MyCustomers1.KidPelephoneEm = Convert.ToString(combKidPelephoneEm.SelectedValue);
           
            try
            {
                MyCustomers1.PelephoneEm = txtPelephoneEm.Text;
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(txtPelephoneEm, ex.Message);
                degel = false;
            }
            try
            {
                MyCustomers1.ShemAv = txtShemAv.Text;
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(txtShemAv, ex.Message);
                degel = false;
            }
            try
            {
                MyCustomers1.ShemEm = txtShemEm.Text;
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(txtShemEm, ex.Message);
                degel = false;
            }
          
                MyCustomers1.CodeCupatCholim = Convert.ToInt32(combCodeCupatCholim.SelectedValue);
           

            if (degel)
            {
                if (frmState == "NEW")
                {
                    try
                    {
                        MyCustomers1.Add();
                        MessageBox.Show("המטופל נוסף בהצלחה");
                        btnLekvihatSidratTipulim.Enabled = true;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("יש תקלה בהוספה" + ex.Message);

                    }
                }
                if (frmState == "UPDATE")
                    try
                    {
                        MyCustomers1.Update();
                        MessageBox.Show("המטופל עודכן בהצלחה");
                        btnLekvihatSidratTipulim.Enabled = true;

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("יש תקלה בעדכון" + ex.Message);
                    }
            }
        }

        private void grbEm_Enter(object sender, EventArgs e)
        {

        }

       private void button1_Click(object sender, EventArgs e)
        {

            DateTime dd = DateTime.Today.AddDays(-14);
            Customers cc = new Customers(txtTazLakoach.Text);
            dvKabala1 = new DataView(new KabalatLakoachTable().GetDataTable());
            dvKabala1.RowFilter = "TazLakoach='" + cc.TazLakoach + "' and Status=true";
            dvKabala2 = new DataView(new KabalatLakoachTable().GetDataTable());
            dvKabala2.RowFilter = "TazLakoach='" + cc.TazLakoach + "' and Status=false and TaharichKabala<'" + dd + "'";
            dvKabala3 = new DataView(new KabalatLakoachTable().GetDataTable());
            dvKabala3.RowFilter = "TazLakoach='" + cc.TazLakoach + "' and Status=false and TaharichKabala>'" + dd + "'";
            dvKabala4 = new DataView(new KabalatLakoachTable().GetDataTable());
            dvKabala4.RowFilter = "TazLakoach='" + cc.TazLakoach + "'";
            if (dvKabala1.Count > 0)
            {
                FrmSidratTipulimVekvihatam ff = new FrmSidratTipulimVekvihatam(cc, "UPDATE");
                ff.Show();
            }
            if (dvKabala2.Count > 0)
            {
                MessageBox.Show("יש לחכות לאשור טיפול");

            }
            if (dvKabala3.Count > 0)
            {
                FrmSidratTipulimVekvihatam ff = new FrmSidratTipulimVekvihatam(cc, "NEW");
                ff.Show();

            }
            if (dvKabala4.Count == 0)
            {
                FrmSidratTipulimVekvihatam ff = new FrmSidratTipulimVekvihatam(cc, "NEW");
                ff.Show();

            }

        }

        private void dtpTaharichLeida_ValueChanged(object sender, EventArgs e)
        { DateTime dd = DateTime.Today.AddYears(-9);
            dtpTaharichLeida.MaxDate = DateTime.Today.AddMonths(-1);
            
             }
        private void txtShemPraty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == ' ' || e.KeyChar == '-')
            {

            }
            else
                e.Handled = true;
        }

        private void FrmCustomers_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtShemMishpacha_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtShemMishpacha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == ' ' || e.KeyChar == '-')
            {

            }
            else
                e.Handled = true;
        }

        private void txtTazLakoach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {

            }
            else
                e.Handled = true;
        }
    }
}
