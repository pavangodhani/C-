using System;
using System.Collections.Generic;
using GradeBook;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array in C#
            // var grades = new double[] { 1.23, 2.23, 5.65, 989.23, 1.50 };
            // var grades = new[] { 1.23, 2.23, 5.65, 989.23, 1.50 }; //both are same
            
            // foreach (var grade in grades)
            // {
            //     System.Console.WriteLine(grade);
            // }
            

            // List in C#

            // List<double>grades = new List<double>();

            var book = new Book();
            book.AddGrade(89.1);

            var grades = new List<double>() { 1.23, 2.23, 5.65, 989.23, 1.50 }; 

            grades.Add(100.100);

            Console.WriteLine(grades.Count);

            foreach (var grade in grades)
            {
                System.Console.WriteLine(grade);
            }
            
            // float a = 3.12F;
            // Console.WriteLine("Hello C# Leaner");
            // System.Console.WriteLine($"{a}");
        }
    }
}
