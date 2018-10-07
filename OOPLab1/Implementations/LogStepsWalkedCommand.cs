using InputParser;
using OOPLab1.Exceptions;
using OOPLab1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab1.Implementations
{
    class LogStepsWalkedCommand : ICommand
    {
        private readonly IMovable _movable;
        private readonly IRobotLogger _logger;
        private readonly string _direction;

        public LogStepsWalkedCommand(IMovable movable, IRobotLogger logger, string direction)
        {
            _movable = movable;
            _logger = logger;
            _direction = direction;
        }

        public void Execute()
        {
            switch (_direction)
            {
                case "up":
                    _logger.LogDistanceTraveldInDirection("up", _movable.StepsUp);
                    break;
                case "down":
                    _logger.LogDistanceTraveldInDirection("down", _movable.StepsDown);
                    break;
                case "right":
                    _logger.LogDistanceTraveldInDirection("right", _movable.StepsRight);
                    break;
                case "left":
                    _logger.LogDistanceTraveldInDirection("left", _movable.StepsLeft);
                    break;
                default:
                    throw new CommandException(); 
            }
        }
    }
}
