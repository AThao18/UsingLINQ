using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingLINQ
{
    class Employees
    {
        public int EmployeeID { get; set; }
        public String EmployeeName { get; set; }
        public int Age { get; set; }
    }//class Employee
    class Program
    {
        static void Main(string[] args)
        {
            Employees[] employeeArray = {
                new Employees() { EmployeeID = 1, EmployeeName = "Ace", Age = 29},
                new Employees() { EmployeeID = 2, EmployeeName = "Beth", Age = 22},
                new Employees() { EmployeeID = 3, EmployeeName = "Carl", Age = 22},
                new Employees() { EmployeeID = 4, EmployeeName = "Danny", Age = 27},
                new Employees() { EmployeeID = 5, EmployeeName = "Aaron", Age = 35},
                new Employees() { EmployeeID = 6, EmployeeName = "Ben", Age = 35},
                new Employees() { EmployeeID = 7, EmployeeName = "Carter", Age = 21},
                new Employees() { EmployeeID = 8, EmployeeName = "Dutch", Age = 37},
                new Employees() { EmployeeID = 9, EmployeeName = "Austin", Age = 41},
                new Employees() { EmployeeID = 10, EmployeeName = "Benny", Age = 25},
                new Employees() { EmployeeID = 11, EmployeeName = "Cass", Age = 26},
                new Employees() { EmployeeID = 12, EmployeeName = "Dent", Age = 33},
                new Employees() { EmployeeID = 13, EmployeeName = "Allan", Age = 26},
                new Employees() { EmployeeID = 14, EmployeeName = "Bret", Age = 20},
                new Employees() { EmployeeID = 15, EmployeeName = "Con", Age = 30},
            };

            var emp = from a in employeeArray
                      where a.Age > 21 && a.Age < 30
                      select a;

            foreach (var emps in emp)
            {
                Console.WriteLine("\nEmployees whos age is between 21 and 40 are : " + emps.EmployeeName);
            }


            Console.WriteLine("___________________________________________________________________");
            

            var groups = from a in employeeArray
                         orderby a.Age
                         group a by a.Age;

            foreach (var empls in groups)
            {
                Console.WriteLine("\nAge Group: {0}", empls.Key);
                foreach (Employees e in empls)
                {
                    Console.WriteLine("Employee Name: {0}", e.EmployeeName);
                }
            }

            Console.WriteLine("________________________________________________________________________________");

            var letterB = from b in employeeArray
                       where b.EmployeeName.StartsWith("B")
                       select b;

            foreach (var start in letterB)
            {
                Console.WriteLine("\nEmployees names that start with the letter B are: " + start.EmployeeName);
            }


        }
    }
}
