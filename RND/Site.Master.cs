using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RND
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                updateCount();
        }
        void updateCount()
        {
            Session["count"]= Session["count"] == null ?
                              Session["count"] = 0 :
                              Session["count"] = Session["count"];
            lblCount.Text = Session["count"].ToString();
            lblMsg.Text= Session["count"].ToString();
        }
        public string Message
        {
            get
            {
                return lblMsg.Text;
            }
            set
            {
                lblMsg.Text = value;
            }
        }
    }
}