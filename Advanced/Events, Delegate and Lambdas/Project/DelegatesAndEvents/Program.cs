using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegatesAndEvents
{
    public delegate int BizRulesDelegate(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var Worker = new Worker();
            Worker.WorkPerformed += new EventHandler<WorkPerformedEventArgs>(Worker_WorkPerformed);
            Worker.WorkPerformed += demo; // Delegate inference functionality...
            Worker.WorkPerformed += delegate (object sender, WorkPerformedEventArgs e)
            {
                System.Console.WriteLine("This is Anonymous Method...");
            };
            Worker.WorkPerformed += (sender, e) => { System.Console.WriteLine("This is Lambda Expression..."); };

            Worker.WorkCompleted += new EventHandler(Worker_WorkCompleted);
            Worker.DoWork(5, WorkType.Golf);
            */

            
            var Data = new ProcessData();
            BizRulesDelegate addDel = (x, y) => x + y;
            BizRulesDelegate MulDel = (x, y) => x * y;
            Data.Process(10, 10, addDel);
            Data.Process(10, 10, MulDel);

            Action<int, int> myAddAction = (x, y) => System.Console.WriteLine($"Sum of {x} and {y} is : {x + y}");
            Action<int, int> myMulAction = (x, y) => System.Console.WriteLine($"Multiplie of {x} and {y} is : {x * y}");
            Data.ProcessAction(12, 10, myAddAction);
            Data.ProcessAction(12, 10, myMulAction);

            Func<int, int, int> addFuncDel = (x, y) => x + y;
            Func<int, int, int> mulFuncDel = (x, y) => x * y;
            Data.ProcessFunc(900, 100, addFuncDel);
            Data.ProcessFunc(900, 100, mulFuncDel);

            Predicate<string> predicateDelegate = (s) => s.Length > 0;
            Data.ProcessPredicate("Hello", predicateDelegate);
            
            Console.ReadLine();
            
            /*
            var customers = new List<Customer>
            {
                new Customer{Id = 101, Name = "Pavan", City = "Junagadh"},
                new Customer{Id = 102, Name = "Marshal", City = "Pune"},
                new Customer{Id = 104, Name = "Gixy", City = "Ahmedabad"},
                new Customer{Id = 103, Name = "Gixer", City = "Ahmedabad"},
            };

            var AmdCustomers = customers.Where(customer => customer.City == "Ahmedabad").OrderBy(customer => customer.Name);
            foreach (var AmdCustomer in AmdCustomers)
            {
                System.Console.WriteLine(AmdCustomer.Name);
            }
            */
        }

        static void Worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        {
            System.Console.WriteLine(e.Hours + " hours : " + e.WorkType);
        }

        static void demo(object sender, WorkPerformedEventArgs e)
        {
            System.Console.WriteLine("This is Multicasting...");
        }

        static void Worker_WorkCompleted(object sender, EventArgs e)
        {
            System.Console.WriteLine("Worker is done...");
        }
    }
}
