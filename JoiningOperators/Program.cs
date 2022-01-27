using System;
using System.Collections.Generic;
using System.Linq;

namespace JoiningOperators
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IList<string> strList1 = new List<string>()
            {
                "One",
                "Two",
                "Three",
                "Four"
            };
            IList<string> strList2 = new List<string>()
            {
                "One",
                "Two",
                "Three",
                "Seven"
            };

            //var innerJoin = strList1.Join(strList2, str1 => str1, str2 => str2, (str1, str2) => str1);

            //var innerJoin = from str1 in strList1
            //                join str2 in strList2 on str1 equals str2
            //                select str1;

            //foreach(var s in innerJoin)
            //{
            //    Console.WriteLine(s);
            //}

            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", StandardID =1 },
                new Student() { StudentID = 2, StudentName = "Moin", StandardID =1 },
                new Student() { StudentID = 3, StudentName = "Bill", StandardID =2 },
                new Student() { StudentID = 4, StudentName = "Ram" , StandardID =2 },
                new Student() { StudentID = 5, StudentName = "Ron"}
            };

            IList<Standard> standardList = new List<Standard>() {
                new Standard(){ StandardID = 1, StandardName="Standard 1"},
                new Standard(){ StandardID = 2, StandardName="Standard 2"},
                new Standard(){ StandardID = 3, StandardName="Standard 3"}
            };

            //var innerJoin = studentList
            //    .Join(standardList,
            //    student => student.StandardID,
            //    standard => standard.StandardID, (student, standard) => new
            //    {
            //        StudentName = student.StudentName,
            //        StandardName = standard.StandardName
            //    });

            //var innerJoin = from stu in studentList
            //                join sta in standardList on stu.StandardID equals sta.StandardID
            //                select new
            //                {
            //                    StudentName = stu.StudentName,
            //                    StandardName = sta.StandardName
            //                };

            //foreach(var student in innerJoin)
            //{
            //    Console.WriteLine("Student:{0} in class:{1}", student.StudentName, student.StandardName);
            //}

            var groupJoin = from std in standardList
                            join s in studentList on std.StandardID equals s.StandardID
                            into studentGroup
                            select new
                            {
                                Students = studentGroup,
                                StandardFullName = std.StandardName
                            };
            foreach (var item in groupJoin)
            {
                Console.WriteLine(item.StandardFullName);
                foreach (var stud in item.Students)
                    Console.WriteLine(stud.StudentName);
            }
            Console.Read();
        }
    }
}