using System;
using OOPLab1.Interfaces;

namespace OOPLab1.Implementations
{
    class ErrorLogger : IErrorLogger
    {
        public void LogError(string error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(error);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
