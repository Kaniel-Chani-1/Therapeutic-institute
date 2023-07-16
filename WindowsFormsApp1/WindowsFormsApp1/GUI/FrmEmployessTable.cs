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
    public partial class FrmEmployessTable : Form
    {
        Employess MyEmployess;
        EmployessTable MyEmployessT = new EmployessTable();
        DataView dv;
        public FrmEmployessTable()
        {
            InitializeComponent();
            dv = new DataView(MyEmployessT.GetNiceEmployeeTable());
            dgvEmployees.DataSource = dv;
            dgvEmployees.Columns[0].HeaderText = "תעודת זהות עובד";
            dgvEmployees.Columns[1].HeaderText = "שם מלא";
            dgvEmployees.Columns[2].HeaderText = "כתובת";
            dgvEmployees.Columns[3].HeaderText = "עיר";
            dgvEmployees.Columns[4].HeaderText = "טלפון";
            dgvEmployees.Columns[5].HeaderText = "פלאפון";
            dgvEmployees.Columns[6].HeaderText = "כתובת מיל";
            dgvEmployees.Columns[7].HeaderText = "הקף מישרה";
            dgvEmployees.Columns[8].HeaderText = "תאריך תחילת עבודה";
            dgvEmployees.Columns[9].HeaderText = "התמחות";
            dgvEmployees.Columns[10].HeaderText = "תפקיד";
            dgvEmployees.Columns[11].HeaderText = "פעיל";
        }

        private void dgtEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmEmployessTable_Load(object sender, EventArgs e)
        {

        }

        private void btnChipus_Click(object sender, EventArgs e)
        {
            dv.RowFilter = "TazOved='" + txtId.Text + "'";
        }

        private void btnNewOved_Click(object sender, EventArgs e)
        {
            FrmEmployess ff = new FrmEmployess();
            ff.ShowDialog();
            dv = new DataView(MyEmployessT.GetNiceEmployeeTable());
            dgvEmployees.DataSource = dv;

        }

        private void btnUpdateOved_Click(object sender, EventArgs e)
        {
            Employess ee = new Employess(Convert.ToString(dgvEmployees.SelectedRows[0].Cells[0].Value));
            FrmEmployess ff = new FrmEmployess(ee);
            ff.ShowDialog();
            dv = new DataView(MyEmployessT.GetNiceEmployeeTable());
            dgvEmployees.DataSource = dv;
        }

        private void rbtnId_CheckedChanged(object sender, EventArgs e)
        {
            btnChipus.Enabled = true;
            txtId.Text = "";
            txtId.Enabled = true;
            txtLastName.Enabled = false;
            dv.RowFilter = "";
        }

        private void rbtnLastName_CheckedChanged(object sender, EventArgs e)
        {
           
            btnChipus.Enabled = false;
            txtLastName.Text = "";
            txtId.Enabled = false;
            txtLastName.Enabled = true;

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = "shemMale like'" + txtLastName.Text + "*'";
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '\b' )
            {

            }
            else
                e.Handled = true;
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == ' ' || e.KeyChar == '-')
            {

            }
            else
                e.Handled = true;
        }
    }
}
