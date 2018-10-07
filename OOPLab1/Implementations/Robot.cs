using OOPLab1.Interfaces;
using OOPLab1.DTOS;
using OOPLab1.Exceptions;

namespace OOPLab1.Implementations
{
    class Robot: IMovable
    {
        private readonly IRobotLogger _logger;
        private readonly IStepsCounter _counter;
        private Directions _lastDirection = Directions.none;
        public CoordinatesDTO Coordinates { get; private set; }
        public CoordinatesBoundryDTO Boundries { get; private set; } //public in case we need it some where

        public int StepsUp => _counter.StepsUp;

        public int StepsDown => _counter.StepsDown;

        public int StepsLeft => _counter.StepsLeft;

        public int StepsRight => _counter.StepsRight;

        public Robot(
            IRobotLogger logger, 
            CoordinatesDTO coordinates, 
            IStepsCounter stepsCounter, 
            CoordinatesBoundryDTO boundries
        )
        {
            _logger = logger;
            Coordinates = coordinates;
            _counter = stepsCounter;
            Boundries = boundries;
        }

        public void MoveUp(int distance)
        {
            if (_lastDirection == Directions.up) throw new MovedSameDirectionException();
            _lastDirection = Directions.up;
            int newCoords = Coordinates.Y + distance;
            if (newCoords > Boundries.MaxY) throw new OutOFBoundsException();

            _counter.AddStepsUp(distance);
            Coordinates = new CoordinatesDTO(Coordinates.X, newCoords);
        }

        public void MoveDown(int distance)
        {
            if (_lastDirection == Directions.down) throw new MovedSameDirectionException();
            _lastDirection = Directions.down;
            int newCoords = Coordinates.Y - distance;
            if (newCoords < Boundries.MinY) throw new OutOFBoundsException();

            _counter.AddStepsDown(distance);
            Coordinates = new CoordinatesDTO(Coordinates.X, newCoords);
        }

        public void MoveLeft(int distance)
        {
            if (_lastDirection == Directions.left) throw new MovedSameDirectionException();
            _lastDirection = Directions.left;
            int newCoords = Coordinates.X - distance;
            if (newCoords < Boundries.MinX) throw new OutOFBoundsException();

            _counter.AddStepsLeft(distance);
            Coordinates = new CoordinatesDTO(newCoords, Coordinates.Y);
        }

        public void MoveRight(int distance)
        {
            if (_lastDirection == Directions.right) throw new MovedSameDirectionException();
            _lastDirection = Directions.right;
            int newCoords = Coordinates.X + distance;
            if (newCoords > Boundries.MaxX) throw new OutOFBoundsException();

            _counter.AddStepsRight(distance);
            Coordinates = new CoordinatesDTO(newCoords, Coordinates.Y);
        }

    }
}
