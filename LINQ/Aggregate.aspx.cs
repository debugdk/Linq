using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ
{
    public partial class Aggregate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9,10 };
            int result = a.Min();
            Response.Write("Min="+result);
            result = a.Max();
            Response.Write("<br/>");
            Response.Write("Max="+result);
            Response.Write("<br/>");
            result = a.Count();
            Response.Write("Count=" + result);
            Response.Write("<br/>");
            result = a.Sum();
            Response.Write("Sum=" + result);
            Response.Write("<br/>");

            double avg = a.Average(x=>x*10);
            Response.Write("Avg=" + avg);
            double avg1 = a.Average();
            Response.Write("Avg1=" + avg1);
            Response.Write("<br/>");
            string[] country = { "India", "usa", "uk" };
            result = country.Min(x => x.Length);
            Response.Write("Min length="+result);
            Response.Write("<br/>");
            result = country.Max(x => x.Length);
            Response.Write("Max length=" + result);

        }

        
    }
}