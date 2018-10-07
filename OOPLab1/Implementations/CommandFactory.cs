

using InputParser;
using OOPLab1.Exceptions;
using OOPLab1.Interfaces;

namespace OOPLab1.Implementations
{
    class CommandFactory : ICommandFactory
    {
        private readonly IRobotLogger _logger;
        private readonly IMovable _robot;

        public CommandFactory(IRobotLogger logger, IMovable robot)
        {
            _logger = logger;
            _robot = robot;
        }

        public ICommand Create(string command, params string[] args)
        {
            switch (command)
            {
                case "move":
                    return CreateMoveCommand(args[0], args[1]);
                case "coords":
                    return CreateCoordinatesLogCommand();
                case "traveled":
                    return CreateLogTraveledDistanceCommand(args[0]);
                case "exit":
                    return new ExitCommand();
                default:
                    throw new CommandException();
            }
        }

        private ICommand CreateMoveCommand(string direction, string length)
        {
            return new MoveCommand(direction, int.Parse(length), _robot);
        }

        private ICommand CreateCoordinatesLogCommand()
        {
            return new LogCoordinatesCommand(_robot, _logger);
        }

        private ICommand CreateLogTraveledDistanceCommand(string direction)
        {
            return new LogStepsWalkedCommand(_robot,_logger,direction);
        }
    }
}
