using OOPLab1.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to robot app!");//some spaghetti code
            var world = new InteractionObject();
            world.Run();
        }
    }
}
