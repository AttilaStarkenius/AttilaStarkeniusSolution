using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonSound
{
    public class Dog : Animal
    {
        public double LengthOfTail { get; set; }
        public Dog(string name, double weight, int age) : base(name, weight, age)
        {
        }

        public override string DoSound()
        {
            return "woof";

            //throw new NotImplementedException();
        }
    }
}
