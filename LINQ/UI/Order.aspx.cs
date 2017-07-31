using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LINQ.Model;
namespace LINQ.UI
{
    public partial class Order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Without order<br/>");
            IEnumerable<Student> students = Student.GetAllStudent();
            foreach (Student s in students)
            {
                Response.Write(s.id+" "+s.Name+" "+s.mark + "<br/>");
            }
            Response.Write("<hr />With rev order<br/>");
            IEnumerable<Student> studentRev= students.Reverse();
            foreach (Student s in studentRev)
            {
                Response.Write(s.id + " " + s.Name + " " + s.mark + "<br/>");
            }


            Response.Write("<hr />With order<br/>");
            IEnumerable<Student> result= Student.GetAllStudent().OrderBy(s => s.Name);
            foreach (Student s in result)
            {
                Response.Write(s.Name + "<br/>");
            }

            Response.Write("<hr />With order dec<br/>");
            IEnumerable<Student> resultdec = Student.GetAllStudent().OrderByDescending(s => s.Name);
            foreach (Student s in resultdec)
            {
                Response.Write(s.Name + "<br/>");
            }
            Response.Write("<hr />With order then by<br/>");
            IEnumerable<Student> resulThen = Student.GetAllStudent().OrderBy(s => s.mark).ThenBy(s=>s.Name).ThenByDescending(s=>s.id);
            foreach (Student s in resulThen)
            {
                Response.Write(s.mark+" "+s.Name+" "+ s.id+ "<br/>");
            }
            //SQL like 
            Response.Write("<hr />With order Sql like<br/>");
            IEnumerable<Student> res = from studnet in Student.GetAllStudent()
                     orderby studnet.Name
                     select studnet;
            foreach (Student s in res)
            {
                Response.Write(s.Name + "<br/>");
            }
            Response.Write("<hr />With order Sql like Dec<br/>");
            IEnumerable<Student> resDec = from studnet in Student.GetAllStudent()
                                       orderby studnet.Name descending
                                       select studnet;
            foreach (Student s in resDec)
            {
                Response.Write(s.Name + "<br/>");
            }

            Response.Write("<hr />With order Sql like then by<br/>");
            IEnumerable<Student> resThen = from studnet in Student.GetAllStudent()
                                          orderby studnet.mark,studnet.Name,studnet.id descending
                                          select studnet;
            foreach (Student s in resThen)
            {
                Response.Write(s.mark + " " + s.Name + " " + s.id + "<br/>");
            }


        }
    }
}