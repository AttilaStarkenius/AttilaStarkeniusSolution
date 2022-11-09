using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonSound
{
    public class Worm : Animal
    {
        public bool IsPoisonous { get; set; }
        public Worm(string name, double weight, int age) : base(name, weight, age)
        {
        }

        public override string DoSound()
        {
            return "grunt";

            //throw new NotImplementedException();
        }
    }
}
