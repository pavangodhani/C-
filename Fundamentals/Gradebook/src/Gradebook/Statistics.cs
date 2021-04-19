using System;

namespace GradeBook
{
    public class Statistics
    {
        public double Average
        {
            get
            {
                return Sum / Count;
            }
        }

        public double High;
        public double Low;

        public char Letter
        {
            get
            {
                switch (Average)
                {
                    case var d when d >= 90.0:
                        //here first store value of result.Average in d veriable and check the condition which written after when keyword...
                        return 'A';

                    case var d when d >= 80.0:
                        return 'B';

                    case var d when d >= 70.0:
                        return 'C';

                    case var d when d >= 60:
                        return 'D';

                    default:
                        return 'F';

                }

            }
        }
        public double Sum;
        public int Count;

        public Statistics()
        {
            High = double.MinValue;
            Low = double.MaxValue;
            Sum = 0.0;
            Count = 0;

        }

        public void Add(double grade)
        {
            Sum += grade;
            Count++;

            High = Math.Max(High, grade);
            Low = Math.Min(Low, grade);
        }
    }
}