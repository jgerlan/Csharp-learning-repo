using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExercSec06_78
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfEmployees = 0;
            int idIncreaseSalary = 0;
            double percentIncreased = 0.0;
            Employee emp;
            List<Employee> employees = new List<Employee>();

            Console.Write("How many employees will be registered?");
            numberOfEmployees = int.Parse(Console.ReadLine());
            for (int count = 1; count <= numberOfEmployees; count++)
            {
                Console.WriteLine($"Employee #{count}");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                employees.Add(new Employee(id, name, salary));

            }
            Console.Write("Enter the employee id that will have salary increase: ");
            idIncreaseSalary = int.Parse(Console.ReadLine());
            emp = employees.Find(x => x.id == idIncreaseSalary);

            if (emp != null)
            {
                Console.Write("Enter value (%) to increase salary: ");
                percentIncreased = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                //employees.Find(x => x.id == idIncreaseSalary).increaseSalary(percentIncreased);
                emp.increaseSalary(percentIncreased);
                
                //Console.WriteLine(employees.Find(x => x.id == idIncreaseSalary));
            }
            else
            {
                Console.WriteLine("This id does not exist!");
                Console.WriteLine("Updated list of employees");
                Console.WriteLine();
                foreach (Employee empl in employees)
                {
                    Console.WriteLine(empl);
                }
            }

        }
    }
}
