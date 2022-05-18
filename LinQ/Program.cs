using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    internal class Program
    {

        static List<Person> GetEmployees()
        {
            List<Person> employees = new List<Person>()
                {
                    new Person(new DateTime(1990, 2, 2), "Bill", "Wick"),
                    new Person(new DateTime(1995, 6, 3), "John", "Wick"),
                    new Person(new DateTime(1996, 4, 3), "Bob", "Wick"),
                    new Person(new DateTime(2001, 2, 2), "Bill", "Smith"),
                    new Person(new DateTime(2000, 2, 2), "John", "Smith"),
                    new Person(new DateTime(2005, 2, 2), "Bob", "Smith"),
                    new Person(new DateTime(2003, 2, 2), "Ed", "Smith"),
                };
            return employees;
        }




        static void Main(string[] args)
        {
            List<Person> employees = GetEmployees();

            List<Person> youngEmployee = new List<Person>();

            foreach (Person employee in employees)
            {
                if (employee.GetDateOfBirth() > new DateTime(2000, 1, 1))
                {
                       youngEmployee.Add(employee);
                }
            }
            Console.WriteLine("Ilość wyników youngEmploye: "+youngEmployee.Count);
            Console.WriteLine();















        }



    }


}
