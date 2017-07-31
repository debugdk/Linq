using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LINQ.Model;

namespace LINQ.UI
{
    public partial class LeftJoin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var result = from x in Employee.GetAllEmployees()
                         join d in Departmen.GetAllDepartments()
                         on x.DepartmentID equals d.ID into eGroup
                         from d in eGroup.DefaultIfEmpty()
                         select new
                         {
                             EmployeeName = x.Name,
                             DepartmentName = d==null?"No Departement": d.Name
                         };
            foreach (var r in result)
            {
                Response.Write(r.EmployeeName + "-" + r.DepartmentName + "<br/>");
            }
            Response.Write("<hr />");
            var results = Employee.GetAllEmployees()
                                .GroupJoin(Departmen.GetAllDepartments(),
                                           x => x.DepartmentID,
                                           d => d.ID,
                                           (emp, deps) => new
                                           {
                                               emp,
                                               deps
                                           })
                                .SelectMany(z => z.deps.DefaultIfEmpty(),
                                        (a, b) => new
                                            { 
                                                EmployeeName=a.emp.Name,
                                                DepartmentName=b==null?"No Department":b.Name
                                            });
            foreach (var r in results)
            {
                Response.Write(r.EmployeeName + "-" + r.DepartmentName + "<br/>");
            }
        }
    }
}