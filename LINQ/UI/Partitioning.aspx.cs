using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ.UI
{
    public partial class Partitioning : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string[] Country = { "Austali", "SriLanka", "Butan", "India", "US", "Pakistan", "Uk" };
            Response.Write("Data<br/><hr/>");
            foreach (string s in Country)
            {
                Response.Write(s + "<br/>");
            }


            Response.Write("<hr/>Take<br/><hr/>");
            IEnumerable<string> take= Country.Take(3);
            foreach(string s in take)
            {
                Response.Write(s + "<br/>");
            }

            Response.Write("<hr/>Skip<br/><hr/>");
            IEnumerable<string> skip = Country.Skip(3);
            foreach (string s in skip)
            {
                Response.Write(s + "<br/>");
            }

            Response.Write("<hr/>TakeWhile<br/><hr/>");
            IEnumerable<string> takeWhile = Country.TakeWhile(s => s.Length > 2);
            foreach (string s in takeWhile)
            {
                Response.Write(s + "<br/>");
            }
            Response.Write("<hr/>skipWhile<br/><hr/>");
            IEnumerable<string> skipWhile = Country.SkipWhile(s => s.Length > 2);
            foreach (string s in skipWhile)
            {
                Response.Write(s + "<br/>");
            }

        }
    }
}