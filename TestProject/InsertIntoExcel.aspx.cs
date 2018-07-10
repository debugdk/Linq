using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestProject
{
    public partial class InsertIntoExcel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string fileName = @"Book1.xlsx";
            string connectionString = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source={0};Extended Properties='Excel 12.0;HDR=YES;IMEX=0'", fileName);

            using (OleDbConnection cn = new OleDbConnection(connectionString))
            {
                cn.Open();
                OleDbCommand cmd1 = new OleDbCommand("INSERT INTO [Sheet1$] " +
                     "([Column1],[Column2],[Column3],[Column4]) " +
                     "VALUES(@value1, @value2, @value3, @value4)", cn);
                cmd1.Parameters.AddWithValue("@value1", "Key1");
                cmd1.Parameters.AddWithValue("@value2", "Sample1");
                cmd1.Parameters.AddWithValue("@value3", 1);
                cmd1.Parameters.AddWithValue("@value4", 9);
                cmd1.ExecuteNonQuery();
            }
        }
    }
}