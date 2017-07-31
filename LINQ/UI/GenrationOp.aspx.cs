using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ.UI
{
    public partial class GenrationOp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IEnumerable<int> result= Enumerable.Range(1, 10).Where(x=>x%2==0);
            foreach (int i in result)
            {
                Response.Write(i + "<br/>");
            }

            var resultRpt = Enumerable.Repeat("LINQ", 5);
            foreach (var  r in resultRpt)
            {
                Response.Write(r + "<br/>");
            }
            IEnumerable<int> resultEmpty = GetIntegerSequence() ?? Enumerable.Empty<int>();

            foreach (var v in resultEmpty)
            {
                Console.WriteLine(v);
            }


        }
        private static IEnumerable<int> GetIntegerSequence()
        {
            return null;
        }
    }
}