using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LINQ.Model;

namespace LINQ.UI
{
    public partial class GroupJoin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var EmployeeByDepartment=Departmen.GetAllDepartments()
                                                .GroupJoin(Employee.GetAllEmployees(),
                                                           d=>d.ID,
                                                           x=>x.DepartmentID,
                                                           (department,employees)=>new
                                                           {
                                                                Department=department,
                                                                Employees=employees
                                                           });
            foreach (var department in EmployeeByDepartment)
            {
                Response.Write(department.Department.Name+"<Br/>");
                foreach(var emp in department.Employees)
                {
                    Response.Write("  "+emp.Name + "<br/>");
                }
                Response.Write("<br/>");
            }

            Response.Write("<hr/> Sql like<br/>");
            var EmployeeByDepartmentSQl = from d in Departmen.GetAllDepartments()
                                          join x in Employee.GetAllEmployees()
                                          on d.ID equals x.DepartmentID into eGroup
                                          select new
                                          {
                                              department = d,
                                              Employees = eGroup
                                          };
            foreach (var department in EmployeeByDepartmentSQl)
            {
                Response.Write(department.department.Name + "<Br/>");
                foreach (var emp in department.Employees)
                {
                    Response.Write("  " + emp.Name + "<br/>");
                }
                Response.Write("<br/>");
            }
            
        }
    }
}