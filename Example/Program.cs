using System;
using System.Linq;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students =
            {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 },
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 },
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 },
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 },
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 },
                new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 },
                new Student() { StudentID = 7, StudentName = "Rob",Age = 19  },
            };


            Student[] listStudent = students.Where(x => x.Age > 12 && x.Age < 20).ToArray();

            Console.WriteLine("Total student have age from 12 to 20:" + students.Length);

            Console.Read();
        }
    }
}
