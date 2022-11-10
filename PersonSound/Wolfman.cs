using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonSound
{
    public class Wolfman : Wolf, IPerson
    {
        public void Talk()
        {
            // The body of Talk() is provided here
            Console.WriteLine("The Wolfman says: Hey");
        }
        public Wolfman(string name, double weight, int age) : base(name, weight, age)
        {
        }

        //public void Talk()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
