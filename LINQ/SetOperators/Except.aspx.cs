using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ.SetOperators
{
    public partial class Except : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] x = { 1, 2, 3, 4, 5 };
            int[] y = { 1, 4, 2, 7, 8 };
            var result = x.Except(y);
            foreach (var r in result)
            {
                Response.Write(r + "<br />");
            }
            Response.Write("<hr/>");
            int[] z = { 1, 2, 3, 4, 5 };
            var resultNull = x.Except(z);
            foreach (var r in resultNull)
            {
                Response.Write("Null"+r + "<br />");
            }
        }
    }
}