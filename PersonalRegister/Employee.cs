using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PersonalRegister
{
    public class Employee
    {
        public int Id { get; set; }
        public string name { get; set; }
        public double salary { get; set; }
        
        public List<Employee>? Employees { get; set; }

        public Employee(string name, double salary)
        {
            name = name;
            salary = salary;
        }

    }
}
