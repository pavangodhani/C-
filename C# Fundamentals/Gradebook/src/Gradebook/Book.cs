using System;
using System.Collections.Generic;
using System.IO;

namespace GradeBook
{
    public delegate void GradeAddDelegate(object sender, EventArgs args); //Defining a delegate for add grade event...

    public class NameObject //Create a class and inheritated in Book class...
    {
        public NameObject(string name) //Constructors...
        {
            Name = name;
        }

        public string Name //Property 
        {
            get;
            set;
        }
    }

    public interface IBook
    {
        void AddGrade(double grade);
        Statistics GetStatistics();
        string Name
        {
            get;
        }
        event GradeAddDelegate GradeAdded;
    }

    public abstract class Book : NameObject, IBook
    {
        protected Book(string name) : base(name)
        {
        }

        public abstract event GradeAddDelegate GradeAdded;

        public abstract void AddGrade(double grade); //abstract mathods are by default virtual... 

        public abstract Statistics GetStatistics();


        // public virtual Statistics GetStatistics() //'Virtual' keyword is a way in C# of saying here's a method that's in this class but derived class might choose to override the implementation details for this method...   

    }

    public class DiskBook : Book
    {
        public DiskBook(string name) : base(name)
        {
        }

        public override event GradeAddDelegate GradeAdded;

        public override void AddGrade(double grade)
        {
            using (var writer = File.AppendText($"{Name}.txt"))
            {
                writer.WriteLine(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();

            using (var reader = File.OpenText($"{Name}.txt"))
            {
                var line = reader.ReadLine();

                while (line != null)
                {
                    var number = double.Parse(line);
                    result.Add(number);
                    line = reader.ReadLine();
                }
            }
            return result;
        }
    }

    public class InMemoryBook : Book //By default its internal
    {

        //'base()' is reference to the base class in this case it's a Nameobject...and in parentheses what base class need to construct pass it like here we pass name which is string type ...
        public InMemoryBook(string name) : base(name)
        {
            grades = new List<double>();
            this.Name = name;
        }

        public override void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
                // 'nameof' keyword takes name of var,mathods or anything its covert into string representation of the symbol...
            }
        }

        public override event GradeAddDelegate GradeAdded;

        public override Statistics GetStatistics()
        {
            var result = new Statistics();

            // // result.Average = 0.0;
            // result.High = double.MinValue;
            // result.Low = double.MaxValue;


            foreach (var grade in grades)
            {
                result.Add(grade);

                // result.High = Math.Max(result.High, grade);
                // result.Low = Math.Min(result.Low, grade);

                // result.Average += grade;

            }

            // result.Average = result.Average / grades.Count;

            // switch (result.Average)
            // {
            //     case var d when d >= 90.0:
            //         //here first store value of result.Average in d veriable and check the condition which written after when keyword...
            //         result.Letter = 'A';
            //         break;

            //     case var d when d >= 80.0:
            //         result.Letter = 'B';
            //         break;

            //     case var d when d >= 70.0:
            //         result.Letter = 'C';
            //         break;

            //     case var d when d >= 60:
            //         result.Letter = 'D';
            //         break;

            //     default:
            //         result.Letter = 'F';
            //         break;

            // }

            return result;
        }

        private List<double> grades;

        /*
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
            set;
            
            // private set; // Now we can not override the value of name... //its also seems like a readonly or constant...
        }
        */

        readonly string category = "Science"; //A readonly field cannot be assigned to (except in a constructor or init-only setter of the type in which the field is defined or a variable initializer)

        public const string CATEGORY = "Science"; //Developer use naming convention of const field in upperCase...
    }

}