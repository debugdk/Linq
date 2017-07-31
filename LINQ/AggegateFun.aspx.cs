using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ
{
    public partial class AggegateFun : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] number = { 2, 3, 4, 5 };
            int result = number.Aggregate((a, b) => a * b);
            Response.Write(result);
        }

        
    }
}