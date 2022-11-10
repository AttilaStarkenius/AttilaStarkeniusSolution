using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

        public string returnSomeString()
        {
            return "This is a dog";
        }

        public override string DoSound()
        {
            return "woof";

            //throw new NotImplementedException();
        }
        public override string Stats(Animal animal)
        {
            Type myType = animal.GetType();
            IList<PropertyInfo> props = new List<PropertyInfo>(myType.GetProperties());

            foreach (PropertyInfo prop in props)
            {
                string s = JsonConvert.SerializeObject(prop.GetValue(animal, null));
                Console.WriteLine(s);
                return s;

                //string s = JsonConvert.SerializeObject(yourObject);

                //object propValue = prop.GetValue(myObject, null);

                // Do something with propValue
            }
            return "No such animal";
            //throw new NotImplementedException();
        }
    }
}
