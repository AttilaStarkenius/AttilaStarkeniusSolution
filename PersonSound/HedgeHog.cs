using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonSound
{
    public class HedgeHog : Animal
    {
        public int NrOfSpikes { get; set; }
        public HedgeHog(string name, double weight, int age) : base(name, weight, age)
        {
        }

        public override string DoSound()
        {
            return "oink";

            //throw new NotImplementedException();
        }

        public override string Stats(Animal animal)
        {
            throw new NotImplementedException();
        }
    }
}
