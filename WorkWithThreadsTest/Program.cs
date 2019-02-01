using System;

namespace BrandMonitorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var wg = new WorkGenerator();
            wg.Generate(5000);
            Console.Read();
        }
    }
}
