using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3
{
    public class NullInputError : UserError
    {
        public override string UEMessage()
        {
            return "Input string cannot be null or empty";
        }
    }
}
