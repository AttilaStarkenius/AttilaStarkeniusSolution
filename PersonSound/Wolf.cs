using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonSound
{
    public class Wolf : Animal
    {
        public int NumberOfPups { get; set; }
        public Wolf(string name, double weight, int age) : base(name, weight, age)
        {
        }

        public override string DoSound()
        {
            return "Oooowhooo";
            //throw new NotImplementedException();
        }
    }
}
