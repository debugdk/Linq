using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ
{
    public partial class SalesForce : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            char [] c={':'};
            string[] time = { "1:20", "2:10", "","1:2", "3:40" };

            var min = time.Select(x =>x==""?0:x[0]);
                                    

            foreach (var m in min)
            {
                Response.Write(m);
            }
            
            //var sec = time.Select(x => x.Length == 0 ? null : x.Split(c, 2));
            //foreach (var m in min)
            //{
            //    Response.Write(m + "<br/>");
            //}

            //foreach (var s in sec)
            //{
            //    Response.Write(s + "<br/>");
            //}
            
            //time.Where(x=>x!="").Average(a=>new
            //                    {
            //                        v=Convert.ToDouble(a.Split(s,1))*60+Convert.ToDouble(a.Split(s,2))
            //                    }
            //    )
            //var Existing_Rep_Max_Travel_Time = time.Select(a => new
            //                                                   {
            //                                                       Existing_Rep_Max_Travel_Time = a == "" ? "0" :
            //                                                           (
            //                                                           a.Average(b =>  new 
            //                                                           {
            //                                                               b1 =Convert.ToDouble(
            //                                                                                   a.Split(s, 1).SingleOrDefault()) *
            //                                                                                   60 +
            //                                                                                   Convert.ToDouble(a.Split(s, 2).SingleOrDefault())
            //                                                           })
            //                                                           / 60 +
            //                                                           a.Average(c => new 
            //                                                           {
            //                                                               c1=Convert.ToDouble(
            //                                                                                   a.Split(s, 1)) *
            //                                                                                   60 +
            //                                                                                   Convert.ToDouble(a.Split(s, 2))
            //                                                           }))/60
            //                                                           + ":"+
            //                                                           (a.Average(b => new
            //                                                           {
            //                                                               b1 = Convert.ToDouble(
            //                                                                                   a.Split(s, 1)) *
            //                                                                                   60 +
            //                                                                                   Convert.ToDouble(a.Split(s, 2))
            //                                                           })
            //                                                           /60+
            //                                                           a.Average(c => new 
            //                                                           {
            //                                                               c1=Convert.ToDouble(
            //                                                                                   a.Split(s, 1)) *
            //                                                                                   60 +
            //                                                                                   Convert.ToDouble(a.Split(s, 2))
            //                                                           }))%60
                                                                                                   
            //                                                   }), 

        }
    }
}