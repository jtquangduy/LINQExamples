using ExtensionMethods.Extensions;
using System;
using System.Collections.Generic;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "43.35";
            //double data = text.ToDouble();
            //Console.WriteLine(data);


            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee() {Id=1,Name="A"},
                new Employee() {Id=2,Name="B"}
            };

            //var enumerable = developers.GetEnumerator();

            //int count = 0;

            //while (enumerable.MoveNext())
            //{
            //    count++;
            //}
            //Console.WriteLine(count);


            Console.WriteLine(developers.Count());



            Console.Read();
        }
    }
}
