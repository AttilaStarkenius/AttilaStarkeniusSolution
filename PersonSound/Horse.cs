using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonSound
{
    public class Horse : Animal
    {
        public double Height { get; set; }
        public Horse(string name, double weight, int age) : base(name, weight, age)
        {
        }

        public override string DoSound()
        {
            return "huh";

            //throw new NotImplementedException();
        }
    }
}
