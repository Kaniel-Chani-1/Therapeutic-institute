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
    public partial class FrmHitmachuiotTable : Form
    {
        HitmachuiotTable MyHitmachuiotT = new HitmachuiotTable();
        Hitmachuiot MyHitmachuiot1;
        public FrmHitmachuiotTable()
        {
            InitializeComponent();
            dgvHitmachuiotTable.DataSource = MyHitmachuiotT.GetDataTable();
            dgvHitmachuiotTable.Columns[0].HeaderText = "קוד התמחות";
            dgvHitmachuiotTable.Columns[1].HeaderText = "שם התמחות";
            dgvHitmachuiotTable.Columns[2].HeaderText = "תעריף לשעה";
            dgvHitmachuiotTable.Columns[2].DefaultCellStyle.Format = "C2";
        }

        private void grbAddUpdate_Enter(object sender, EventArgs e)
        {

        }

        private void FrmHitmachuiotTable_Load(object sender, EventArgs e)
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
                MyHitmachuiot1.ShemHitmachut = txtShemHitmachut.Text;

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtShemHitmachut, ex.Message);
                degel = false;

            }

            if (degel)
            {
                try
                {
                    MyHitmachuiot1.Update();
                    MessageBox.Show(" ההתמחות עודכנה בהצלחה");
                    grbAddUpdate.Visible = false;
                    //  btnNew.Visible = true;
                    // btnDelete.Visible = true;
                }
                catch (Exception ex)
                {

                    errorProvider1.SetError(txtShemHitmachut, ex.Message);


                }

            }
        }

        private void dgvHitmachuiotTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            grbAddUpdate.Visible = true;
            btnAdd.Visible = false;
            btnUpdate.Visible = true;
            MyHitmachuiot1 = new Hitmachuiot(Convert.ToInt32(dgvHitmachuiotTable.SelectedRows[0].Cells[0].Value));
            lblCodeHitmachut.Text = MyHitmachuiot1.CodeHitmachut.ToString();
            txtShemHitmachut.Text = MyHitmachuiot1.ShemHitmachut;
            numericUpDTarif.Value = MyHitmachuiot1.Tarif;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            grbAddUpdate.Visible = true;
            btnUpdate.Visible = false;
            btnAdd.Visible = true;
            lblCodeHitmachut.Text = MyHitmachuiotT.GetNewKey().ToString();
            txtShemHitmachut.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool degel = true;
            MyHitmachuiot1 = new Hitmachuiot();

            MyHitmachuiot1.CodeHitmachut = Convert.ToInt32(lblCodeHitmachut.Text);
            MyHitmachuiot1.Tarif = Convert.ToInt32(numericUpDTarif.Value);
            try
            {
                MyHitmachuiot1.ShemHitmachut = txtShemHitmachut.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtShemHitmachut, ex.Message);
                degel = false;

            }
            if (degel)
            {
                try
                {
                    MyHitmachuiot1.Add();
                    grbAddUpdate.Visible = false;
                }
                catch (Exception ex)
                {
                    errorProvider1.SetError(txtShemHitmachut, ex.Message);
                    MessageBox.Show("התמחות זו קימת במאגר");


                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MyHitmachuiot1 = new Hitmachuiot(Convert.ToInt32(dgvHitmachuiotTable.SelectedRows[0].Cells[0].Value));
            DataView dvEmployee = new DataView(new EmployessTable().GetDataTable());
            DataView dvSidratTipulim = new DataView(new SidratTipulimTable().GetDataTable());
            dvSidratTipulim.RowFilter = "CodeHitmachut=" + MyHitmachuiot1.CodeHitmachut;
            dvEmployee.RowFilter = "CodeHitmachut=" + MyHitmachuiot1.CodeHitmachut;
            if (dvEmployee.Count == 0 && dvSidratTipulim.Count == 0)
            {

                if (MessageBox.Show("האם אתה בטוח שברצונר למחוק את ההתמחות", "מכון המפתח להתפתחות", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MyHitmachuiot1.Delete();
                }



            }
            else
            {
                MessageBox.Show("ההתמחות מקושרת לטבלאות אחרות אין אפשרות מחיקה");
            }
        }

        private void dgvHitmachuiotTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtShemHitmachut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == ' ' || e.KeyChar == '-')
            {

            }
            else
                e.Handled = true;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
