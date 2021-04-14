using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dayOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            foreach (var day in dayOfWeek)
            {   
                System.Console.WriteLine(day);
            }

            System.Console.WriteLine("Which day do you want to display?");
            System.Console.WriteLine("(Monday = 1 etc.) >");

            int iDay = int.Parse(Console.ReadLine());

            string choosenDay = dayOfWeek[iDay-1];

            System.Console.WriteLine($"That day is {choosenDay}");
        }
    }
}
