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
            grades.Add(grade);
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

            return result;
        }

        private List<double> grades;
        public string Name;
    }

}