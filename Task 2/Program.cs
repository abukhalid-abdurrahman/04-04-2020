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
        public enum Positions
        {
            Supervisor = 8000,
            Manager = 6000,
            Programmer = 5500,
            Cleaner = 2000
        }
        ///<summary>
        ///Имя сотрудника
        ///</summary>
        public string Name { get; set; } 
        ///<summary>
        ///Фамилия сотрудника
        ///</summary>
        public string Surname { get; set; }
        ///<summary>
        ///Должность сотрудника
        ///</summary>
        public Positions EmployeePosition { get; set; }
        ///<summary>
        ///Зар-плата сотрудника
        ///</summary>
        public string Salary { get; set; }
        ///<summary>
        ///Стаж работы сотрудника
        ///</summary>
        public int Experience { get; set; }
        public Employee(string _name, string _surname)
        {
            Name = _name;
            Surname = _surname;
        }

        public double CalculateSalary()
        {
            double results = 0.0f;
            if(Experience > 5)
                results += 300;
            else if(Experience > 10)
                results += 600;
            else if(Experience > 15)
                results += 2200;

            return results;
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
