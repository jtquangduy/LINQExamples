using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomFilterOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student Collection
            IList<Student> students = new List<Student>()
            {
                new Student() {studentID=1,studentName="John",Age=13},
                new Student() {studentID=2,studentName="Moin",Age=21},
                new Student() {studentID=3,studentName="Bill",Age=18},
                new Student() {studentID=4,studentName="George",Age=20},
                new Student() {studentID=5,studentName="Ron",Age=15},
            };

            var result = students.Where(s => s.Age > 12);

            foreach(var student in students)
            {
                Console.WriteLine(student);
            }

            Console.ReadLine();
        }
    }
}
