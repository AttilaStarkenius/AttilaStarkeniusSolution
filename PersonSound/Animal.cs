using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonSound
{
    public abstract class Animal
    {
        /*10.11.2022. If every animal needs a new property,
         it should be added in this "Animal.cs" class.*/
        public string Name { get; set; }    
        public double Weight { get; set; }
        public int Age { get; set; }

        public abstract string Stats(Animal animal);
        //{
        //    return "chirp";

            //throw new NotImplementedException();
        //}

        public abstract string DoSound();

        public Animal(string name, double weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }   
    }
}
