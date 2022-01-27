using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FilteringOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //IList<Student> studentList =new List<Student>()
            //{
            //    new Student() { StudentID = 1, StudentName = "John", Age = 18 },
            //    new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 },
            //    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 },
            //    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 },
            //    new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 },
            //    new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 },
            //    new Student() { StudentID = 7, StudentName = "Rob",Age = 19  },
            //};


            //var filteredResult = from s in studentList
            //                     where s.Age > 12
            //                     where s.Age < 20
            //                     select s.StudentName;

            //var filteredResultx = studentList.Where(s => s.Age > 12).Where(s => s.Age < 20).ToList();



            // OfType
            IList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add("One");
            mixedList.Add("Two");
            mixedList.Add(3);
            mixedList.Add(new Student() { StudentID = 1, StudentName = "Bill" });

            var stringResult = from s in mixedList.OfType<string>()
                               select s;

            foreach(var s in stringResult)
            {
                Console.WriteLine(s);
            }

            var intResult = from s in mixedList.OfType<int>()
                               select s;

            foreach (var i in intResult)
            {
                Console.WriteLine(i);
            }

            var studentResult = from s in mixedList.OfType<Student>()
                            select s;

            foreach (var i in studentResult)
            {
                Console.WriteLine(i.StudentName);
            }

            Console.ReadKey();
        }
    }
}
