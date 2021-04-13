using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book //By default its internal
    {

        public Book(string name)
        {
            grades = new List<double>();
            this.Name = name;
        }

        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
                //nameof keyword takes name of var,mathods or anything its covert into string representation of the symbol...
            }
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();

            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;


            foreach (var grade in grades)
            {
                result.High = Math.Max(result.High, grade);
                result.Low = Math.Min(result.Low, grade);

                result.Average += grade;

            }

            result.Average = result.Average / grades.Count;

            switch (result.Average)
            {
                case var d when d >= 90.0:
                    //here first store value of result.Average in d veriable and check the condition which written after when keyword...
                    result.Letter = 'A';
                    break;

                case var d when d >= 80.0:
                    result.Letter = 'B';
                    break;

                case var d when d >= 70.0:
                    result.Letter = 'C';
                    break;

                case var d when d >= 60:
                    result.Letter = 'D';
                    break;

                default:
                    result.Letter = 'F';
                    break;

            }

            return result;
        }

        private List<double> grades;

        public String Name //This is way of Defining Properties...
        {
            // get
            // {
            //     return name;
            // }
            // set
            // {
            //     if (!String.IsNullOrEmpty(value))
            //     {
            //         name = value;
            //     }
            //     else
            //     {
            //         throw new ArgumentException("Name not allowed to empty");
            //     }
            // }

            //These is short cut of get and set of any property...
            get;
            private set; // Now we can not override the value of name... //its also seems like a readonly...
        }

        readonly string category = "Science"; //A readonly field cannot be assigned to (except in a constructor or init-only setter of the type in which the field is defined or a variable initializer)

        public const string CATEGORY = "Science"; //Developer use naming convention of const field in upperCase...
    }

}