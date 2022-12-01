using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpÖvning5Garage10
{
    /*24.11.2022. ValueOutOfRangeException class, that inherits
     * from the class Exception, in case user input 
     is too small value or too large value*/
    public class ValueOutOfRangeException : Exception
    {
        private readonly float r_MaxValue;
        private readonly float r_MinValue;

        public ValueOutOfRangeException(string i_Message, float i_MaxValue, float i_MinValue)
            : base(i_Message)
        {
            r_MaxValue = i_MaxValue;
            r_MinValue = i_MinValue;
        }

        public float MaxValue
        {
            get { return r_MaxValue; }
        }

        public float MinValue
        {
            get { return r_MinValue; }
        }
    }
}