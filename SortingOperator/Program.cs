using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingOperator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>()
            {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 },
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 },
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 },
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 },
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 },
                new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 },
                new Student() { StudentID = 7, StudentName = "Rob",Age = 19  },
            };

            //Query
            var orderedByResult = from s in studentList
                                  orderby s.StudentName descending,s.Age ascending
                                  select s;

            var orderedbyResult = studentList.OrderByDescending(s => s.StudentName).ThenByDescending(s=>s.Age);

            foreach(var s in orderedByResult)
            {
                Console.WriteLine(s.StudentName);
            }
            Console.ReadLine();
        }
    }
}