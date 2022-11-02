using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeList
{
    public class PayRoll
    {
        public List<Employee> payRoll;
        public PayRoll()
        {
            payRoll = new List<Employee>();
        }

        public void AddEmployee(string name, int salary)
        {
            Employee employee = new Employee(name, salary);
           payRoll.Add(employee);
        }

        public List<Employee> GetEmployees()
        {
            //ToDo: fix not good!
            return payRoll;
        }
    }
}
