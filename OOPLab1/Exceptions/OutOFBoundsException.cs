using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab1.Exceptions
{
    class OutOFBoundsException: Exception
    {
        public override string Message => "Robot moved out of bounds of the room! It will be restored to previous position";
    }
}
