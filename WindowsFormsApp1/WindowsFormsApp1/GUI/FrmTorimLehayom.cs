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
    public partial class FrmTorimLehayom : Form
    {
        DataView dvTorimLehayom;
        //Customers MyCustomers1;
        PerutTipulBesidra MyPerutTipul1;
        Employess ee;
        Hitmachuiot hh;
        public FrmTorimLehayom()
        {
            InitializeComponent();
            dvTorimLehayom = new DataView(new CustomersTable().GetYomanTorimMeudcan());
            dvTorimLehayom.RowFilter = "Taharich='" + DateTime.Today+"'";
            dgvYomanTorimLehayom.DataSource = dvTorimLehayom;
          dgvYomanTorimLehayom.Columns[0].HeaderText = "תז לקוח";
            dgvYomanTorimLehayom.Columns[1].HeaderText = "שם לקוח";
            dgvYomanTorimLehayom.Columns[2].HeaderText = "קוד טיפול";
            dgvYomanTorimLehayom.Columns[3].HeaderText = "קוד סידרת טיפולים";
            dgvYomanTorimLehayom.Columns[4].HeaderText = "קוד קבלה";
            dgvYomanTorimLehayom.Columns[5].HeaderText = "תז עובד";
            dgvYomanTorimLehayom.Columns[6].HeaderText = "שם עובד";
            dgvYomanTorimLehayom.Columns[7].HeaderText = "שעה";
            dgvYomanTorimLehayom.Columns[8].HeaderText = "יום בשבוע";
            dgvYomanTorimLehayom.Columns[9].HeaderText = "תאריך";

        }
        public FrmTorimLehayom( string tz)
        {
            InitializeComponent();
            dvTorimLehayom = new DataView(new CustomersTable().GetYomanTorimMeudcan());
            dvTorimLehayom.RowFilter = "Taharich='" + DateTime.Today + "' and TazOved='"+tz+"'";
            dgvYomanTorimLehayom.DataSource = dvTorimLehayom;
            dgvYomanTorimLehayom.Columns[0].HeaderText = "תז לקוח";
            dgvYomanTorimLehayom.Columns[1].HeaderText = "שם לקוח";
            dgvYomanTorimLehayom.Columns[2].HeaderText = "קוד טיפול";
            dgvYomanTorimLehayom.Columns[3].HeaderText = "קוד סידרת טיפולים";
            dgvYomanTorimLehayom.Columns[4].HeaderText = "קוד קבלה";
            dgvYomanTorimLehayom.Columns[5].HeaderText = "תז עובד";
            dgvYomanTorimLehayom.Columns[6].HeaderText = "שם עובד";
            dgvYomanTorimLehayom.Columns[7].HeaderText = "שעה";
            dgvYomanTorimLehayom.Columns[8].HeaderText = "יום בשבוע";
            dgvYomanTorimLehayom.Columns[9].HeaderText = "תאריך";



        }
        private void FrmTorimLehayom_Load(object sender, EventArgs e)
        {

        }

      private void button1_Click(object sender, EventArgs e)
       {
          MyPerutTipul1 = new PerutTipulBesidra(Convert.ToInt32(dgvYomanTorimLehayom.SelectedRows[0].Cells[2].Value));
            FrmPerutTipulimBesidra ff = new FrmPerutTipulimBesidra(MyPerutTipul1,"UPDATE","metapel");
            ff.Show();
        }

        private void dgvYomanTorimLehayom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnZfia_Click(object sender, EventArgs e)
        {
            MyPerutTipul1 = new PerutTipulBesidra(Convert.ToInt32(dgvYomanTorimLehayom.SelectedRows[0].Cells[2].Value));
            FrmPerutTipulimBesidra ff = new FrmPerutTipulimBesidra(MyPerutTipul1,"ZFIIA","metapel");
            ff.Show();
        }
    }
}
