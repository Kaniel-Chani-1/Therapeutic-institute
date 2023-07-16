using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;
using WindowsFormsApp1.DAL;
using WindowsFormsApp1.BLL;

namespace WindowsFormsApp1.BLL
{
    public abstract class GeneralTable
    {
        protected static Dal dal = new Dal();
        protected DataTable table;
        protected string tableName;
        protected string key;
        private int currentRow;



        public GeneralTable(string tableName, string key)
        {
            dal.AddTable(tableName);
            this.table = dal.GetTable(tableName);
            this.tableName = tableName;
            this.key = key;
        }

        public DataTable GetDataTable()
        {
            return table;
        }
        public string GetTableName()
        {
            return tableName;
        }
        public string GetPrimaryKey()
        {
            return key;
        }

        public bool IsEmpty()
        {
            if (table.Rows.Count == 0)
                return true;
            return false;
        }
        public DataRow GetCurrentRow()
        {
            if (IsEmpty())
                throw new Exception("הטבלה ריקה");
            return table.Rows[currentRow];
        }


        public DataRow GetNext()
        {
            if (IsEmpty())

                throw new Exception("הטבלה ריקה");

            currentRow++;
            if (currentRow == table.Rows.Count)
                currentRow = 0;
            return table.Rows[currentRow];
        }

        public DataRow GetPrevious()
        {
            if (IsEmpty())
                throw new Exception("הטבלה ריקה");
            currentRow--;
            if (currentRow == -1)
                currentRow = table.Rows.Count - 1;
            return table.Rows[currentRow];
        }
        public DataRow GetFirst()
        {
            if (IsEmpty())
                throw new Exception("הטבלה ריקה");
            currentRow = 0;
            return table.Rows[currentRow];
        }

        public DataRow GetLast()
        {
            if (IsEmpty())
                throw new Exception("הטבלה ריקה");
            currentRow = table.Rows.Count - 1;
            return table.Rows[currentRow];
        }

        public DataRow Find(string fieldName, object value)
        {
            foreach (DataRow row in table.Rows)
            {
                if (row[fieldName].Equals(value))
                    return row;
            }
            return null;
        }
        public DataRow Find(object value)
        {
            return Find(this.key, value);
        }
        public DataTable FindAll(string fieldName, object value)
        {
            DataTable dtTemp = dal.GetQuery("select * from " + this.tableName + " where " + fieldName + " = " + value.ToString());
            return dtTemp;
        }

        public DataRow GetNewRow()
        {
            return table.NewRow();
        }
        public void AddRow(DataRow drow)
        {
            table.Rows.Add(drow);
            Save();
        }
        public void Save()
        {
            try
            {
                dal.Update(table.TableName);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
           
          public int GetNewKey()
{
DataTable dt = dal.GetQuery("select max("+key+") from " + table.TableName);
return Convert.ToInt32(dt.Rows[0][0]) + 1;
}
        }
    }

