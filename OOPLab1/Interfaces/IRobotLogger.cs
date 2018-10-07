using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPLab1.DTOS;

namespace OOPLab1.Interfaces
{
    interface IRobotLogger
    {
        void LogCurrentCoordinates(CoordinatesDTO coordinates);

        void LogDistanceTraveldInDirection(string direnction, int steps);

    }
}
