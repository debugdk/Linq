using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ.UI
{
    public partial class GroupByMulti : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var employeeGroup = Employee.GetAllEmployees()
                              .GroupBy(x => new { x.Department, x.Gender })
                              .OrderBy(g => g.Key.Department).ThenBy(g => g.Key.Gender)
                              .Select(g => new
                                {
                                    Dept = g.Key.Department,
                                    Gender = g.Key.Gender,
                                    Employees = g.OrderBy(x => x.Name)
                                }
                              );
            foreach (var group in employeeGroup)
            {
                Response.Write(group.Dept + " Deparment " + group.Gender + " Count " + group.Employees.Count());
                Response.Write("<br />------------------<br/>");
                foreach(var emp in group.Employees)
                {
                    Response.Write(emp.Name+" "+emp.Gender+" "+emp.Department+"<br/ >");
                }
                Response.Write("<Br/>");
            }
            Response.Write("<hr/>");
            var empGroup = from Employees in Employee.GetAllEmployees()
                           group Employees by new { Employees.Department, Employees.Gender } into eGroup
                           orderby eGroup.Key.Department, eGroup.Key.Gender
                           select new
                           {
                               Dept = eGroup.Key.Department,
                               Gender = eGroup.Key.Gender,
                               Employees = eGroup.OrderBy(x=>x.Name)
                           };
            foreach (var group in empGroup)
            {
                Response.Write(group.Dept + " Deparment " + group.Gender + " Count " + group.Employees.Count());
                Response.Write("<br />------------------<br/>");
                foreach (var emp in group.Employees)
                {
                    Response.Write(emp.Name + " " + emp.Gender + " " + emp.Department + "<br/ >");
                }
                Response.Write("<Br/>");
            }
        }
        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
            public string Department { get; set; }
            public int Salary { get; set; }

            public static List<Employee> GetAllEmployees()
            {
                return new List<Employee>()
                {
                    new Employee { ID = 1, Name = "Mark", Gender = "Male",
                                                 Department = "IT", Salary = 45000 },
                    new Employee { ID = 2, Name = "Steve", Gender = "Male",
                                                 Department = "HR", Salary = 55000 },
                    new Employee { ID = 3, Name = "Ben", Gender = "Male",
                                                 Department = "IT", Salary = 65000 },
                    new Employee { ID = 4, Name = "Philip", Gender = "Male",
                                                 Department = "IT", Salary = 55000 },
                    new Employee { ID = 5, Name = "Mary", Gender = "Female",
                                                 Department = "HR", Salary = 48000 },
                    new Employee { ID = 6, Name = "Valarie", Gender = "Female",
                                                 Department = "HR", Salary = 70000 },
                    new Employee { ID = 7, Name = "John", Gender = "Male",
                                                 Department = "IT", Salary = 64000 },
                    new Employee { ID = 8, Name = "Pam", Gender = "Female",
                                                 Department = "IT", Salary = 54000 },
                    new Employee { ID = 9, Name = "Stacey", Gender = "Female",
                                                 Department = "HR", Salary = 84000 },
                    new Employee { ID = 10, Name = "Andy", Gender = "Male",
                                                 Department = "IT", Salary = 36000 }
                };
            }
        }
    }
}