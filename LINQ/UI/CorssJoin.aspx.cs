using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LINQ.Model;
namespace LINQ.UI
{
    public partial class CorssJoin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var result=from x in Employee.GetAllEmployees()
                       from d in Departmen.GetAllDepartments()
                       select new {x,d};
            foreach(var r in result)
            {
                Response.Write(r.x.Name+"-"+r.d.Name+"<br/>");
            }
            Response.Write("<hr/>");
            var results = Employee.GetAllEmployees().SelectMany(x => Departmen.GetAllDepartments(),
                                                                (x, d) => new { x, d });
            foreach (var r in results)
            {
                Response.Write(r.x.Name + "-" + r.d.Name + "<br/>");
            }
            Response.Write("<hr/>");
            var res = Employee.GetAllEmployees().Join(Departmen.GetAllDepartments(), x => true, d => true, (x, d) => new { x, d });
            foreach (var r in res)
            {
                Response.Write(r.x.Name + "-" + r.d.Name + "<br/>");
            }
        }
    }
}