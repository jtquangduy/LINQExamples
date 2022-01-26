using System;
using System.Collections.Generic;
using System.Linq;

namespace QueryAndMethodSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            // string collection
            //IList<string> stringList = new List<string>()
            //{
            //    "C# Tutorials",
            //    "VB.NET Tutorials",
            //    "Learn C++",
            //    "MVC Tutorial",
            //    "Java"
            //};


            //LINQ Syntax
            //var result = from s in stringList
            //             where s.Contains("Tutorial")
            //             select s;


            //var result = stringList.Where(s=>s.Contains("Tutorial"));

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            // Student Collection
            IList<Student> students = new List<Student>()
            {
                new Student() {studentID=1,studentName="John",Age=13},
                new Student() {studentID=2,studentName="Moin",Age=21},
                new Student() {studentID=3,studentName="Bill",Age=18},
                new Student() {studentID=4,studentName="George",Age=20},
                new Student() {studentID=5,studentName="Ron",Age=15},
            };

            //var teenagerStudent = students.Where(t => t.Age > 12 && t.Age < 20).ToList();

            var teenagerStudent = from t in students
                                  where t.Age > 12 && t.Age < 20
                                  select t;

            foreach (var item in teenagerStudent)
            {
                Console.WriteLine(item.studentName);
            }




            Console.ReadLine();
        }
    }
}
