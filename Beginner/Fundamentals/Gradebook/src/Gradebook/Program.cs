﻿using System;
using GradeBook;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {

            IBook book = new DiskBook("Nobita's grade book");

            // book.AddGrade(89.1);
            // book.AddGrade(97.53);
            // book.AddGrade(63.25);
            // book.AddGrade(78.78);
            // book.AddGrade(90);

            book.GradeAdded -= OnGradeAdded;
            book.GradeAdded += OnGradeAdded;
            book.GradeAdded += OnGradeAdded;
            book.GradeAdded += OnGradeAdded;
            book.GradeAdded += TestGradeAdded;

            EnterGrades(book);

            var stats = book.GetStatistics();

            System.Console.WriteLine($"{book.Name}");
            System.Console.WriteLine($"low : {stats.Low}");
            System.Console.WriteLine($"high : {stats.High}");
            System.Console.WriteLine($"Avg : {stats.Average}");
            System.Console.WriteLine($"Letter : {stats.Letter}");

        }

        private static void EnterGrades(IBook book)
        {
            while (true)
            {
                System.Console.WriteLine("Enter a grade or 'q' for quit");
                var input = Console.ReadLine(); //Entered anything from console is always string type 

                if (input == "q")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(input); //Convert string type input into double type

                    book.AddGrade(grade);
                }
                catch (ArgumentException ex) // its catch exception whenever argument exception occure
                {
                    System.Console.WriteLine(ex.Message);
                    throw;

                }
                catch (FormatException ex) // its catch exception whenever format exception occure
                {
                    System.Console.WriteLine(ex.Message);

                }
                // catch (Exception ex) //its not good to handle all exception
                // {
                //     System.Console.WriteLine(ex.Message);

                // }
                finally
                {
                    //finally block use for when piece of code  always always want to execute 
                }
            }
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            System.Console.WriteLine("A grade was added...");
        }

        static void TestGradeAdded(object sender, EventArgs e)
        {
            System.Console.WriteLine("This is test...");
        }
    }
}
