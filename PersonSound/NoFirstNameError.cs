using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonSound
{
    public class NoFirstNameError : UserError
    {
        public override string UEMessage()
        {
            return "“You have not written any first name in FName field. This fired an error!”";

            //throw new NotImplementedException();
        }
    }
}
