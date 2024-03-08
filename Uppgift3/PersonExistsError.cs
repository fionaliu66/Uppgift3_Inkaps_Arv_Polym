using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3
{
    public class PersonExistsError : UserError
    {
        public override string UEMessage()
        {
            return "The person you are trying to create already exists";
        }
    }
}
