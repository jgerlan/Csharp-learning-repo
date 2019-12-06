using System;
using System.Collections.Generic;
using System.Text;

namespace ExercSec06_78
{
    class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public double salary { get; private set; }

        public Employee(int idEmployee, string nameEmployee, double salaryEmployee)
        {
            id = idEmployee;
            name = nameEmployee;
            salary = salaryEmployee;
        }

        public void increaseSalary(double percentage)
        {
            salary = salary * (1+(percentage/100));
        }

        public override string ToString()
        {
            return id+", "+name+", "+", "+salary;
        }
    }
}
