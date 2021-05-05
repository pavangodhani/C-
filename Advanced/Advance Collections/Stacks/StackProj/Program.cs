using System;
using System.Collections.Generic;

namespace StackProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stackTry = new Stack<int>(10);
            stackTry.Push(10);
            stackTry.Push(20);
            stackTry.Push(30);
            stackTry.Push(40);
            stackTry.Push(50);

            var r = stackTry.Contains(60);
            System.Console.WriteLine(r);
            
            stackTry.Pop();
            stackTry.Clear();
            foreach(var item in stackTry)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
