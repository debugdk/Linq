using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestProject
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DepartmentID { get; set; }
        public string City { get; set; }

        public  List<Employee> GetAllEmployees()
        {
            return new List<Employee>()
            {
                new Employee { ID = 1, Name = "Mark", DepartmentID = 1,City="Delhi" },
                new Employee { ID = 2, Name = "Steve", DepartmentID = 2,City="Raipur" },
                new Employee { ID = 3, Name = "Ben", DepartmentID = 1 ,City="Sitapur"},
                new Employee { ID = 4, Name = "Philip", DepartmentID = 1 ,City="Delhi"},
                new Employee { ID = 5, Name = "Mary", DepartmentID = 2 ,City="Patna"},
                new Employee { ID = 5, Name = "Mary", DepartmentID = 2 ,City="Delhi"},
                new Employee { ID = 5, Name = "Mary", DepartmentID = 2 ,City="Ram Nagar"},
                new Employee { ID = 6, Name = "Valarie", DepartmentID = 2 ,City="XYZ"},
                new Employee { ID = 7, Name = "John", DepartmentID = 1 ,City="Gajipur"},
                new Employee { ID = 8, Name = "Pam", DepartmentID = 1 ,City="UP"},
                new Employee { ID = 9, Name = "Stacey", DepartmentID = 2 ,City="Panjab"},
                new Employee { ID = 10, Name = "Andy"}
            };
        }
    }
}