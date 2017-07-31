using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ.UI
{
    public partial class QuantiferOp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            bool resultAll = numbers.All(x => x < 10);
            Response.Write(resultAll);//true

            bool resultAny = numbers.Any();
            Response.Write(resultAny);//true

            bool resultAnyP = numbers.Any(x => x > 10);
            Response.Write(resultAnyP);//false

            bool resultContain = numbers.Contains(2);
            Response.Write(resultContain);

            string[] countries = { "USA", "INDIA", "UK" };
            bool resultString = countries.Contains("india", StringComparer.OrdinalIgnoreCase);
            Response.Write(resultString);//true ignore case check


        }
    }
}