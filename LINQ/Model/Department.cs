using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LINQ.Model
{
    public class Departmen
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public static List<Departmen> GetAllDepartments()
        {
            return new List<Departmen>()
        {
            new Departmen { ID = 1, Name = "IT"},
            new Departmen { ID = 2, Name = "HR"},
            new Departmen { ID = 3, Name = "Payroll"},
        };
        }
    }
}