using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RND
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Label lblCount = (Label)Master.FindControl("lblCount");           

            Session["count"] = Session["count"] == null ?
                             Session["count"] = 0 :
                             Session["count"] = (Convert.ToInt32(Session["count"]) + 1);
            lblCount.Text = Session["count"].ToString();
            this.Master.Message = Session["count"].ToString();
        }
    }
}