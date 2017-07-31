using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ.UI
{
    public partial class SequenceOp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] countries1 = { "USA", "India", "UK" };
            string[] countries2 = { "USA", "India", "UK" };
            bool result = countries1.SequenceEqual(countries2);

            Response.Write("Are equle"+ result+ "<br/>");//true

            string[] countries3 = { "USA", "INDIA", "UK" };
            string[] countries4 = { "usa", "india", "uk" };
            bool resultCase = countries3.SequenceEqual(countries3);

            Response.Write("Are equle" + resultCase + "<br/>");//false

            bool resultCaseIgnor = countries2.SequenceEqual(countries4, StringComparer.OrdinalIgnoreCase);
            Response.Write("Are equle" + resultCaseIgnor + "<br/>");//true


            string[] countries5 = { "USA", "INDIA", "UK" };
            string[] countries6 = { "UK", "INDIA", "USA" };
            bool resultWithoutOrder = countries5.SequenceEqual(countries6);
            Response.Write("Are equle" + resultWithoutOrder + "<br/>");//false

            bool resultOrder = countries5.OrderBy(c => c).SequenceEqual(countries6.OrderBy(c => c));
            Response.Write("Are equle" + resultOrder + "<br/>");//true

            List<Employee> list1 = new List<Employee>()
            {
                new Employee { ID = 101, Name = "Mike"},
                new Employee { ID = 102, Name = "Susy"},
            };
            
                        List<Employee> list2 = new List<Employee>()
            {
                new Employee { ID = 101, Name = "Mike"},
                new Employee { ID = 102, Name = "Susy"},
            };
            var resultRefance = list1.Select(s => new { s.ID, s.Name }).SequenceEqual(list2.Select(s => new { s.ID,s.Name}));
            Response.Write("Are equle" + resultRefance + "<br/>");//true
        }
        class Employee
        {
            public int ID;
            public string Name;
        }
    }
}