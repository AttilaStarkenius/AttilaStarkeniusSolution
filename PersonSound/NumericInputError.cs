using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonSound
{
    public class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return "“You tried to use a numeric input in a text only field. This fired an error!”";
            //throw new NotImplementedException();
        }
    }
}
