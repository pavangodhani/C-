using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Linq;

namespace CollectionsProj
{
    class Program
    {
        static void Main(string[] args)
        {
            var demoList = new List<int>();

            for (int i = 0; i <= 10; i++)
            {
                demoList.Add(i);
            }

            var immutableDemoList = demoList.ToImmutableList();
            var readonlyDemoList = demoList.AsReadOnly();

            demoList.Add(11);

            foreach (var item in immutableDemoList)
            {
                System.Console.WriteLine(item);
            }

            List<Student> students = new List<Student>();
            students.Add(new Student(101, "Pavan"));
            students.Add(new Student(102, "Marshal"));
            students.Add(new Student(103, "Gixer"));

            foreach (var student in students)
            {
                System.Console.WriteLine($"{student.Id} : {student.Name}");
            }

            var studentDict = students.ToDictionary(x => x.Id);
            studentDict.Add(104, new Student(104, "Gixey"));
            
            foreach (var student in studentDict)
            {
                System.Console.WriteLine($"{student.Key} : {student.Value.Name}" );
            }   
        }
    }
}
