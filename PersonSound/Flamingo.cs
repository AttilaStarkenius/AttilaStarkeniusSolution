using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonSound
{
    public class Flamingo : Bird
    {
        public double EyeWidth { get; set; }

        public Flamingo(string name, double weight, int age) : base(name, weight, age)
        {
        }
    }
}
