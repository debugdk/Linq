using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ.SetOperators
{
    public partial class Distinct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] country = { "India", "USA", "usa", "uk" };
            var result = country.Distinct();
            foreach (var r in result)
            {
                Response.Write(r+"<br/>");
            }
            Response.Write("<hr />");
            var resultCase = country.Distinct(StringComparer.OrdinalIgnoreCase);
            foreach (var r in resultCase)
            {
                Response.Write(r + "<br/>");
            }
            Response.Write("<hr />");
            List<Employee> list = new List<Employee>()
            {
                new Employee { ID = 101, Name = "Mike"},
                new Employee { ID = 101, Name = "Mike"},
                new Employee { ID = 102, Name = "Mary"}
            };
            var emp = list.Distinct();//not working becasue Distinct compare ref of refance type which is not same 
            foreach (var r in emp)
            {
                Response.Write(r.ID+"-"+r.Name + "<br/>");
            }

            Response.Write("<hr />");

            var empDistinct = list.Distinct(new EmployeeComparer());
            foreach (var r in empDistinct)
            {
                Response.Write(r.ID + "-" + r.Name + "<br/>");
            }
            Response.Write("<hr />");
            var empdis = list.Select(x => new { x.ID, x.Name }).Distinct();
            foreach (var r in empdis)
            {
                Response.Write(r.ID + "-" + r.Name + "<br/>");
            }


        }
        class Employee
        {
            public int ID { get; set; }
            public string Name { set; get; }

            //public override bool Equals(object obj)
            //{
            //    return this.ID == ((Employee)obj).ID && this.Name == ((Employee)obj).Name;
            //}
            //public override int GetHashCode()
            //{
            //    return this.ID.GetHashCode() ^ this.Name.GetHashCode();
            //}
        }
        class EmployeeComparer : IEqualityComparer<Employee>
        {

            public bool Equals(Employee x, Employee y)
            {
                return x.ID == y.ID && x.Name == y.Name;
            }

            public int GetHashCode(Employee obj)
            {
                return obj.ID.GetHashCode() ^ obj.Name.GetHashCode();
            }
        }

    }
}