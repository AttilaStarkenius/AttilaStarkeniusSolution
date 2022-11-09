using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonSound
{
    public class LessThanZeroError : UserError
    {
        public override string UEMessage()
        {
            return "“You have entered value less than 0 in Age field. This fired an error!”";

            //throw new NotImplementedException();
        }
    }
}
