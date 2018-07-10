using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LINQ.Model;

namespace LINQ.UI
{
    public partial class SelectMany : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            getdata();
        }
        void getdata()
        {
            IEnumerable<string> subject= Student.GetAllStudent().SelectMany(s => s.subjects).Distinct();
            foreach(string s in subject)
            {
                Response.Write(s);
                Response.Write("<br/>");
            }
            Response.Write("<hr/> SQL like");
            IEnumerable<string> subjectSQl = (from student in Student.GetAllStudent()
                                             from sub in student.subjects
                                             select sub).Distinct();
            foreach (string s in subjectSQl)
            {
                Response.Write(s);
                Response.Write("<br/>");
            }
            Response.Write("<hr/>");

            var result=Student.GetAllStudent().SelectMany(s => s.subjects, (student, subje) =>
                                                new { StudentName = student.Name, SubjectName = subje });
            foreach (var r in result)
            {
                Response.Write(r.StudentName+ "--"+r.SubjectName);
                Response.Write("<br/>");
            }
            Response.Write("<hr/>");
            IEnumerable<List<string>> res= Student.GetAllStudent().Select(s => s.subjects);
            foreach (List<string> liststing in res)
            {
                foreach (string str in liststing)
                {
                    Response.Write(str+"<br/>");
                }
            }
        }

    }
}