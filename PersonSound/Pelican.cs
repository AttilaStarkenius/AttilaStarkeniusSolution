using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonSound
{
    public class Pelican : Bird
    {
        public double LegLength { get; set; }

        public Pelican(string name, double weight, int age) : base(name, weight, age)
        {
        }
    }
}
