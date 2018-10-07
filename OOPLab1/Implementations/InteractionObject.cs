using InputParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab1.Implementations
{
    class InteractionObject
    {
        private readonly ErrorLogger _logger;
        private readonly IParser _parser;

        public InteractionObject()
        {
            var robotLogger = new RobotLogger();
            var robot = new Robot(
                robotLogger,
                new DTOS.CoordinatesDTO(0, 0),
                new StepsCounter(),
                new DTOS.CoordinatesBoundryDTO(0, 100, 0, 100)
            );
            _logger = new ErrorLogger();
            _parser = new Parser(new CommandFactory(robotLogger, robot));
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    _parser.Parse(GetInput()).Execute();
                }
                catch (Exception ex) { _logger.LogError(ex.Message); }
            }
        }

        private string GetInput()//yeah, separate class for IO would be better
        {
            return Console.ReadLine();
        }
    }
}
