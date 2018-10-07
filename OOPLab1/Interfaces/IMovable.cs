using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPLab1.DTOS;

namespace OOPLab1.Interfaces
{
    interface IMovable
    {
        void MoveUp(int distance);

        void MoveDown(int distance);

        void MoveLeft(int distance);

        void MoveRight(int distance);

        CoordinatesDTO Coordinates { get; }

        int StepsUp { get; }
        int StepsDown { get; }
        int StepsLeft { get; }
        int StepsRight { get; }
    }
}
