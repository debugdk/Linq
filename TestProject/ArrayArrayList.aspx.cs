using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Diagnostics;

namespace TestProject
{
    public partial class ArrayArrayList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCheck_Click(object sender, EventArgs e)
        {
            Stopwatch objWatch = new Stopwatch();
            objWatch.Start();
            int []arrayInt=new int[1000];
            for (int i = 0; i < 1000; i++)
                arrayInt[i] = i;
            foreach (int i in arrayInt)
            {
                Response.Write(i);
            } 
            objWatch.Stop();
            lblArray.Text = objWatch.ElapsedTicks.ToString();
            objWatch.Reset();
            objWatch.Start();
            ArrayList objArrayList = new ArrayList();
            for (int j = 1; j < 1000; j++)
                objArrayList.Add(j);
            foreach (int i in objArrayList)
            {
                Response.Write(i);
            }
            objWatch.Stop();
            lblArrayLiat.Text = objWatch.ElapsedTicks.ToString();

        }
    }
}




