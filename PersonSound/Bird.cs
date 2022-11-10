using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonSound
{
    public class Bird : Animal
    {
        /*10.11.2022. If every bird needs a new property,
         it should be added in this "Bird.cs" class.*/
        public double WingSpan { get; set; }
        public Bird(string name, double weight, int age) : base(name, weight, age)
        {
        }

        public override string DoSound()
        {
            return "chirp";

            //throw new NotImplementedException();
        }

        public override string Stats(Animal animal)
        {
            throw new NotImplementedException();
        }
    }
}
