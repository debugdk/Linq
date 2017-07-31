using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ.SetOperators
{
    public partial class Intersect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] x = { 1, 2, 3, 4, 5 };
            int[] y = { 1, 4, 2, 7, 8 };
            var result = x.Intersect(y);
            foreach (var r in result)
            {
                Response.Write(r + "<br />");
            }
            Response.Write("<hr/>");
            int[] z = { 7, 8 };
            var nullresult = x.Intersect(z);
            foreach (var r in nullresult)
            {
                Response.Write("NULL"+r + "<br />");
            }
            Response.Write("<hr/>");
            List<Employee> list = new List<Employee>()
            {
                new Employee { ID = 101, Name = "Mike"},
                new Employee { ID = 102, Name = "Ram"},
                new Employee { ID = 102, Name = "Mary"}
            };
            List<Employee> list1 = new List<Employee>()
            {
                new Employee { ID = 101, Name = "Mike"},
                new Employee { ID = 104, Name = "Puja"},
                new Employee { ID = 105, Name = "Aprana"}
            };
            var emp = list.Intersect(list1);//this is not work as we expected
            foreach (var r in emp)
            {
                Response.Write(r.ID + "-" + r.Name + "<br/>");
            }
            Response.Write("<hr/>");
            var empInt = list.Select(a => new { a.ID, a.Name }).Intersect(list1.Select(b => new { b.ID, b.Name }));
            foreach (var r in empInt)
            {
                Response.Write(r.ID + "-" + r.Name + "<br/>");
            }
            Response.Write("<hr/>");
        }
        class Employee
        {
            public int ID { get; set; }
            public string Name { set; get; }
        }
    }
}