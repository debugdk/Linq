using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LINQ.Model
{
    public class Student
    {
        public string Name { set; get; }
        public int id { set; get; }
        public int mark { set; get; }
        public string gender { set; get; }
        public List<string> subjects { set; get; }
        public static List<Student> GetAllStudent()
        {
            List<Student> listStudent = new List<Student>()
            {
                new Student
                {
                    Name="Deep",id=101,mark=800,gender="M",subjects=new List<string>{"ASP","C#"}
                },
                new Student
                {
                    Name="Aman",id=102,mark=800,gender="M",subjects=new List<string>{"SQL","C#"}
                },
                new Student
                {
                    Name="Ram",id=103,mark=500,gender="M",subjects=new List<string>{"ASP","OOP"}
                },
                new Student
                {
                    Name="Puja",id=104,mark=600,gender="F",subjects=new List<string>{".Net","C++"}
                },
                new Student
                {
                    Name="Suraj",id=105,mark=1000,gender="M",subjects=new List<string>{"JAVA","PHP"}
                },
                new Student
                {
                    Name="Aprana",id=106,mark=700,gender="F",subjects=new List<string>{"C","DS"}
                },
                new Student
                {
                    Name="Deepak",id=107,mark=800,gender="M",subjects=new List<string>{"ASP","C#"}
                }
            };
            return listStudent;
        }
    }
}