using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab1.Exceptions
{
    class MovedSameDirectionException: Exception
    {
        public override string Message => "Robot tried to move the same diraction twice. No action will be performed";
    }
}
