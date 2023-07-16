using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApp1.DAL
{
    public class Dal
    {
        DataSet ds;
        OleDbConnection con;

        public Dal()
        {
            ds = new DataSet();
            con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\\MachonTipuly.mdb");
        }

        public void AddTable(string tableName)
        {
            if (!ds.Tables.Contains(tableName))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter("select * from " + tableName, con);
                adapter.Fill(ds, tableName);
            }
        }

        public DataTable GetTable(string tableName)
        {
            return ds.Tables[tableName];
        }

        public DataTable GetQuery(string SQLQuery)
        {
            OleDbDataAdapter Adapter = new OleDbDataAdapter(SQLQuery, con);
            DataTable Query = new DataTable();
            Adapter.Fill(Query);
            return Query;
        }

        public void Update(string tableName)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from " +tableName, con);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.UpdateCommand = builder.GetUpdateCommand();
            adapter.DeleteCommand = builder.GetDeleteCommand();

            adapter.Update(ds, tableName);
        }
    }
}
