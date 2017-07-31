using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ.UI
{
    public partial class LookUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Employee> listEmployees = new List<Employee>
            {
                new Employee() { Name = "Ben", JobTitle = "Developer", City = "London" },
                new Employee() { Name = "John", JobTitle = "Sr. Developer", City = "Bangalore" },
                new Employee() { Name = "Steve", JobTitle = "Developer", City = "Bangalore" },
                new Employee() { Name = "Stuart", JobTitle = "Sr. Developer", City = "London" },
                new Employee() { Name = "Sara", JobTitle = "Developer", City = "London" },
                new Employee() { Name = "Pam", JobTitle = "Developer", City = "London" }
            };
            var listEmpByTitle= listEmployees.ToLookup(s => s.JobTitle);
            foreach (var kvp in listEmpByTitle)
            {
                Response.Write(kvp.Key+"<br />");
                foreach(var emp in listEmpByTitle[kvp.Key])
                {
                    Response.Write(emp.Name + " " + emp.JobTitle + " " + emp.City + "<br />");
                }
            }
            foreach (var kvp in listEmpByTitle)
            {
                Response.Write(kvp.Key + " "+ kvp.Count());
            }
        }
        public class Employee
        {
            public string Name { get; set; }
            public string JobTitle { get; set; }
            public string City { get; set; }
        }
    }
}