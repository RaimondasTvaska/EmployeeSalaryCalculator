using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryCalculator
{
    class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int ExperienceYear { get; set; }
        public EmployeePosition Position { get; set; }
        

        public Employee(string name, string surname, EmployeePosition position, int experience)
        {
            Name = name;
            Surname = surname;
            Position = position;
            ExperienceYear = experience;

        }
       

        public int GetSalary()
        {
            int salary = Position.BasicSalary;
            for (int i = 0; i < ExperienceYear; i++)
            {
                salary += salary * Position.Coeficient / 100;

            }
            return salary;
        }

        

    }
}
