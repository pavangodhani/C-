﻿using System;
using static System.Console;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter first number");
            int number1 = int.Parse(ReadLine());

            WriteLine("Enter second number");
            int number2 = int.Parse(ReadLine());

            WriteLine("Enter operation");
            string operation = ReadLine().ToUpperInvariant();


            var calculator = new Calculator();

            try
            {
                int result = calculator.Calculate(number1, number2, null);
                DisplayResult(result);
            }
            catch (ArgumentNullException ex) when (ex.ParamName == "operation")
            {
                // Log.Error(ex);
                WriteLine($"Operation was not provided. {ex}");
            }
            catch (ArgumentNullException ex)
            {
                // Log.Error(ex);
                WriteLine($"An argument was null. {ex}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                // Log.Error(ex);
                WriteLine($"Operation is not supported. {ex}");
            }
            catch (Exception ex)
            {
                WriteLine($"Sorry, something went wrong. {ex}");
            }
            finally
            {
                WriteLine("...finally...");
            }
            


            
            WriteLine("\nPress enter to exit.");
            ReadLine();
        }

        private static void DisplayResult(int result)
        {
            WriteLine($"Result is: {result}");
        }
    }
}
