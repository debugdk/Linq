using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TestProject
{
    public partial class JoinInDatatable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                getData();
        }
        DataTable getCountry()
        {
            DataTable dtCountry=new DataTable();
            dtCountry = runSql("select * from Country;");
            gvCountry.DataSource = dtCountry;
            gvCountry.DataBind();
            gvCountry.DataBind();
            return dtCountry;
        }
        DataTable getState()
        {
            DataTable dtState = new DataTable();
            dtState = runSql("select * from State;");
            gvState.DataSource = dtState;
            gvState.DataBind();
            return dtState;
        }
        DataTable getCity()
        {
            DataTable dtCity = new DataTable();
            dtCity = runSql("select * from City;");
            gvCity.DataSource = dtCity;
            gvCity.DataBind();
            return dtCity;
        }
        void getData()
        {
            DataTable dtCountry = new DataTable();
            dtCountry = getCountry();
            DataTable dtState = new DataTable();
            dtState = getState();
            DataTable dtCity = new DataTable();
            dtCity = getCity();

            var result=from country in dtCountry.AsEnumerable()
                        join state in dtState.AsEnumerable() on country["CountryId"] equals state["CountryId"]
                        join city in dtCity.AsEnumerable() on state["StateId"] equals city["StateId"]
                        select new 
                        {
                            CountryName=country["CountryName"],
                            StateName=state["StateName"],
                            CityName=city["CityName"]
                        };
           
            DataTable dtJoin = new DataTable();
            dtJoin=ToDataTable(result.ToArray());
            grv.DataSource = dtJoin;
            grv.DataBind();

        }
        DataTable runSql(string sql)
        {
            string connString=@"Data Source=IMP-DESK-070\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True";
            SqlConnection con = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            con.Open();
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            return dt;
        }
        private static DataTable ToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection props =TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }
    }
}