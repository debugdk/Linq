using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace LINQ.UI
{
    public partial class CastVsofType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArrayList a = new ArrayList();
            a.Add(1);
            a.Add(2);
            a.Add(3);
            //a.Add("as");
            IEnumerable<int> result = a.Cast<int>();
            foreach (int i in result)
            {
                Response.Write(i + "<br />");
            }
            a.Add("A");
            Response.Write("<hr />");
            a.Add(4);
            IEnumerable<int> results = a.OfType<int>();
            foreach (int i in results)
            {
                Response.Write(i + "<br />");
            }
        }
    }
}