using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonSound
{
    public class Swan : Bird
    {
        public double NeckLength { get; set; }

        public Swan(string name, double weight, int age) : base(name, weight, age)
        {
        }
    }
}
