using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ.UI
{
    public partial class ConcatOp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 1, 4, 5 };
            var result = numbers1.Concat(numbers2);
            foreach (var v in result)
            {
                Response.Write(v + "<br/>");
            }
            //diffrance b/t concate and union
            //union remove dublicate elemennt 
            //where concate is not.
        }
    }
}