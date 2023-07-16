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
    public partial class FrmCityTable : Form
    {
        CityTable MyCityT = new CityTable();
        City MyCity1;
        public FrmCityTable()
        {
            InitializeComponent();
            dgvCityTable.DataSource = MyCityT.GetDataTable();
            dgvCityTable.Columns[0].HeaderText = "קוד עיר";
            dgvCityTable.Columns[1].HeaderText = "שם עיר";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmCityTable_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool degel = true;
            errorProvider1.Clear();
           // btnAdd.Visible = false;
          //  btnUpdate.Visible = true;

            try
            {
                MyCity1.ShemCity = txtShemCity.Text;

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtShemCity, ex.Message);
                degel = false;

            }

            if (degel)
            {
                try
                {
                    MyCity1.Update();
                    MessageBox.Show("העיר עודכנה בהצלחה");
                    grbAddUpdate.Visible = false;
                  //  btnNew.Visible = true;
                   // btnDelete.Visible = true;
                }
                catch (Exception ex)
                {

                    errorProvider1.SetError(txtShemCity, ex.Message);


                }

            }

        }

        private void dgvCityTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            grbAddUpdate.Visible = true;
            btnAdd.Visible = false;
            btnUpdate.Visible = true;

            MyCity1 = new City(Convert.ToInt32(dgvCityTable.SelectedRows[0].Cells[0].Value));
            lblCodeCity.Text = MyCity1.CodeCity.ToString();
            txtShemCity.Text = MyCity1.ShemCity;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            grbAddUpdate.Visible = true;
            btnUpdate.Visible = false;
            btnAdd.Visible = true;
            lblCodeCity.Text = MyCityT.GetNewKey().ToString();
           txtShemCity.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool degel = true;
           MyCity1 = new City();

            MyCity1.CodeCity = Convert.ToInt32(lblCodeCity.Text);
            try
            {
                MyCity1.ShemCity = txtShemCity.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtShemCity, ex.Message);
                degel = false;

            }
            if (degel)
            {
                try
                {
                    MyCity1.Add();
                    grbAddUpdate.Visible = false;
                }
                catch (Exception ex)
                {
                    errorProvider1.SetError(txtShemCity, ex.Message);
                    MessageBox.Show("עיר זו קימת במאגר");


                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MyCity1 = new City(Convert.ToInt32(dgvCityTable.SelectedRows[0].Cells[0].Value));
            DataView dvEmployee = new DataView(new EmployessTable().GetDataTable());
            DataView dvCust = new DataView(new CustomersTable().GetDataTable());
            dvCust.RowFilter = "CodeCity=" + MyCity1.CodeCity;
            dvEmployee.RowFilter = "CodeCity=" + MyCity1.CodeCity;
            if (dvEmployee.Count==0&&dvCust.Count==0)
            {

                if (MessageBox.Show("האם אתה בטוח שברצונך למחוק את העיר","מכון שלבים",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
 MyCity1.Delete();
                }
               


            }
            else
            {
                MessageBox.Show("העיר מקושרת לטבלאות אחרות אין אפשרות מחיקה");
            }
        }

        private void txtShemCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == ' ' || e.KeyChar == '-')
            {

            }
            else
                e.Handled = true;
        }

      private void txtShemCity_TextChanged(object sender, EventArgs e)
     {

       }
    }
}
