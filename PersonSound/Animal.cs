using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonSound
{
    public abstract class Animal
    {
        public string Name { get; set; }    
        public double Weight { get; set; }
        public int Age { get; set; }

        public abstract string DoSound();

        public Animal(string name, double weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }   
    }
}
