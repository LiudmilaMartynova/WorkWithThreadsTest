using System.Collections.Generic;
using System.Threading;

namespace BrandMonitorTest
{
    class Worker
    {
        private Queue<Work> _works;

        private Thread _workThread;

        private readonly object _locker;

        public Worker()
        {
            _works = new Queue<Work>();
            _workThread = new Thread(ExecuteWork);
            _locker = new object();
            _workThread.Start();
        }

        public void AddWork(Work work)
        {
            lock (_locker)
            {
                _works.Enqueue(work);
            }
        }

        private void ExecuteWork()
        {
            while (true)
            {
                lock (_locker)
                {
                    if (_works.Count != 0)
                        _works.Dequeue().Execute();
                    else
                        Thread.Sleep(10);
                }
            }
        }
    }
}
