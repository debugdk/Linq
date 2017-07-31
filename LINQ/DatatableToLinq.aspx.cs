using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LINQ.Model;

namespace LINQ
{
    public partial class DatatableToLinq : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            getdata();
        }

        void getdata()
        {
            DatabaseHelper dbh = new DatabaseHelper();
            string query = "SELECT * from emp;";
            DataTable dt=dbh.getDataTable(query);
            List<Emp> emplist = new List<Emp>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Emp emp = new Emp();
                emp.id = Convert.ToInt32(dt.Rows[i]["Id"]);
                emp.name = dt.Rows[i]["Name"].ToString();
                emp.DId = Convert.ToInt32(dt.Rows[i]["DId"]);
                emp.gender = dt.Rows[i]["Gender"].ToString();
                emp.salary =Convert.ToDouble(dt.Rows[i]["salary"].ToString());
                emplist.Add(emp);
            }

            query = "select * from department; ";
            dt = dbh.getDataTable(query);
            List<Department> Departmentlist = new List<Department>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Department dep = new Department();
                dep.id = Convert.ToInt32(dt.Rows[i]["Id"]);
                dep.name = dt.Rows[i]["Name"].ToString();
                Departmentlist.Add(dep);
            }
            IEnumerable <Department> depts= Departmentlist.Where(x => x.name == "IT" || x.name == "HR");
            foreach (Department dept in depts)
            {
                Response.Write(dept.name);
                Response.Write("<br />");
                IEnumerable<Emp> Emps= emplist.Where(x=>x.DId==dept.id && x.gender=="M");
                foreach (Emp emp in Emps)
                {
                    Response.Write(emp.name);
                    Response.Write("<br />");
                }
            }
            Response.Write("<hr />");
            var Emp = emplist.Where(emply => emply.salary > 120000)
                .Select(emply => new { name = emply.name, gender = emply.gender,salary=emply.salary,bonus=emply.salary*.1 });
            Response.Write("<table border="+1+">");
            Response.Write("<tr><th>Name</th><th>gender</th><th>salary</th><th>bouns</th><th>Total salary</th></tr>");
            foreach (var i in Emp)
            {
                Response.Write("<tr>");
                Response.Write("<td>"+i.name+"</td>");
                Response.Write("<td>"+i.gender+"</td>");
                Response.Write("<td>" + i.salary + "</td>");
                Response.Write("<td>" + i.bonus + "</td>");
                double total = i.bonus + i.salary;
                Response.Write("<td>" + total+ "</td>");
                Response.Write("</tr>");
            }
            Response.Write("</table>");

        }
        
    }
}