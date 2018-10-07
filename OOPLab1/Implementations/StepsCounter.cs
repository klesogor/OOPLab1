using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPLab1.Interfaces;

namespace OOPLab1.Implementations
{
    class StepsCounter : IStepsCounter
    {
        public int StepsUp { get; private set; }

        public int StepsDown { get; private set; }

        public int StepsLeft { get; private set; }

        public int StepsRight { get; private set; }

        public void AddStepsDown(int steps)
        {
            StepsDown += steps;
        }

        public void AddStepsLeft(int steps)
        {
            StepsLeft += steps;
        }

        public void AddStepsRight(int steps)
        {
            StepsRight += steps;
        }

        public void AddStepsUp(int steps)
        {
            StepsUp += steps;
        }
    }
}
