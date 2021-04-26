using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncProg
{
    class Program
    {
        static void Main(string[] args)
        {
            methodTWO();
            System.Console.WriteLine("Code 1");
            System.Console.WriteLine("Code 2");
            methodOne();
            System.Console.WriteLine("Code 6");

            // var r = methodSec();
            // System.Console.WriteLine(r);

            System.Console.WriteLine("END..");

            Console.Read();
        }

        private static async void methodOne()
        {
            System.Console.WriteLine("Code 3");
            System.Console.WriteLine("Code 4");
            await Task.Delay(2000);
            System.Console.WriteLine("Code 5");

            System.Console.WriteLine("ENd MethodONE");
        }

        private static async void methodTWO()
        {

            await Task.Delay(1);
            System.Console.WriteLine("Code 7");

            System.Console.WriteLine("ENd Method two... ");
        }


        // private static async Task<int> methodSec()
        // {
        //     await Task.Delay(1000);
        //     var result = 100;
        //     return result;
        // }
    }
}
