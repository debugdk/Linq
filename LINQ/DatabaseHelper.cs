using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using Npgsql;
namespace LINQ
{
    public class DatabaseHelper
    {
        public static readonly string connStr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        public  DataTable getDataTable(string strSql)
        {
            DataTable dt = new DataTable();
            using (var conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (var da = new NpgsqlDataAdapter(strSql, conn))
                    {
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
            return dt;
        }

    }
}