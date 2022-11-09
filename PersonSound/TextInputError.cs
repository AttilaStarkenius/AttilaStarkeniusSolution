using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonSound
{
    public class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "“You tried to use a text input in a numeric only field. This fired an error!”";
            //throw new NotImplementedException();
        }
    }
}
