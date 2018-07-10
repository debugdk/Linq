using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ
{
    public partial class AvgTime : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            getAvg();
        }
        void getAvg()
        {
            string[] time = new string[5] {"1:20","2:30","3:45","5:10","1:45"};
            var timeTotal=time.Select(t =>t==""?0: 
                            Convert.ToDouble(t.Split(':')[0]) * 60 + 
                            Convert.ToDouble(t.Split(':')[1]));
            var Min = Math.Truncate((timeTotal.Average() / 60) + (timeTotal.Average() / 60));
            var Sec= Math.Truncate((timeTotal.Average() / 60) + (timeTotal.Average() % 60));
            string avergTime= Min + ":" + Sec;
        }
    }
}