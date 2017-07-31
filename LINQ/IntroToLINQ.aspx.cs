using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ
{
    public partial class IntroToLINQ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IntroToLINQs();

        }
        void IntroToLINQs()
        {
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5,6 };
            IEnumerable<int> even = numbers.Where(n => n % 2 == 0);
            foreach (int num in even)
            {
                Response.Write(num);
                Response.Write("<br />");
            }
            var evenQuery = from num in numbers where (num % 2) == 0 select num;
            var oddQuery = from num in numbers where (num % 2) != 0 select num;
            foreach (int num in evenQuery)
            {
                Response.Write(num);
                Response.Write("<br />");
            }
            Response.Write("<hr />");
            foreach (int num in oddQuery)
            {
                Response.Write(num);
                Response.Write("<br />");
            }
        }
    }
}