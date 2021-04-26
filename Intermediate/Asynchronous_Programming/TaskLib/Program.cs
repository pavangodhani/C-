using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace TaskLib
{
    class Program
    {
        static void Main(string[] args)
        {
            var source = new CancellationTokenSource();

            // Task t1 = new Task(() => DoWork(1, 4000));
            // t1.Start();
            // Task t2 = new Task(() => DoWork(2, 6000));
            // t2.Start();
            // Task t3 = new Task(() => DoWork(3, 3000));
            // t3.Start();

            try
            {
                var t1 = Task.Factory.StartNew(() => DoWork(1, 5000, source.Token)).ContinueWith((p) => DoOtherWork(1, 2000));
                source.Cancel();
                // var t2 = Task.Factory.StartNew(() => DoWork(2, 4000));
                // var t3 = Task.Factory.StartNew(() => DoWork(3, 3000));
                // var t4 = Task.Factory.StartNew(() => DoWork(4, 1000));
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.GetType());
            }


            // var taskList = new List<Task> { t1, t2, t3, t4 };
            // Task.WaitAll(taskList.ToArray()); //it execute all task work after that point move ahead...

            // for (int i = 0; i < 10; i++)
            // {
            //     System.Console.WriteLine("{0}...", i);
            //     Thread.Sleep(500);
            // }

            Parallel.For(0, 10, (i) => System.Console.WriteLine($"{i}...")); //its print 1 to 10 parallely

            System.Console.WriteLine($"Main End...");
            Console.ReadKey();
        }

        static void DoWork(int id, int sleep, CancellationToken token)
        {
            if(token.IsCancellationRequested)
            {
                System.Console.WriteLine("Cancellation Requested...");
                token.ThrowIfCancellationRequested();
            }
            System.Console.WriteLine($"Task {id} is start...{Thread.GetCurrentProcessorId()}");
            Thread.Sleep(sleep);
            System.Console.WriteLine($"Task {id} is End..{Thread.GetCurrentProcessorId()}");
        }

        static void DoOtherWork(int id, int sleep)
        {
            System.Console.WriteLine($"Another work of Task : {id} : Start");
            Thread.Sleep(sleep);
            var ID = Thread.GetCurrentProcessorId();
            System.Console.WriteLine($"Another work of Task : {id} : End...{ID}");
        }
    }

}
