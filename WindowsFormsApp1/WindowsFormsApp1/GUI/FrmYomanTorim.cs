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
    public partial class FrmYomanTorim : Form
    {
        DataView dvYomanTorim;
        public FrmYomanTorim()
        {
            InitializeComponent();
            dvYomanTorim = new DataView(new CustomersTable().GetYomanTorim());
            dgvYomanTorim.DataSource = dvYomanTorim;
            dgvYomanTorim.Columns[0].HeaderText = "תז לקוח";
            dgvYomanTorim.Columns[1].HeaderText = "קוד טיפול";
            dgvYomanTorim.Columns[2].HeaderText = "תאריך";
            //dgvYomanTorim.Columns[2].DefaultCellStyle.Format = "D2";
            dgvYomanTorim.Columns[3].HeaderText = "קוד סידרת טיפולים";
            dgvYomanTorim.Columns[4].HeaderText = "קוד קבלה";
            dgvYomanTorim.Columns[5].HeaderText = "תז עובד";
            dgvYomanTorim.Columns[6].HeaderText = "שם עובד";
            dgvYomanTorim.Columns[7].HeaderText = "יום בשבוע";
            dgvYomanTorim.Columns[8].HeaderText = "שעה";

        }

        private void FrmYomanTorim_Load(object sender, EventArgs e)
        {

        }

        private void dgvYomanTorim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
