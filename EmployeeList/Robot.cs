using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeList
{
    internal class Robot
    {
        //2.Publika properties
        public int Length { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        //Robot robot = new Robot();
        //public int length

        public static int count;

        public Robot(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
