using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LINQ.Model;

namespace LINQ.UI
{
    public partial class InnerJoin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var result = Employee.GetAllEmployees().Join(
                                                        Departmen.GetAllDepartments(),
                                                        x => x.DepartmentID,
                                                        d => d.ID,
                                                        (employee,department ) => new
                                                        {
                                                            DepartmentName = department.Name,
                                                            EmployeeName = employee.Name
                                                           
                                                            
                                                        });
            foreach(var r in result)
            {
                Response.Write(r.EmployeeName + "-" + r.DepartmentName + "<br/>");
            }
            Response.Write("<hr /> SQl like <br/>");
            var resultSql = from x in Employee.GetAllEmployees()
                            join d in Departmen.GetAllDepartments()
                            on x.DepartmentID equals d.ID
                            select new
                            {
                                EmployeeName = x.Name,
                                DepartmentName = d.Name
                            };
            foreach (var r in resultSql)
            {
                Response.Write(r.EmployeeName + "-" + r.DepartmentName + "<br/>");
            }

        }
    }
}