using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ.SetOperators
{
    public partial class Union : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] x = { 1, 2, 3, 4, 5 };
            int[] y = { 1, 4, 2, 7, 8 };
            var result = x.Union(y);
            foreach (var r in result)
            {
                Response.Write(r + "<br />");
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
            var emp = list.Union(list1);//there is repitiation of dubulicate data 
            foreach (var r in emp)
            {
                Response.Write(r.ID + "-" + r.Name + "<br/>");
            }
            Response.Write("<hr/>");
            var empDis = list.Select(e1 => new { e1.ID, e1.Name }).Union(list1.Select(e2 => new { e2.ID, e2.Name }));
            foreach (var r in empDis)
            {
                Response.Write(r.ID + "-" + r.Name + "<br/>");
            }
        }
        class Employee
        {
            public int ID { get; set; }
            public string Name { set; get; }
        }
    }
}