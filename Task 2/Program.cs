/*
 * Developed by Faridun Berdiev
 * Date: 04.04.2020
 * Second Task
*/
using System;

namespace Task_2
{
    class Employee
    {
        public string Name { get; set; } 
        public string Surname { get; set; }
        public string Position { get; set; }
        public string Salary { get; set; }
        public Employee(string _name, string _surname)
        {
            Name = _name;
            Surname = _surname;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
