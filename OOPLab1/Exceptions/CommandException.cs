using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab1.Exceptions
{
    class CommandException: Exception
    {
        public override string Message => "Incorrect command or command arguments";
    }
}
