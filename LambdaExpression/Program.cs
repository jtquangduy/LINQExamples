using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee() {Id=1,Name="Alex"},
                new Employee() {Id=2,Name="Barry"}
            };

            //foreach(var employee in developers.Where(NameStartWithA))
            //{
            //    Console.WriteLine(employee.Name);
            //}

            foreach (var employee in developers.Where(e => e.Name.StartsWith("A")))
            {
                Console.WriteLine(employee.Name);
            }

            Console.ReadKey();
        }

        //private static bool NameStartWithA(Employee employee)
        //{
        //    return employee.Name.StartsWith("A");
        //}
    }
}
