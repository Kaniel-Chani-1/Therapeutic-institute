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
    public partial class FrmCustomersTable : Form
    {
        DataView dv;
        Customers MyCustomers1;
        CustomersTable MyCustomersT = new CustomersTable();
        DataView dvMeushar;
        DataView dvKabala1;
        DataView dvKabala2;
        DataView dvKabala3;
        DataView dvKabala4;
        DataView dvList;
        public FrmCustomersTable()
        {
            InitializeComponent();
            dv = new DataView(MyCustomersT.GetNiceCustTable());
            dgvCustomers.DataSource = dv;
            Etchul();

        }
        public void Etchul()
        { dgvCustomers.Columns[0].HeaderText = "תעודת זהות מטופל";
            dgvCustomers.Columns[1].HeaderText = "שם מלא";
            dgvCustomers.Columns[2].HeaderText = "תאריך לידה";
            dgvCustomers.Columns[3].HeaderText = "כתובת";
            dgvCustomers.Columns[4].HeaderText = "עיר";
            dgvCustomers.Columns[5].HeaderText = "טלפון";
            dgvCustomers.Columns[6].HeaderText = "שם אם";
            dgvCustomers.Columns[7].HeaderText = "פלאפון אם";
            dgvCustomers.Columns[8].HeaderText = "שם אב";
            dgvCustomers.Columns[9].HeaderText = "פלאפון אב";
            dgvCustomers.Columns[10].HeaderText = "חברת ביטוח";
            dvList = new DataView(new KabalatLakoachTable().GetDataTable());
            DateTime dd = DateTime.Today.AddDays(-14);
            dvList.RowFilter = "TaharichKabala>'" + dd + "' and Status=false";
            for (int i = 0; i < dvList.Count; i++)
            {
                MyCustomers1 = new Customers(dvList[i][1].ToString());
                listBox1.Items.Add(MyCustomers1.ShemMishpacha + " " + MyCustomers1.ShemPraty);
               
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmCustomersTable_Load(object sender, EventArgs e)
        {

        }

        private void txtResearchLastName_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = "shemMale like'" + txtResearchName.Text + "*' or ShemEm like'"+txtResearchName.Text+ "*' or ShemAv like '"+txtResearchName.Text+"*'";
        }

        private void btnResearch_Click(object sender, EventArgs e)
        {
            dv.RowFilter = "TazLakoach='" + txtResearchId.Text + "'";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmCustomers ff = new FrmCustomers();
            ff.ShowDialog();
            dv = new DataView(MyCustomersT.GetNiceCustTable());
            dgvCustomers.DataSource = dv;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = "telephone like '" + txtTel.Text + "*' or pelephoneEm like '" + txtTel.Text + "*'or pelephoneAv like'" + txtTel.Text + "*'";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Customers cc = new Customers(Convert.ToString(dgvCustomers.SelectedRows[0].Cells[0].Value));
            FrmCustomers ff = new FrmCustomers(cc);
            ff.ShowDialog();
            dv = new DataView(MyCustomersT.GetNiceCustTable());
            dgvCustomers.DataSource = dv;
        }

        private void radioBTelephone_CheckedChanged(object sender, EventArgs e)
        {
            btnChipus.Enabled = false;
            txtTel.Text = "";
            txtResearchId.Enabled = false;
            txtResearchName.Enabled = false;
            txtTel.Enabled = true;
           

        }

        private void rbtnId_CheckedChanged(object sender, EventArgs e)
        {
            btnChipus.Enabled = true;
            txtResearchId.Text = "";
            txtResearchId.Enabled = true;
            txtResearchName.Enabled = false;
            txtTel.Enabled = false;
            

        }

        private void rbtnShemMale_CheckedChanged(object sender, EventArgs e)
        {
            btnChipus.Enabled = false;
            txtResearchName.Text = "";
            txtResearchId.Enabled = false;
            txtResearchName.Enabled = true;
            txtTel.Enabled = false;
           


        }

        private void btnChipus_Click(object sender, EventArgs e)
        {
            dv.RowFilter = "TazLakoach='" + txtResearchId.Text + "'";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dd = DateTime.Today.AddDays(-14);
            Customers cc=new Customers(Convert.ToString(dgvCustomers.SelectedRows[0].Cells[0].Value));
            dvKabala1 = new DataView(new KabalatLakoachTable().GetDataTable());
dvKabala1.RowFilter = "TazLakoach='" + cc.TazLakoach + "' and Status=true";
            dvKabala2 = new DataView(new KabalatLakoachTable().GetDataTable());
            dvKabala2.RowFilter = "TazLakoach='" + cc.TazLakoach + "' and Status=false and TaharichKabala>'" + dd + "'";
            dvKabala3 = new DataView(new KabalatLakoachTable().GetDataTable());
            dvKabala3.RowFilter = "TazLakoach='" + cc.TazLakoach + "' and Status=false and TaharichKabala<'" + dd + "'";
            dvKabala4 = new DataView(new KabalatLakoachTable().GetDataTable());
            dvKabala4.RowFilter = "TazLakoach='" + cc.TazLakoach + "'";
            if (dvKabala1.Count>0)
            {
            FrmSidratTipulimVekvihatam ff = new FrmSidratTipulimVekvihatam(cc,"UPDATE");
            ff.Show();
            }
            if (dvKabala2.Count>0)
            {
                MessageBox.Show("יש לחכות לאשור טיפול");

            }
            if (dvKabala3.Count>0)
            {
                FrmSidratTipulimVekvihatam ff = new FrmSidratTipulimVekvihatam(cc, "NEW");
                ff.Show();

            }
            if (dvKabala4.Count==0)
            {
                FrmSidratTipulimVekvihatam ff = new FrmSidratTipulimVekvihatam(cc, "NEW");
                ff.Show();

            }

           
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBakashaLehivchun_Click(object sender, EventArgs e)
        {
            
        }

        private void txtResearchName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == ' ' || e.KeyChar == '-')
            {

            }
            else
                e.Handled = true;
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '\b'  || e.KeyChar == '-')
            {

            }
            else
                e.Handled = true;
        }

        private void txtResearchId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '\b' )
            {

            }
            else
                e.Handled = true;
        }

        private void txtResearchId_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
