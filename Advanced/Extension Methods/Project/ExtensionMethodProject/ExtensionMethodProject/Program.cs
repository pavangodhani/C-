using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodProject
{
    class Program
    {
        public void Test1()
        {
            Console.WriteLine("Method 1...");
        }
        public void Test2()
        {
            Console.WriteLine("Method 2...");
        }
        static void Main(string[] args)
        {
            var p = new Program();
            p.Test1();
            p.Test2();
            p.Test3(); //Extension method

            int i = 10;
            var result = i.Factorial(); // Extension method for Int32 struct...
            Console.WriteLine($"Factorial of {i} is {result}...");

            string str = "HeLlO hOw ARe YoU ?";
            str = str.ToProper(); // Adding Extension method into sealed String class...
            Console.WriteLine(str);
   
            Console.ReadLine();
        }
    }
}
