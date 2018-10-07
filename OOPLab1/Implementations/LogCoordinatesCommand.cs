using InputParser;
using OOPLab1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab1.Implementations
{
    class LogCoordinatesCommand : ICommand
    {
        private readonly IMovable _movable;
        private readonly IRobotLogger _logger;

        public LogCoordinatesCommand(IMovable movable, IRobotLogger logger)
        {
            _movable = movable;
            _logger = logger;
        }

        public void Execute()
        {
            _logger.LogCurrentCoordinates(_movable.Coordinates);
        }
    }
}
