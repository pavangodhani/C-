using System;

namespace DelegatesAndEvents
{
    class ProcessData
    {

        public void Process(int x, int y, BizRulesDelegate del)
        {
            var result = del(x, y);
            System.Console.WriteLine(result);
        }

        public void ProcessAction(int x, int y, Action<int, int> action)
        {
            action(x, y);
            // System.Console.WriteLine("Action has been processed...");
        }

        public void ProcessFunc(int x, int y, Func<int, int, int> FuncDel)
        {
            var result = FuncDel(x, y);
            System.Console.WriteLine("Func<T, TResult> has been processed...");
            System.Console.WriteLine($"{result}");
        }

        public void ProcessPredicate(string s1, Predicate<string> predicateDel)
        {
            var result = predicateDel(s1);
            System.Console.WriteLine("Predicate has been processed...");
            System.Console.WriteLine(result);
        }
    }
}