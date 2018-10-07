using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab1.Interfaces
{
    interface IStepsCounter
    {
        int StepsUp { get; }
        int StepsDown { get; }
        int StepsLeft { get; }
        int StepsRight { get; }

        void AddStepsUp(int steps);
        void AddStepsDown(int steps);
        void AddStepsLeft(int steps);
        void AddStepsRight(int steps);
    }
}
