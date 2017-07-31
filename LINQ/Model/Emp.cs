using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LINQ.Model
{
    public class Emp
    {
        public int id { set; get; }
        public string name { set; get; }
        public int DId { set; get; }
        public string gender { set; get; }
        public double salary { set; get; }
    }
    
    public class Department
    {
        public int id { set; get; }
        public string name { set; get; }

    }
}