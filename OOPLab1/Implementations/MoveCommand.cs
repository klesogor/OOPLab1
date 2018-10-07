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
    class MoveCommand : ICommand
    {
        private readonly IMovable _movable;
        private readonly string _direction;
        private readonly int _lengh;

        public MoveCommand(string direction, int length, IMovable movable)
        {
            _direction = direction;
            _movable = movable;
            _lengh = length;
        }

        public void Execute()
        {
            switch (_direction)
            {
                case "up":
                    _movable.MoveUp(_lengh);
                    break;
                case "down":
                    _movable.MoveDown(_lengh);
                    break;
                case "left":
                    _movable.MoveLeft(_lengh);
                    break;
                case "right":
                    _movable.MoveRight(_lengh);
                    break;
                default:
                    throw new CommandException();
            }
        }
    }
}
