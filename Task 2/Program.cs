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
        ///Должность и зар-плата сотрудника
        ///</summary>
        public Positions EmployeePosition { get; set; }
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
            if(Experience > 5) //+ к зарплате от стажа работы
                results += 300;
            else if(Experience > 10)
                results += 600;
            else if(Experience > 15)
                results += 2200;

            results += (int)EmployeePosition;
            results -= ((results * 13) / 100); // 13% - Налог
            results -= (results / 100); // 1% - Пенсионый фонд
            
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
