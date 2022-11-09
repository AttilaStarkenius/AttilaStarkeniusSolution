using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonSound
{
    public class Bird : Animal
    {
        public double WingSpan { get; set; }
        public Bird(string name, double weight, int age) : base(name, weight, age)
        {
        }

        public override string DoSound()
        {
            return "chirp";

            //throw new NotImplementedException();
        }
    }
}
