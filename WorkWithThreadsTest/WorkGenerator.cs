using System;
using System.Threading;

namespace BrandMonitorTest
{
    public class WorkGenerator
    {
        private Random rnd = new Random();

        private Worker _worker = new Worker();

        public void Generate(int worksNumber)
        {
            for (int i = 1; i <= worksNumber; i++)
            {
                Thread.Sleep(rnd.Next(1, 9) * 1000);
                _worker.AddWork(new Work(i));
            }
        }
    }
}
