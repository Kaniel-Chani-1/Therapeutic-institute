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
    public partial class FrmKidomotTable : Form
    {
        KidomotTable MyKidT = new KidomotTable();
        Kidomot MyKid1;
        public FrmKidomotTable()
        {
            InitializeComponent();
            dgvKidTable.DataSource = MyKidT.GetDataTable();
           dgvKidTable.Columns[0].HeaderText = "קידומת";
           
        }

        private void FrmKidomotTable_Load(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            grbAddUpdate.Visible = true;
            btnUpdate.Visible = false;
            btnAdd.Visible = true;

            txtKidName.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool degel = true;
            errorProvider1.Clear();
            // btnAdd.Visible = false;
            //  btnUpdate.Visible = true;


            try
            {
                MyKid1.Kid = txtKidName.Text;

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtKidName, ex.Message);
                degel = false;

            }

            if (degel)
            {
                try
                {
                    MyKid1.Update();
                    MessageBox.Show("הקידומת עודכנה בהצלחה");
                    grbAddUpdate.Visible = false;
                    btnNew.Visible = true;
                    btnDelete.Visible = true;
                }
                catch (Exception ex)
                {

                    errorProvider1.SetError(txtKidName, ex.Message);


                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool degel = true;
            MyKid1 = new Kidomot();
            try
            {
                MyKid1.Kid = txtKidName.Text;
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(txtKidName, ex.Message);
                degel = false;

            }
            if (degel)
            {
                try
                {
                    MyKid1.Add();
                    grbAddUpdate.Visible = false;
                }
                catch (Exception ex)
                {

                    errorProvider1.SetError(txtKidName, ex.Message);
                    MessageBox.Show("קידומת זו קימת במאגר");
                }

            }
        }

        private void dgvKidTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            grbAddUpdate.Visible = true;
            btnAdd.Visible = false;
            btnUpdate.Visible = true;

            MyKid1 = new Kidomot(Convert.ToString(dgvKidTable.SelectedRows[0].Cells[0].Value));

            txtKidName.Text = MyKid1.Kid;
        }

        private void txtKidName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           // MyKid1 = new Kidomot(Convert.ToString(dgvKidTable.SelectedRows[0].Cells[0].Value));
           // DataView dvEmployee = new DataView(new EmployessTable().GetDataTable());
           // DataView dvCust = new DataView(new CustomersTable().GetDataTable());
           // dvEmployee.RowFilter = "KidTelephone='" + MyKid1.Kid+ "' and KidPelephone='"+MyKid1.Kid+"'";
            //dvCust.RowFilter = "KidTelephone='" + MyKid1.Kid + "'and KidPelephoneEm='" + MyKid1.Kid + "'and KidPelephoneAv='" + MyKid1.Kid + "'"; 
           // if (dvEmployee.Count == 0 && dvCust.Count == 0)
           // {

                if (MessageBox.Show("האם אתה בטוח שברצונר למחוק את הקידומת", "מכון המפתח להתפתחות", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MyKid1.Delete();
                }



            //}
            //else
           // {
           //     MessageBox.Show("הקידומת מקושרת לטבלאות אחרות אין אפשרות מחיקה");
           // }
        }

        private void txtKidName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '\b' )
            {

            }
            else
                e.Handled = true;
        }
    }
}
