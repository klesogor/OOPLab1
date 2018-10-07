using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPLab1.DTOS;
using OOPLab1.Interfaces;

namespace OOPLab1.Implementations
{
    class RobotLogger : IRobotLogger
    {
        public void LogCurrentCoordinates(CoordinatesDTO coordinates)
        {
            Console.WriteLine($"Robot's current position is: X:{coordinates.X} Y:{coordinates.Y}");
        }

        public void LogDistanceTraveldInDirection(string direction, int steps)
        {
            Console.WriteLine($"Robot made {steps} steps in direction {direction}");
        }
    }
}
