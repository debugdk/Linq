using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LINQ.Model;

namespace LINQ.UI
{
    public partial class PagingTakeSkip : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtPageNo_TextChanged(object sender, EventArgs e)
        {
            int pageNo = 0;
            IEnumerable<Student> student= Student.GetAllStudent();
            foreach (Student s in student)
            {
                Response.Write(s.id + " " + s.Name + " " + s.mark + "<br/>");
            }
            Response.Write("<br/><hr/>");
            if(int.TryParse(txtPageNo.Text,out pageNo))
            {
                int pageSize = 3;
                if (pageNo >= 1 && pageNo <= 3)
                { 
                    IEnumerable<Student> result= student.Skip((pageNo-1)*pageSize).Take(pageSize);
                    foreach (Student s in result)
                    {
                        Response.Write(s.id + " " + s.Name + " " + s.mark+"<br/>");
                    }
                }
            }
        }

    }
}