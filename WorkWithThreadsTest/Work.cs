using System;
using System.Threading;

namespace BrandMonitorTest
{
    public class Work
    {
        private readonly int _number;

        public Work(int number)
        {
            _number = number;
            Console.WriteLine($"Work number {_number} created");
        }

        public void Execute()
        {
            Console.WriteLine($"Work number {_number} executing...");
            Thread.Sleep(5000);
            Console.WriteLine($"Work number {_number} executed successfully");
        }
    }
}
