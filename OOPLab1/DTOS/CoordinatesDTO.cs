using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab1.DTOS
{
    class CoordinatesDTO//immutable in case two entities points to one DTO
    {
        public int X { get; private set; }

        public int Y { get; private set; }

        public CoordinatesDTO(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
