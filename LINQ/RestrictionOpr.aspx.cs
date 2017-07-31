using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ
{
    public partial class RestrictionOpr : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> even= numbers.Where(x => x % 2 == 0);
            foreach (int i in even)
            {
                Response.Write(i + "<br />");
            }
            Response.Write("<hr />");
            Func<int, bool> perdicate = x => x % 2 == 0;
            IEnumerable<int> even1 = numbers.Where(perdicate);
            foreach (int i in even1)
            {
                Response.Write(i + "<br />");
            }
            Response.Write("<hr />");
            IEnumerable<int> even2 = numbers.Where(num=>isEven(num));
            foreach (int i in even1)
            {
                Response.Write(i + "<br />");
            }
            
        }
        private bool isEven(int num)
        {
            return num % 2 == 0;
        }
    }
}